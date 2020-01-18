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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.btnFont = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(45, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(384, 22)
        Me.TextBox1.TabIndex = 22
        Me.TextBox1.Text = "ColorDialog  色彩對話方塊習作"
        '
        'btnColor
        '
        Me.btnColor.Location = New System.Drawing.Point(129, 85)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(65, 38)
        Me.btnColor.TabIndex = 23
        Me.btnColor.Text = "設定顏色"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'btnFont
        '
        Me.btnFont.Location = New System.Drawing.Point(45, 85)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Size = New System.Drawing.Size(65, 38)
        Me.btnFont.TabIndex = 21
        Me.btnFont.Text = "設定字型"
        Me.btnFont.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 158)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnColor)
        Me.Controls.Add(Me.btnFont)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents btnColor As System.Windows.Forms.Button
    Friend WithEvents btnFont As System.Windows.Forms.Button

End Class
