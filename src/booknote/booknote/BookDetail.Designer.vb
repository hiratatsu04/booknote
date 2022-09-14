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
        Me.SaveButton = New System.Windows.Forms.Button()
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
        Me.BuyYearComboBox = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BuyMonthComboBox = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BuyDayComboBox = New System.Windows.Forms.ComboBox()
        Me.StartDayComboBox = New System.Windows.Forms.ComboBox()
        Me.StartMonthComboBox = New System.Windows.Forms.ComboBox()
        Me.StartYearComboBox = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.EndDayComboBox = New System.Windows.Forms.ComboBox()
        Me.EndMonthComboBox = New System.Windows.Forms.ComboBox()
        Me.EndYearComboBox = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        CType(Me.BookImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReviewTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReturnButton
        '
        Me.ReturnButton.Location = New System.Drawing.Point(11, 10)
        Me.ReturnButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(67, 39)
        Me.ReturnButton.TabIndex = 10
        Me.ReturnButton.TabStop = False
        Me.ReturnButton.Text = "戻る"
        Me.ReturnButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(713, 10)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(70, 39)
        Me.SaveButton.TabIndex = 10
        Me.SaveButton.TabStop = False
        Me.SaveButton.Text = "保存"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'BookImagePictureBox
        '
        Me.BookImagePictureBox.Location = New System.Drawing.Point(11, 68)
        Me.BookImagePictureBox.Margin = New System.Windows.Forms.Padding(4)
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
        Me.Label7.Location = New System.Drawing.Point(200, 427)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 27)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "読書終了日："
        '
        'MemoRichTextBox
        '
        Me.MemoRichTextBox.Location = New System.Drawing.Point(11, 493)
        Me.MemoRichTextBox.Margin = New System.Windows.Forms.Padding(4)
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
        Me.TitleTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(453, 41)
        Me.TitleTextBox.TabIndex = 0
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.Location = New System.Drawing.Point(330, 133)
        Me.AuthorTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(453, 41)
        Me.AuthorTextBox.TabIndex = 1
        '
        'GenreTextBox
        '
        Me.GenreTextBox.Location = New System.Drawing.Point(330, 194)
        Me.GenreTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GenreTextBox.Name = "GenreTextBox"
        Me.GenreTextBox.Size = New System.Drawing.Size(453, 41)
        Me.GenreTextBox.TabIndex = 2
        '
        'ReviewTrackBar
        '
        Me.ReviewTrackBar.Location = New System.Drawing.Point(399, 252)
        Me.ReviewTrackBar.Margin = New System.Windows.Forms.Padding(4)
        Me.ReviewTrackBar.Maximum = 50
        Me.ReviewTrackBar.Name = "ReviewTrackBar"
        Me.ReviewTrackBar.Size = New System.Drawing.Size(230, 45)
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
        'BuyYearComboBox
        '
        Me.BuyYearComboBox.FormattingEnabled = True
        Me.BuyYearComboBox.Location = New System.Drawing.Point(330, 326)
        Me.BuyYearComboBox.Name = "BuyYearComboBox"
        Me.BuyYearComboBox.Size = New System.Drawing.Size(87, 35)
        Me.BuyYearComboBox.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(414, 329)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 27)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "年"
        '
        'BuyMonthComboBox
        '
        Me.BuyMonthComboBox.FormattingEnabled = True
        Me.BuyMonthComboBox.Location = New System.Drawing.Point(454, 326)
        Me.BuyMonthComboBox.Name = "BuyMonthComboBox"
        Me.BuyMonthComboBox.Size = New System.Drawing.Size(47, 35)
        Me.BuyMonthComboBox.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(499, 329)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 27)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "月"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(584, 329)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 27)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "日"
        '
        'BuyDayComboBox
        '
        Me.BuyDayComboBox.FormattingEnabled = True
        Me.BuyDayComboBox.Location = New System.Drawing.Point(539, 326)
        Me.BuyDayComboBox.Name = "BuyDayComboBox"
        Me.BuyDayComboBox.Size = New System.Drawing.Size(47, 35)
        Me.BuyDayComboBox.TabIndex = 22
        '
        'StartDayComboBox
        '
        Me.StartDayComboBox.FormattingEnabled = True
        Me.StartDayComboBox.Location = New System.Drawing.Point(539, 375)
        Me.StartDayComboBox.Name = "StartDayComboBox"
        Me.StartDayComboBox.Size = New System.Drawing.Size(47, 35)
        Me.StartDayComboBox.TabIndex = 28
        '
        'StartMonthComboBox
        '
        Me.StartMonthComboBox.FormattingEnabled = True
        Me.StartMonthComboBox.Location = New System.Drawing.Point(454, 375)
        Me.StartMonthComboBox.Name = "StartMonthComboBox"
        Me.StartMonthComboBox.Size = New System.Drawing.Size(47, 35)
        Me.StartMonthComboBox.TabIndex = 26
        '
        'StartYearComboBox
        '
        Me.StartYearComboBox.FormattingEnabled = True
        Me.StartYearComboBox.Location = New System.Drawing.Point(330, 375)
        Me.StartYearComboBox.Name = "StartYearComboBox"
        Me.StartYearComboBox.Size = New System.Drawing.Size(87, 35)
        Me.StartYearComboBox.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(584, 378)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 27)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "日"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(499, 378)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 27)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "月"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(414, 378)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 27)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "年"
        '
        'EndDayComboBox
        '
        Me.EndDayComboBox.FormattingEnabled = True
        Me.EndDayComboBox.Location = New System.Drawing.Point(539, 424)
        Me.EndDayComboBox.Name = "EndDayComboBox"
        Me.EndDayComboBox.Size = New System.Drawing.Size(47, 35)
        Me.EndDayComboBox.TabIndex = 34
        '
        'EndMonthComboBox
        '
        Me.EndMonthComboBox.FormattingEnabled = True
        Me.EndMonthComboBox.Location = New System.Drawing.Point(454, 424)
        Me.EndMonthComboBox.Name = "EndMonthComboBox"
        Me.EndMonthComboBox.Size = New System.Drawing.Size(47, 35)
        Me.EndMonthComboBox.TabIndex = 32
        '
        'EndYearComboBox
        '
        Me.EndYearComboBox.FormattingEnabled = True
        Me.EndYearComboBox.Location = New System.Drawing.Point(330, 424)
        Me.EndYearComboBox.Name = "EndYearComboBox"
        Me.EndYearComboBox.Size = New System.Drawing.Size(87, 35)
        Me.EndYearComboBox.TabIndex = 30
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(584, 427)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 27)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "日"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(499, 427)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 27)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "月"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(414, 427)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 27)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "年"
        '
        'BookDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 841)
        Me.Controls.Add(Me.EndDayComboBox)
        Me.Controls.Add(Me.EndMonthComboBox)
        Me.Controls.Add(Me.EndYearComboBox)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.StartDayComboBox)
        Me.Controls.Add(Me.StartMonthComboBox)
        Me.Controls.Add(Me.StartYearComboBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.BuyDayComboBox)
        Me.Controls.Add(Me.BuyMonthComboBox)
        Me.Controls.Add(Me.BuyYearComboBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
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
        Me.Controls.Add(Me.SaveButton)
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
    Friend WithEvents SaveButton As Button
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
    Friend WithEvents BuyYearComboBox As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BuyMonthComboBox As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BuyDayComboBox As ComboBox
    Friend WithEvents StartDayComboBox As ComboBox
    Friend WithEvents StartMonthComboBox As ComboBox
    Friend WithEvents StartYearComboBox As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents EndDayComboBox As ComboBox
    Friend WithEvents EndMonthComboBox As ComboBox
    Friend WithEvents EndYearComboBox As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
End Class
