Option Strict On

Public Class BookDetail

    Private manageDB As ManageDB
    Private book As Book

    ' idを指定して本の情報を開く場合の設定
    Public Overloads Sub Show(ByVal owner As IWin32Window,
                            ByVal book As Book)
        Me.book = book
        MyBase.Show(owner)
        ShowBookData()

        ControlShowMode()

    End Sub

    ' TrackBarがInteger型しか受け付けないので、10で割っている
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles ReviewTrackBar.Scroll

        ReviewLabel.Text = (ReviewTrackBar.Value / 10).ToString("0.0")

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        Dim id As Integer = Nothing

        If book IsNot Nothing Then
            id = book.ID
        End If

        manageDB = New ManageDB()
        book = New Book()

        book.Title = TitleTextBox.Text
        book.Author = AuthorTextBox.Text
        book.BookImage = BookImagePictureBox.Image
        book.Genre = GenreTextBox.Text
        book.ReviewValue = ReviewTrackBar.Value
        book.Memo = MemoRichTextBox.Text
        book.BuyDate = ConvertStringToDate(BuyDateTextBox.Text)
        book.StartReadDate = ConvertStringToDate(StartDateTextBox.Text)
        book.EndReadDate = ConvertStringToDate(EndDateTextBox.Text)

        If id <> Nothing Then
            book.ID = id
            manageDB.UpdateBookData(book)
        Else
            manageDB.RecodeBook(book)
        End If

        ControlShowMode()

    End Sub

    Private Sub RegisterImageButton_Click(sender As Object, e As EventArgs) Handles RegisterImageButton.Click

        'OpenFileDialogクラスのインスタンスを作成
        Dim ofd As New OpenFileDialog()

        'ダイアログを表示する
        If ofd.ShowDialog() = DialogResult.OK Then
            Dim bookImage As System.Drawing.Image = System.Drawing.Image.FromFile(ofd.FileName)

            If bookImage.Size.Height > (bookImage.Size.Width * (4 / 3)) Then
                BookImagePictureBox.Width = CType(BookImagePictureBox.Height * (bookImage.Size.Height / bookImage.Size.Width), Integer)
            Else
                BookImagePictureBox.Height = CType(BookImagePictureBox.Width * (bookImage.Size.Height / bookImage.Size.Width), Integer)
            End If

            BookImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage
            BookImagePictureBox.Image = bookImage
        End If

    End Sub

    Private Function ConvertStringToDate(str As String) As Date

        Dim convertedDate As Date = Nothing

        If Not DateTime.TryParseExact(str, "yyyyMMdd", System.Globalization.DateTimeFormatInfo.InvariantInfo, System.Globalization.DateTimeStyles.None, convertedDate) Then

            MessageBox.Show($"{str}の値をDate型に変換できません。")

        End If

        Return convertedDate

    End Function

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click

        Me.Close()

    End Sub

    ''' <summary>
    ''' 設定されているidのデータを各種コントロールに設定する
    ''' </summary>
    Private Sub ShowBookData()

        TitleTextBox.Text = book.Title
        AuthorTextBox.Text = book.Author
        BookImagePictureBox.Image = book.BookImage
        GenreTextBox.Text = book.Genre
        ReviewLabel.Text = (book.ReviewValue / 10).ToString()
        ReviewTrackBar.Value = CType(book.ReviewValue, Integer)
        MemoRichTextBox.Text = book.Memo
        BuyDateTextBox.Text = book.BuyDate.ToString("yyyyMMdd")
        StartDateTextBox.Text = book.StartReadDate.ToString("yyyyMMdd")
        EndDateTextBox.Text = book.EndReadDate.ToString("yyyyMMdd")

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click

        ControlEditMode()

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
        EditButton.Enabled = False
        SaveButton.Text = "更新"
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
    End Sub

End Class
