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
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.標楷體ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.細明體ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.顏色CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.紅色RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.黑色BToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.綠色GToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblShow = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.標楷體ToolStripMenuItem, Me.細明體ToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(45, 22)
        Me.ToolStripDropDownButton1.Text = "字型"
        '
        '標楷體ToolStripMenuItem
        '
        Me.標楷體ToolStripMenuItem.Name = "標楷體ToolStripMenuItem"
        Me.標楷體ToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.標楷體ToolStripMenuItem.Text = "標楷體"
        '
        '細明體ToolStripMenuItem
        '
        Me.細明體ToolStripMenuItem.Name = "細明體ToolStripMenuItem"
        Me.細明體ToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.細明體ToolStripMenuItem.Text = "細明體"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"12", "24", "32"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(80, 25)
        Me.ToolStripComboBox1.Text = "文字大小"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.顏色CToolStripMenuItem, Me.ToolStripComboBox1, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(441, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        '顏色CToolStripMenuItem
        '
        Me.顏色CToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.紅色RToolStripMenuItem, Me.黑色BToolStripMenuItem, Me.綠色GToolStripMenuItem})
        Me.顏色CToolStripMenuItem.Name = "顏色CToolStripMenuItem"
        Me.顏色CToolStripMenuItem.Size = New System.Drawing.Size(63, 25)
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
        '黑色BToolStripMenuItem
        '
        Me.黑色BToolStripMenuItem.Image = CType(resources.GetObject("黑色BToolStripMenuItem.Image"), System.Drawing.Image)
        Me.黑色BToolStripMenuItem.Name = "黑色BToolStripMenuItem"
        Me.黑色BToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.黑色BToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.黑色BToolStripMenuItem.Text = "黑色 (&B)"
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
        Me.lblShow.Location = New System.Drawing.Point(12, 78)
        Me.lblShow.Name = "lblShow"
        Me.lblShow.Size = New System.Drawing.Size(43, 12)
        Me.lblShow.TabIndex = 3
        Me.lblShow.Text = "lblShow"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(441, 157)
        Me.Controls.Add(Me.lblShow)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents 標楷體ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 細明體ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents 顏色CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents 紅色RToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents 黑色BToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents 綠色GToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblShow As System.Windows.Forms.Label

End Class
