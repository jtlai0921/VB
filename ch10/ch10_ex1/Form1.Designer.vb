<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.黑色BToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.標楷體ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.細明體ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.顏色CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.紅色RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.綠色GToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblShow = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        '黑色BToolStripMenuItem
        '
        Me.黑色BToolStripMenuItem.Image = CType(resources.GetObject("黑色BToolStripMenuItem.Image"), System.Drawing.Image)
        Me.黑色BToolStripMenuItem.Name = "黑色BToolStripMenuItem"
        Me.黑色BToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.黑色BToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.黑色BToolStripMenuItem.Text = "黑色 (&B)"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.顏色CToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(388, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.標楷體ToolStripMenuItem, Me.細明體ToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(61, 20)
        Me.ToolStripMenuItem1.Text = "字型 (&F)"
        '
        '標楷體ToolStripMenuItem
        '
        Me.標楷體ToolStripMenuItem.Name = "標楷體ToolStripMenuItem"
        Me.標楷體ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.標楷體ToolStripMenuItem.Text = "標楷體"
        '
        '細明體ToolStripMenuItem
        '
        Me.細明體ToolStripMenuItem.Name = "細明體ToolStripMenuItem"
        Me.細明體ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.細明體ToolStripMenuItem.Text = "細明體"
        '
        '顏色CToolStripMenuItem
        '
        Me.顏色CToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.紅色RToolStripMenuItem, Me.黑色BToolStripMenuItem, Me.綠色GToolStripMenuItem})
        Me.顏色CToolStripMenuItem.Name = "顏色CToolStripMenuItem"
        Me.顏色CToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.顏色CToolStripMenuItem.Text = "顏色 (&C)"
        '
        '紅色RToolStripMenuItem
        '
        Me.紅色RToolStripMenuItem.Image = CType(resources.GetObject("紅色RToolStripMenuItem.Image"), System.Drawing.Image)
        Me.紅色RToolStripMenuItem.Name = "紅色RToolStripMenuItem"
        Me.紅色RToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.紅色RToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.紅色RToolStripMenuItem.Text = "紅色 (&R)"
        '
        '綠色GToolStripMenuItem
        '
        Me.綠色GToolStripMenuItem.Image = CType(resources.GetObject("綠色GToolStripMenuItem.Image"), System.Drawing.Image)
        Me.綠色GToolStripMenuItem.Name = "綠色GToolStripMenuItem"
        Me.綠色GToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.綠色GToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.綠色GToolStripMenuItem.Text = "綠色 (&G)"
        '
        'lblShow
        '
        Me.lblShow.AutoSize = True
        Me.lblShow.Location = New System.Drawing.Point(12, 75)
        Me.lblShow.Name = "lblShow"
        Me.lblShow.Size = New System.Drawing.Size(37, 12)
        Me.lblShow.TabIndex = 3
        Me.lblShow.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(388, 156)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblShow)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents 黑色BToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 標楷體ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 細明體ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 顏色CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 紅色RToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 綠色GToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblShow As System.Windows.Forms.Label

End Class
