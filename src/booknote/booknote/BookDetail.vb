Option Strict On

Public Class BookDetail

    Private manageDB As ManageDB
    Private book As Book
    Private id As Integer

    Public Overloads Sub Show(ByVal owner As IWin32Window,
                            ByVal id As Integer)
        Me.id = id
        MyBase.Show(owner)
        ShowBookData()

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

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles ReviewTrackBar.Scroll

        ReviewLabel.Text = (ReviewTrackBar.Value / 10).ToString("0.0")

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

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

        manageDB.RecodeBook(book)

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

    Private Sub ShowBookData()
        manageDB = New ManageDB()
        Dim book As Book = manageDB.GetOneBookData(id)

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

        id = book.ID
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
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
    End Sub
End Class
