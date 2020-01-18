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
        Me.button1 = New System.Windows.Forms.Button()
        Me.chkBold = New System.Windows.Forms.CheckBox()
        Me.chkBot = New System.Windows.Forms.CheckBox()
        Me.chkDel = New System.Windows.Forms.CheckBox()
        Me.chkInline = New System.Windows.Forms.CheckBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(101, 161)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 20
        Me.button1.Text = "恢復預設值"
        Me.button1.UseVisualStyleBackColor = True
        '
        'chkBold
        '
        Me.chkBold.AutoSize = True
        Me.chkBold.Location = New System.Drawing.Point(85, 130)
        Me.chkBold.Name = "chkBold"
        Me.chkBold.Size = New System.Drawing.Size(48, 16)
        Me.chkBold.TabIndex = 18
        Me.chkBold.Text = "粗體"
        Me.chkBold.UseVisualStyleBackColor = True
        '
        'chkBot
        '
        Me.chkBot.AutoSize = True
        Me.chkBot.Location = New System.Drawing.Point(231, 130)
        Me.chkBot.Name = "chkBot"
        Me.chkBot.Size = New System.Drawing.Size(48, 16)
        Me.chkBot.TabIndex = 19
        Me.chkBot.Text = "底線"
        Me.chkBot.UseVisualStyleBackColor = True
        '
        'chkDel
        '
        Me.chkDel.AutoSize = True
        Me.chkDel.Location = New System.Drawing.Point(151, 130)
        Me.chkDel.Name = "chkDel"
        Me.chkDel.Size = New System.Drawing.Size(60, 16)
        Me.chkDel.TabIndex = 16
        Me.chkDel.Text = "刪除線"
        Me.chkDel.UseVisualStyleBackColor = True
        '
        'chkInline
        '
        Me.chkInline.AutoSize = True
        Me.chkInline.Location = New System.Drawing.Point(19, 130)
        Me.chkInline.Name = "chkInline"
        Me.chkInline.Size = New System.Drawing.Size(48, 16)
        Me.chkInline.TabIndex = 17
        Me.chkInline.Text = "斜體"
        Me.chkInline.UseVisualStyleBackColor = True
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.textBox1.Location = New System.Drawing.Point(12, 15)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textBox1.Size = New System.Drawing.Size(284, 94)
        Me.textBox1.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 199)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.chkBold)
        Me.Controls.Add(Me.chkBot)
        Me.Controls.Add(Me.chkDel)
        Me.Controls.Add(Me.chkInline)
        Me.Controls.Add(Me.textBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents chkBold As System.Windows.Forms.CheckBox
    Friend WithEvents chkBot As System.Windows.Forms.CheckBox
    Friend WithEvents chkDel As System.Windows.Forms.CheckBox
    Friend WithEvents chkInline As System.Windows.Forms.CheckBox
    Friend WithEvents textBox1 As System.Windows.Forms.TextBox

End Class
