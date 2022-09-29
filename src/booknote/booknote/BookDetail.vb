Option Strict On

Public Class BookDetail

    Dim manageDB As ManageDB
    Dim book As Book

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles ReviewTrackBar.Scroll

        ReviewLabel.Text = (ReviewTrackBar.Value / 10).ToString("0.0")

    End Sub

<<<<<<< HEAD
    Private Sub BookDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

=======
>>>>>>> 0cb0d37996d561943806b656063c0cc7c294834e
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        manageDB = New ManageDB()
        book = New Book()

        book.Title = TitleTextBox.Text
        book.Author = AuthorTextBox.Text
        book.BookImage = BookImagePictureBox.Image
        book.Genre = GenreTextBox.Text
        book.ReviewValue = ReviewTrackBar.Value
        book.Memo = MemoRichTextBox.Text
        book.BuyDate = buy
        book.StartReadDate
        book.EndReadDate
        book.RecodeDate
        book.UpdateDate


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

    Private Sub BuyDateTextBox_Leave(sender As Object, e As EventArgs) Handles BuyDateTextBox.Leave

        Dim buyDate As Date

        'Dim buyDateString As String = BuyDateTextBox.Text.Insert(6, "/"c).Insert(4, "/"c)
        'If Not DateTime.TryParse(buyDateString, buyDate) Then
        '    MessageBox.Show($"{BuyDateTextBox.Text}の値をDate型に変換できません。")
        '    BuyDateTextBox.Text = String.Empty
        '    BuyDateTextBox.Focus()
        'End If

        If Not DateTime.TryParseExact(BuyDateTextBox.Text, "yyyyMMdd", System.Globalization.DateTimeFormatInfo.InvariantInfo, System.Globalization.DateTimeStyles.None, buyDate) Then

            MessageBox.Show($"{BuyDateTextBox.Text}の値をDate型に変換できません。")
            BuyDateTextBox.Text = String.Empty

        End If

    End Sub
End Class
