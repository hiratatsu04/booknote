<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookList
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
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.BookListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'RegisterButton
        '
        Me.RegisterButton.Location = New System.Drawing.Point(13, 15)
        Me.RegisterButton.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(73, 37)
        Me.RegisterButton.TabIndex = 0
        Me.RegisterButton.Text = "登録"
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'BookListBox
        '
        Me.BookListBox.FormattingEnabled = True
        Me.BookListBox.ItemHeight = 27
        Me.BookListBox.Location = New System.Drawing.Point(13, 70)
        Me.BookListBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BookListBox.Name = "BookListBox"
        Me.BookListBox.Size = New System.Drawing.Size(1210, 841)
        Me.BookListBox.TabIndex = 1
        '
        'BookList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1236, 924)
        Me.Controls.Add(Me.BookListBox)
        Me.Controls.Add(Me.RegisterButton)
        Me.Font = New System.Drawing.Font("游ゴシック", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "BookList"
        Me.Text = "BookList"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RegisterButton As Button
    Friend WithEvents BookListBox As ListBox
End Class
