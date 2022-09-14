<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookDetail
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.BookImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MemoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.GenreTextBox = New System.Windows.Forms.TextBox()
        Me.ReviewTrackBar = New System.Windows.Forms.TrackBar()
        Me.ReviewLabel = New System.Windows.Forms.Label()
        Me.BuyDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StartDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EndDateTimePicker = New System.Windows.Forms.DateTimePicker()
        CType(Me.BookImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReviewTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReturnButton
        '
        Me.ReturnButton.Location = New System.Drawing.Point(11, 10)
        Me.ReturnButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(67, 39)
        Me.ReturnButton.TabIndex = 10
        Me.ReturnButton.TabStop = False
        Me.ReturnButton.Text = "戻る"
        Me.ReturnButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(713, 10)
        Me.EditButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(70, 39)
        Me.EditButton.TabIndex = 10
        Me.EditButton.TabStop = False
        Me.EditButton.Text = "編集"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'BookImagePictureBox
        '
        Me.BookImagePictureBox.Location = New System.Drawing.Point(11, 68)
        Me.BookImagePictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BookImagePictureBox.Name = "BookImagePictureBox"
        Me.BookImagePictureBox.Size = New System.Drawing.Size(202, 238)
        Me.BookImagePictureBox.TabIndex = 2
        Me.BookImagePictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(222, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "タイトル："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(263, 136)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 27)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "著者："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(221, 197)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 27)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ジャンル："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(263, 255)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 27)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "評価：☆"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(242, 329)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 27)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "購入日："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(200, 378)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 27)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "読書開始日："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(263, 427)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 27)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "読了："
        '
        'MemoRichTextBox
        '
        Me.MemoRichTextBox.Location = New System.Drawing.Point(11, 493)
        Me.MemoRichTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MemoRichTextBox.Name = "MemoRichTextBox"
        Me.MemoRichTextBox.Size = New System.Drawing.Size(772, 335)
        Me.MemoRichTextBox.TabIndex = 7
        Me.MemoRichTextBox.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 462)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 27)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "感想"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Location = New System.Drawing.Point(330, 68)
        Me.TitleTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(453, 41)
        Me.TitleTextBox.TabIndex = 0
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.Location = New System.Drawing.Point(330, 133)
        Me.AuthorTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(453, 41)
        Me.AuthorTextBox.TabIndex = 1
        '
        'GenreTextBox
        '
        Me.GenreTextBox.Location = New System.Drawing.Point(330, 194)
        Me.GenreTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GenreTextBox.Name = "GenreTextBox"
        Me.GenreTextBox.Size = New System.Drawing.Size(453, 41)
        Me.GenreTextBox.TabIndex = 2
        '
        'ReviewTrackBar
        '
        Me.ReviewTrackBar.Location = New System.Drawing.Point(399, 252)
        Me.ReviewTrackBar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReviewTrackBar.Maximum = 50
        Me.ReviewTrackBar.Name = "ReviewTrackBar"
        Me.ReviewTrackBar.Size = New System.Drawing.Size(230, 30)
        Me.ReviewTrackBar.TabIndex = 3
        Me.ReviewTrackBar.TickFrequency = 10
        '
        'ReviewLabel
        '
        Me.ReviewLabel.AutoSize = True
        Me.ReviewLabel.Location = New System.Drawing.Point(350, 255)
        Me.ReviewLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ReviewLabel.Name = "ReviewLabel"
        Me.ReviewLabel.Size = New System.Drawing.Size(41, 27)
        Me.ReviewLabel.TabIndex = 16
        Me.ReviewLabel.Text = "0.0"
        '
        'BuyDateTimePicker
        '
        Me.BuyDateTimePicker.Location = New System.Drawing.Point(330, 320)
        Me.BuyDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BuyDateTimePicker.Name = "BuyDateTimePicker"
        Me.BuyDateTimePicker.Size = New System.Drawing.Size(211, 41)
        Me.BuyDateTimePicker.TabIndex = 4
        '
        'StartDateTimePicker
        '
        Me.StartDateTimePicker.Location = New System.Drawing.Point(330, 369)
        Me.StartDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.StartDateTimePicker.Name = "StartDateTimePicker"
        Me.StartDateTimePicker.Size = New System.Drawing.Size(211, 41)
        Me.StartDateTimePicker.TabIndex = 5
        '
        'EndDateTimePicker
        '
        Me.EndDateTimePicker.Location = New System.Drawing.Point(330, 418)
        Me.EndDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.EndDateTimePicker.Name = "EndDateTimePicker"
        Me.EndDateTimePicker.Size = New System.Drawing.Size(211, 41)
        Me.EndDateTimePicker.TabIndex = 6
        '
        'BookDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 841)
        Me.Controls.Add(Me.EndDateTimePicker)
        Me.Controls.Add(Me.StartDateTimePicker)
        Me.Controls.Add(Me.BuyDateTimePicker)
        Me.Controls.Add(Me.ReviewLabel)
        Me.Controls.Add(Me.ReviewTrackBar)
        Me.Controls.Add(Me.GenreTextBox)
        Me.Controls.Add(Me.AuthorTextBox)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.MemoRichTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BookImagePictureBox)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.ReturnButton)
        Me.Font = New System.Drawing.Font("游ゴシック", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "BookDetail"
        Me.Text = "BookDetail"
        CType(Me.BookImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReviewTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReturnButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents BookImagePictureBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents MemoRichTextBox As RichTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents AuthorTextBox As TextBox
    Friend WithEvents GenreTextBox As TextBox
    Friend WithEvents ReviewTrackBar As TrackBar
    Friend WithEvents ReviewLabel As Label
    Friend WithEvents BuyDateTimePicker As DateTimePicker
    Friend WithEvents StartDateTimePicker As DateTimePicker
    Friend WithEvents EndDateTimePicker As DateTimePicker
End Class
