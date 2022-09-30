Option Strict On

Public Class BookList

    ' 一覧表示のためのリスト型変数
    Private bookList As List(Of Book)
    ' データベース操作のための変数
    Private manageDB As ManageDB

    ''' <summary>
    ''' 登録ボタン押下でBookDetailフォームを開く。Showにbookを引数として指定せず、新規登録画面として開く。
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click

        Dim bookDetail As New BookDetail()
        bookDetail.Owner = Me

        Dim dialogResult As DialogResult = bookDetail.ShowDialog()
        If dialogResult = DialogResult.OK Or dialogResult = DialogResult.Cancel Then
            AllBookListShow()
        End If

    End Sub

    ''' <summary>
    ''' ListViewに表示されているコントロールをシングルクリックしたときの動作。
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BookListViewItemActivate(sender As Object, e As EventArgs) Handles BookListView.ItemActivate

        Dim lv As ListView = DirectCast(sender, ListView)
        Dim book As Book = bookList(lv.FocusedItem.Index)

        Dim bookDetail As New BookDetail(book)
        bookDetail.Owner = Me

        Dim dialogResult As DialogResult = bookDetail.ShowDialog()
        If dialogResult = DialogResult.OK Or dialogResult = DialogResult.Cancel Then
            AllBookListShow()
        End If

    End Sub

    ''' <summary>
    ''' フォーム読み込み時の初期設定。ータベースから本全件取得し表示する。BookListViewの設定も行っている（HoverSelectionとActivationの設定）
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BookList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AllBookListShow()

        ' ポイントで選択できるようにする
        BookListView.HoverSelection = True
        ' シングルクリックでアクティブにする
        BookListView.Activation = ItemActivation.OneClick

    End Sub

    ''' <summary>
    ''' 幅w、高さhのImageオブジェクトを作成
    ''' </summary>
    ''' <param name="image"></param>
    ''' <param name="w"></param>
    ''' <param name="h"></param>
    ''' <returns></returns>
    Public Shared Function CreateThumbnail(ByVal image As Image, ByVal w As Integer, ByVal h As Integer) As Image
        Dim canvas As New Bitmap(w, h)

        Dim g As Graphics = Graphics.FromImage(canvas)
        g.FillRectangle(New SolidBrush(Color.White), 0, 0, w, h)

        Dim fw As Double = CDbl(w) / CDbl(image.Width)
        Dim fh As Double = CDbl(h) / CDbl(image.Height)
        Dim scale As Double = Math.Min(fw, fh)

        Dim w2 As Integer = CInt(image.Width * scale)
        Dim h2 As Integer = CInt(image.Height * scale)

        g.DrawImage(image, (w - w2) \ 2, (h - h2) \ 2, w2, h2)
        g.Dispose()

        Return canvas
    End Function

    ''' <summary>
    ''' 本をデータベースから全件取得し、BookListViewに表示する
    ''' </summary>
    Private Sub AllBookListShow()

        manageDB = New ManageDB()
        ' 登録してある本の全件を取得
        bookList = manageDB.GetAllBookData()

        ' サムネイル画像のサイズを設定
        Dim width As Integer = 170
        Dim height As Integer = 256

        BookImageList.Dispose()
        BookListView.Clear()
        BookImageList.ImageSize = New Size(width, height)
        BookListView.LargeImageList = BookImageList

        ' サムネイルに表示する本のタイトルをリストで持っておく
        Dim bookTitle As New List(Of String)

        For Each book As Book In bookList

            bookTitle.Add(book.Title)

            Dim thumbnail As Image = CreateThumbnail(book.BookImage, width, height)
            BookImageList.Images.Add(thumbnail)

        Next

        ' ListViewへサムネイル画像と本のタイトルを表示する
        For i As Integer = 0 To (BookImageList.Images.Count - 1)
            BookListView.Items.Add(bookTitle(i), i)
        Next

    End Sub

End Class
