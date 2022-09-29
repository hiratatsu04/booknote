Option Strict On

Public Class BookList

    Private bookList As List(Of Book)
    Private manageDB As ManageDB

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click

        Dim f As New BookDetail()
        f.ShowDialog(Me)

    End Sub

    Private Sub BookList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        manageDB = New ManageDB()
        ' 登録してある本の全件を取得
        bookList = manageDB.GetAllBookData()

        ' サムネイル画像のサイズを設定
        Dim width As Integer = 250
        Dim height As Integer = 200

        BookImageList.Dispose()
        BookListView.Clear()
        BookImageList.ImageSize = New Size(Width, Height)
        BookListView.LargeImageList = BookImageList

        ' サムネイルに表示する本のタイトルをリストで持っておく
        Dim bookTitle As New List(Of String)

        For Each book As Book In bookList

            bookTitle.Add(book.Title)

            ' 本のサムネイル画像がなければ、Noimageを適応する
            If book.BookImage Is Nothing Then
                Dim filePath As String = System.Environment.CurrentDirectory + "\image\noimage.png"
                Dim noImage As Image = Bitmap.FromFile(filePath)
                Dim thumbnail As Image = createThumbnail(noImage, width, height)
                BookImageList.Images.Add(thumbnail)
            Else
                BookImageList.Images.Add(book.BookImage)
            End If

        Next

        ' ListViewへサムネイル画像と本のタイトルを表示する
        For i As Integer = 0 To (BookImageList.Images.Count - 1)
            BookListView.Items.Add(bookTitle(i), i)
        Next

    End Sub

    ' 幅w、高さhのImageオブジェクトを作成
    ' 何しているのかまだわかっていない。後で理解する。
    Function createThumbnail(ByVal image As Image, ByVal w As Integer, ByVal h As Integer) As Image
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        manageDB = New ManageDB()
        ' 登録してある本の全件を取得
        bookList = manageDB.GetAllBookData()

        ' サムネイル画像のサイズを設定
        Dim width As Integer = 250
        Dim height As Integer = 200

        BookImageList.Dispose()
        BookListView.Clear()
        BookImageList.ImageSize = New Size(width, height)
        BookListView.LargeImageList = BookImageList

        ' サムネイルに表示する本のタイトルをリストで持っておく
        Dim bookTitle As New List(Of String)

        For Each book As Book In bookList

            bookTitle.Add(book.Title)

            ' 本のサムネイル画像がなければ、Noimageを適応する
            If book.BookImage Is Nothing Then
                Dim filePath As String = System.Environment.CurrentDirectory + "\image\noimage.png"
                Dim noImage As Image = Bitmap.FromFile(filePath)
                Dim thumbnail As Image = createThumbnail(noImage, width, height)
                BookImageList.Images.Add(thumbnail)
            Else
                BookImageList.Images.Add(book.BookImage)
            End If

        Next

        ' ListViewへサムネイル画像と本のタイトルを表示する
        For i As Integer = 0 To (BookImageList.Images.Count - 1)
            BookListView.Items.Add(bookTitle(i), i)
        Next
    End Sub
End Class
