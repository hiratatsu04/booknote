Option Strict On

Public Class BookDetail

    Dim manageDB As ManageDB
    Dim book As Book

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        manageDB = New ManageDB()
        Dim book As Book = manageDB.GetOneBookData(3)

        TitleTextBox.Text = book.Title
        AuthorTextBox.Text = book.Author
        BookImagePictureBox.Image = book.BookImage
        GenreTextBox.Text = book.Genre
        ReviewLabel.Text = (book.ReviewValue / 10).ToString()
        ReviewTrackBar.Value = CType(book.ReviewValue, Integer)
        MemoRichTextBox.Text = book.Memo
        BuyDateTextBox.Text = book.BuyDate.ToString()
        StartDateTextBox.Text = book.StartReadDate.ToString()
        EndDateTextBox.Text = book.EndReadDate.ToString()

    End Sub
End Class
