Option Strict On

Public Class BookDetail

    Private book As Book
    Private mode As FormMode

    Enum FormMode
        Edit    ' 編集モード
        Regist  ' 新規登録モード
        Show    ' 本の情報表示モード（編集不可）
    End Enum

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    Sub New()
        InitializeComponent()
        mode = FormMode.Regist
    End Sub

    ''' <summary>
    ''' 引数ありコンストラクタ。引数のbookの値をフォームに表示する
    ''' </summary>
    ''' <param name="book"></param>
    Sub New(book As Book)
        Me.book = book
        InitializeComponent()
        ShowBookData()
        ControlShowMode()
        mode = FormMode.Show
    End Sub

    ''' <summary>
    ''' TrackBarスクロールの動作。Integer型のTrackBarを10で割って、0.1段階で数値を扱えるようにしている。
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles ReviewTrackBar.Scroll

        ReviewLabel.Text = (ReviewTrackBar.Value / 10).ToString("0.0")

    End Sub

    ''' <summary>
    ''' 保存ボタンの動作
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        ' 入力必須項目の値有無チェック
        ' 値が入っていなければ登録・更新しない
        If Not IsValid() Then Return

        ' 新規登録モードであれば、bookオブジェクトをを新規作成
        If mode = FormMode.Regist Then
            Me.book = New Book()
        End If

        Me.book.Title = TitleTextBox.Text
        Me.book.Author = AuthorTextBox.Text
        Me.book.BookImage = BookImagePictureBox.Image
        Me.book.Genre = GenreTextBox.Text
        Me.book.ReviewValue = ReviewTrackBar.Value
        Me.book.Memo = MemoRichTextBox.Text
        Me.book.BuyDate = ConvertStringToDate(BuyDateTextBox.Text)
        Me.book.StartReadDate = ConvertStringToDate(StartDateTextBox.Text)
        Me.book.EndReadDate = ConvertStringToDate(EndDateTextBox.Text)

        ' モードにより、新規登録か更新か分岐
        If mode = FormMode.Regist Then
            ' bookの情報を登録する
            ManageDB.RecodeBook(Me.book)

            ' 一覧表示フォームにOKを渡してフォームを閉じる
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            ' bookの情報を更新する
            ManageDB.UpdateBookData(Me.book)

            ControlShowMode()

            ' 更新日を取得するために、bookオブジェクトの内容を取得
            book = ManageDB.GetOneBookData(book)
            ShowBookData()
        End If

    End Sub

    ''' <summary>
    '''　入力値のチェック。必要項目への記入漏れ、日付形式の確認を行う。
    ''' </summary>
    ''' <returns>入力値が正しければTrue 、そうでなければFalseを返す</returns>
    Private Function IsValid() As Boolean

        If TitleTextBox.Text = "" OrElse AuthorTextBox.Text = "" OrElse BuyDateTextBox.Text = "" Then
            MessageBox.Show("タイトル、著者、購入日は入力が必須です。")
            Return False
        End If

        ' 日付入力テキストの形式チェック
        If Not BuyDateTextBox.Text = "" AndAlso ConvertStringToDate(BuyDateTextBox.Text) = Nothing Then
            BuyDateTextBox.Clear()
            BuyDateTextBox.Focus()
            Return False
        End If
        If Not StartDateTextBox.Text = "" AndAlso ConvertStringToDate(StartDateTextBox.Text) = Nothing Then
            StartDateTextBox.Clear()
            StartDateTextBox.Focus()
            Return False
        End If
        If Not EndDateTextBox.Text = "" AndAlso ConvertStringToDate(EndDateTextBox.Text) = Nothing Then
            EndDateTextBox.Clear()
            EndDateTextBox.Focus()
            Return False
        End If

        Return True

    End Function

    ''' <summary>
    ''' 画像登録ボタンの動作。ダイアログを表示し、PictureBoxに選択した画像を表示する。
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RegisterImageButton_Click(sender As Object, e As EventArgs) Handles RegisterImageButton.Click

        'OpenFileDialogクラスのインスタンスを作成
        Dim ofd As New OpenFileDialog()

        'ダイアログを表示する
        If ofd.ShowDialog() = DialogResult.OK Then
            Dim bookImage As System.Drawing.Image = System.Drawing.Image.FromFile(ofd.FileName)

            bookImage = BookList.CreateThumbnail(bookImage, BookImagePictureBox.Width, BookImagePictureBox.Height)

            BookImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage
            BookImagePictureBox.Image = bookImage
        End If

    End Sub

    ''' <summary>
    ''' String型のデータをDate型に変換する。
    ''' </summary>
    ''' <param name="str"></param>
    ''' <returns></returns>
    Private Function ConvertStringToDate(str As String) As Date

        Dim convertedDate As Date = Nothing

        If Not str = "" Then
            If Not Date.TryParseExact(str, "yyyyMMdd", System.Globalization.DateTimeFormatInfo.InvariantInfo, System.Globalization.DateTimeStyles.None, convertedDate) Then

                MessageBox.Show($"{str}の値をDate型に変換できません。" & Environment.NewLine & "'yyyyMMdd'の形式で入力ください。")
            End If
        End If

        Return convertedDate

    End Function

    ''' <summary>
    ''' 設定されているbookのデータを各種コントロールに代入する
    ''' </summary>
    Private Sub ShowBookData()

        TitleTextBox.Text = Me.book.Title
        AuthorTextBox.Text = Me.book.Author
        BookImagePictureBox.Image = Me.book.BookImage
        GenreTextBox.Text = Me.book.Genre
        ReviewLabel.Text = (Me.book.ReviewValue / 10).ToString()
        ReviewTrackBar.Value = CType(Me.book.ReviewValue, Integer)
        MemoRichTextBox.Text = Me.book.Memo
        BuyDateTextBox.Text = Me.book.BuyDate.ToString("yyyyMMdd")

        If Me.book.StartReadDate = #1/1/0001 12:00:00 AM# Then
            StartDateTextBox.Text = ""
        Else
            StartDateTextBox.Text = Me.book.StartReadDate.ToString("yyyyMMdd")
        End If

        If Me.book.EndReadDate = #1/1/0001 12:00:00 AM# Then
            EndDateTextBox.Text = ""
        Else
            EndDateTextBox.Text = Me.book.EndReadDate.ToString("yyyyMMdd")
        End If

        RecodeDateLabel.Text = "登録日：" & Me.book.RecodeDate.ToString("yyyyMMdd")
        If Not Me.book.UpdateDate = #1/1/0001 12:00:00 AM# Then
            UpdateDateLabel.Text = "更新日：" & Me.book.UpdateDate.ToString("yyyyMMdd")
        Else
            UpdateDateLabel.Text = "更新日："
        End If

    End Sub

    ''' <summary>
    ''' 編集ボタンの動作
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click

        If mode = FormMode.Show Then
            ControlEditMode()
        ElseIf mode = FormMode.Edit Then
            ControlShowMode()
        End If

    End Sub

    ''' <summary>
    ''' 編集できるように各種コントロールをEnable = Trueにする
    ''' </summary>
    Private Sub ControlEditMode()
        TitleTextBox.Enabled = True
        AuthorTextBox.Enabled = True
        RegisterImageButton.Enabled = True
        GenreTextBox.Enabled = True
        ReviewLabel.Enabled = True
        ReviewTrackBar.Enabled = True
        MemoRichTextBox.Enabled = True
        BuyDateTextBox.Enabled = True
        StartDateTextBox.Enabled = True
        EndDateTextBox.Enabled = True
        SaveButton.Enabled = True
        SaveButton.Text = "更新"
        EditButton.Left = 635 - 60
        EditButton.Width = 70 + 60
        EditButton.Text = "キャンセル"
        mode = FormMode.Edit
    End Sub

    ''' <summary>
    ''' 編集できないように各種コントロールをEnable = Falseにする
    ''' </summary>
    Private Sub ControlShowMode()
        EditButton.Enabled = True
        TitleTextBox.Enabled = False
        AuthorTextBox.Enabled = False
        RegisterImageButton.Enabled = False
        GenreTextBox.Enabled = False
        ReviewLabel.Enabled = False
        ReviewTrackBar.Enabled = False
        MemoRichTextBox.Enabled = False
        BuyDateTextBox.Enabled = False
        StartDateTextBox.Enabled = False
        EndDateTextBox.Enabled = False
        SaveButton.Enabled = False
        EditButton.Left = 635
        EditButton.Width = 70
        EditButton.Text = "編集"
        mode = FormMode.Show
    End Sub

End Class
