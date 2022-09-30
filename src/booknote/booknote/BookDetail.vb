Option Strict On

Public Class BookDetail

    Private manageDB As ManageDB
    Private book As Book

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    Sub New()
        InitializeComponent()
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

        ' bookの値の有無で「更新」か「新規保存」か場合分けてしている
        If Me.book Is Nothing Then
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

        ' 入力必須項目（title、author、buydate）の値有無チェック
        ' 値が入っていなければ登録・更新しない
        If Me.book.Title = "" OrElse Me.book.Author = "" OrElse Me.book.BuyDate = #1/1/0001 12:00:00 AM# Then
            MessageBox.Show("タイトル、著者、購入日は入力が必須です。")
            Return
        End If

        manageDB = New ManageDB()

        ' book.IDの値の有無で「更新」か「新規保存」か場合分けてしている
        If Me.book.ID Is Nothing Then
            manageDB.RecodeBook(Me.book)
        Else
            manageDB.UpdateBookData(Me.book)
        End If

        ControlShowMode()

        ' 一覧表示フォームにOKを渡す
        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

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

            If bookImage.Size.Height > (bookImage.Size.Width * (4 / 3)) Then
                BookImagePictureBox.Width = CType(BookImagePictureBox.Height * (bookImage.Size.Height / bookImage.Size.Width), Integer)
            Else
                BookImagePictureBox.Height = CType(BookImagePictureBox.Width * (bookImage.Size.Height / bookImage.Size.Width), Integer)
            End If

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
    ''' 戻るボタンの動作
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click

        ' 一覧表示フォームにOKを渡す
        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

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
        StartDateTextBox.Text = Me.book.StartReadDate.ToString("yyyyMMdd")
        EndDateTextBox.Text = Me.book.EndReadDate.ToString("yyyyMMdd")
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
