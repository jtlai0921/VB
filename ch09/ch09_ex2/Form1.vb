Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        textBox1.Text = "第九章習題二"
    End Sub

    Private Sub chkInline_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInline.CheckedChanged
        textBox1.Font = New Font("新細明體", 14, FontStyle.Italic Xor textBox1.Font.Style)
    End Sub

    Private Sub chkBold_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBold.CheckedChanged
        textBox1.Font = New Font("新細明體", 14, FontStyle.Bold Xor textBox1.Font.Style)
    End Sub

    Private Sub chkDel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDel.CheckedChanged
        textBox1.Font = New Font("新細明體", 14, FontStyle.Strikeout Xor textBox1.Font.Style)
    End Sub

    Private Sub chkBot_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBot.CheckedChanged
        textBox1.Font = New Font("新細明體", 14, FontStyle.Underline Xor textBox1.Font.Style)
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        chkInline.Checked = False
        chkBold.Checked = False
        chkBot.Checked = False
        chkDel.Checked = False
        textBox1.Font = New Font("新細明體", 14, FontStyle.Regular)
    End Sub
End Class
