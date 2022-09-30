<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookList
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
        Me.components = New System.ComponentModel.Container()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.BookListView = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.削除ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
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
        'BookListView
        '
        Me.BookListView.ContextMenuStrip = Me.ContextMenuStrip1
        Me.BookListView.HideSelection = False
        Me.BookListView.Location = New System.Drawing.Point(13, 61)
        Me.BookListView.Name = "BookListView"
        Me.BookListView.Size = New System.Drawing.Size(1211, 851)
        Me.BookListView.TabIndex = 2
        Me.BookListView.UseCompatibleStateImageBehavior = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.削除ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 48)
        '
        '削除ToolStripMenuItem
        '
        Me.削除ToolStripMenuItem.Name = "削除ToolStripMenuItem"
        Me.削除ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.削除ToolStripMenuItem.Text = "削除"
        '
        'BookImageList
        '
        Me.BookImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.BookImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.BookImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'BookList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1236, 924)
        Me.Controls.Add(Me.BookListView)
        Me.Controls.Add(Me.RegisterButton)
        Me.Font = New System.Drawing.Font("游ゴシック", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = False
        Me.Name = "BookList"
        Me.Text = "BookList"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RegisterButton As Button
    Friend WithEvents BookListView As ListView
    Friend WithEvents BookImageList As ImageList
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 削除ToolStripMenuItem As ToolStripMenuItem
End Class
