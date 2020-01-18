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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.taco = New System.Windows.Forms.PictureBox()
        CType(Me.taco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 12)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "請按 ↑、↓、←、→ 鍵，移動小章魚"
        '
        'taco
        '
        Me.taco.Image = CType(resources.GetObject("taco.Image"), System.Drawing.Image)
        Me.taco.Location = New System.Drawing.Point(132, 13)
        Me.taco.Name = "taco"
        Me.taco.Size = New System.Drawing.Size(89, 90)
        Me.taco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.taco.TabIndex = 12
        Me.taco.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(373, 150)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.taco)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.taco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents taco As System.Windows.Forms.PictureBox

End Class
