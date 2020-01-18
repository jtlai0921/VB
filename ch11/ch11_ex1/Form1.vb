Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = "FontDialog 設定字型對話方塊習作"
        TextBox1.AutoSize = True
    End Sub

    Private Sub btnFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFont.Click
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            TextBox1.Font = FontDialog1.Font '設定文字的字型、大小、和樣式
        End If
    End Sub

    Private Sub btnColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColor.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            TextBox1.ForeColor = ColorDialog1.Color '設定文字的顏色
        End If
    End Sub
End Class
