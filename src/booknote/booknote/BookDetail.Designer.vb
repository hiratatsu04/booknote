<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookDetail
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.GenreTextBox = New System.Windows.Forms.TextBox()
        Me.ReviewTrackBar = New System.Windows.Forms.TrackBar()
        Me.ReviewLabel = New System.Windows.Forms.Label()
        Me.RegisterImageButton = New System.Windows.Forms.Button()
        Me.BookImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.BuyDateTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.StartDateTextBox = New System.Windows.Forms.TextBox()
        Me.EndDateTextBox = New System.Windows.Forms.TextBox()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.RecodeDateLabel = New System.Windows.Forms.Label()
        Me.MemoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.UpdateDateLabel = New System.Windows.Forms.Label()
        CType(Me.ReviewTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'RegisterImageButton
        '
        Me.RegisterImageButton.Font = New System.Drawing.Font("游ゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RegisterImageButton.Location = New System.Drawing.Point(11, 318)
        Me.RegisterImageButton.Margin = New System.Windows.Forms.Padding(4)
        Me.RegisterImageButton.Name = "RegisterImageButton"
        Me.RegisterImageButton.Size = New System.Drawing.Size(108, 29)
        Me.RegisterImageButton.TabIndex = 36
        Me.RegisterImageButton.TabStop = False
        Me.RegisterImageButton.Text = "画像の登録"
        Me.RegisterImageButton.UseVisualStyleBackColor = True
        '
        'BookImagePictureBox
        '
        Me.BookImagePictureBox.Location = New System.Drawing.Point(11, 68)
        Me.BookImagePictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.BookImagePictureBox.Name = "BookImagePictureBox"
        Me.BookImagePictureBox.Size = New System.Drawing.Size(181, 242)
        Me.BookImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BookImagePictureBox.TabIndex = 2
        Me.BookImagePictureBox.TabStop = False
        '
        'BuyDateTextBox
        '
        Me.BuyDateTextBox.Location = New System.Drawing.Point(330, 326)
        Me.BuyDateTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.BuyDateTextBox.Name = "BuyDateTextBox"
        Me.BuyDateTextBox.Size = New System.Drawing.Size(182, 41)
        Me.BuyDateTextBox.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(520, 329)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 27)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "入力例：20220914"
        '
        'StartDateTextBox
        '
        Me.StartDateTextBox.Location = New System.Drawing.Point(330, 375)
        Me.StartDateTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.StartDateTextBox.Name = "StartDateTextBox"
        Me.StartDateTextBox.Size = New System.Drawing.Size(182, 41)
        Me.StartDateTextBox.TabIndex = 5
        '
        'EndDateTextBox
        '
        Me.EndDateTextBox.Location = New System.Drawing.Point(330, 424)
        Me.EndDateTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EndDateTextBox.Name = "EndDateTextBox"
        Me.EndDateTextBox.Size = New System.Drawing.Size(182, 41)
        Me.EndDateTextBox.TabIndex = 6
        '
        'EditButton
        '
        Me.EditButton.Enabled = False
        Me.EditButton.Location = New System.Drawing.Point(635, 10)
        Me.EditButton.Margin = New System.Windows.Forms.Padding(4)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(70, 39)
        Me.EditButton.TabIndex = 43
        Me.EditButton.TabStop = False
        Me.EditButton.Text = "編集"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'RecodeDateLabel
        '
        Me.RecodeDateLabel.AutoSize = True
        Me.RecodeDateLabel.Location = New System.Drawing.Point(13, 16)
        Me.RecodeDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RecodeDateLabel.Name = "RecodeDateLabel"
        Me.RecodeDateLabel.Size = New System.Drawing.Size(0, 27)
        Me.RecodeDateLabel.TabIndex = 44
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
        'UpdateDateLabel
        '
        Me.UpdateDateLabel.AutoSize = True
        Me.UpdateDateLabel.Location = New System.Drawing.Point(210, 16)
        Me.UpdateDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UpdateDateLabel.Name = "UpdateDateLabel"
        Me.UpdateDateLabel.Size = New System.Drawing.Size(0, 27)
        Me.UpdateDateLabel.TabIndex = 45
        '
        'BookDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 841)
        Me.Controls.Add(Me.UpdateDateLabel)
        Me.Controls.Add(Me.RecodeDateLabel)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.EndDateTextBox)
        Me.Controls.Add(Me.StartDateTextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BuyDateTextBox)
        Me.Controls.Add(Me.RegisterImageButton)
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
        Me.Font = New System.Drawing.Font("游ゴシック", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = False
        Me.Name = "BookDetail"
        Me.Text = "BookDetail"
        CType(Me.ReviewTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveButton As Button
    Friend WithEvents BookImagePictureBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents AuthorTextBox As TextBox
    Friend WithEvents GenreTextBox As TextBox
    Friend WithEvents ReviewTrackBar As TrackBar
    Friend WithEvents ReviewLabel As Label
    Friend WithEvents RegisterImageButton As Button
    Friend WithEvents BuyDateTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents StartDateTextBox As TextBox
    Friend WithEvents EndDateTextBox As TextBox
    Friend WithEvents EditButton As Button
    Friend WithEvents RecodeDateLabel As Label
    Friend WithEvents MemoRichTextBox As RichTextBox
    Friend WithEvents UpdateDateLabel As Label
End Class
