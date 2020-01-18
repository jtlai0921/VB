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
        Me.label1 = New System.Windows.Forms.Label()
        Me.linkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.linkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.label1.Location = New System.Drawing.Point(26, 22)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(93, 16)
        Me.label1.TabIndex = 14
        Me.label1.Text = "好站連結："
        '
        'linkLabel3
        '
        Me.linkLabel3.AutoSize = True
        Me.linkLabel3.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.linkLabel3.Location = New System.Drawing.Point(27, 119)
        Me.linkLabel3.Name = "linkLabel3"
        Me.linkLabel3.Size = New System.Drawing.Size(75, 16)
        Me.linkLabel3.TabIndex = 13
        Me.linkLabel3.TabStop = True
        Me.linkLabel3.Text = "linkLabel3"
        '
        'linkLabel2
        '
        Me.linkLabel2.AutoSize = True
        Me.linkLabel2.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.linkLabel2.Location = New System.Drawing.Point(27, 84)
        Me.linkLabel2.Name = "linkLabel2"
        Me.linkLabel2.Size = New System.Drawing.Size(75, 16)
        Me.linkLabel2.TabIndex = 11
        Me.linkLabel2.TabStop = True
        Me.linkLabel2.Text = "linkLabel2"
        '
        'linkLabel1
        '
        Me.linkLabel1.AutoSize = True
        Me.linkLabel1.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.linkLabel1.Location = New System.Drawing.Point(27, 52)
        Me.linkLabel1.Name = "linkLabel1"
        Me.linkLabel1.Size = New System.Drawing.Size(75, 16)
        Me.linkLabel1.TabIndex = 12
        Me.linkLabel1.TabStop = True
        Me.linkLabel1.Text = "linkLabel1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 262)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.linkLabel3)
        Me.Controls.Add(Me.linkLabel2)
        Me.Controls.Add(Me.linkLabel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents linkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents linkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents linkLabel1 As System.Windows.Forms.LinkLabel

End Class
