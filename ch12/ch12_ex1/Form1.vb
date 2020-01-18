Public Class Form1

    Dim ch As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNum1.Text = ""
        txtNum2.Text = ""
        lblResult.Text = ""
    End Sub

    Private Sub txtNum1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNum1.KeyPress
        ch = e.KeyChar.ToString()
        Dim AscCode As Integer = Convert.ToInt32(e.KeyChar)
        If (ch = "-" Or ch = "+" Or ch = "." Or AscCode = Keys.Back) Then '接受 "-", "+", ".",BackSpace 輸入
            e.Handled = False
        ElseIf (AscCode >= 48 And AscCode <= 57) Then   ' 接受 0~9 數字字元
            e.Handled = False
        Else  ' 其他字元不允許輸入
            e.Handled = True
        End If
    End Sub

    Private Sub txtNum2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNum2.KeyPress
        ch = e.KeyChar.ToString()
        Dim AscCode As Integer = Convert.ToInt32(e.KeyChar)
        If (ch = "-" Or ch = "+" Or ch = "." Or AscCode = Keys.Back) Then '接受 "-", "+", ".",BackSpace 輸入
            e.Handled = False
        ElseIf (AscCode >= 48 And AscCode <= 57) Then   ' 接受 0~9 數字字元
            e.Handled = False
        Else  ' 其他字元不允許輸入
            e.Handled = True
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim r As Double = Convert.ToDouble(txtNum1.Text) + Convert.ToDouble(txtNum2.Text)
        lblResult.Text = "相加結果：" & r.ToString()
    End Sub

End Class
