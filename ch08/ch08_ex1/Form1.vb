Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "第八章習題一"
        Label1.Font = New Font("新細明體", 16, FontStyle.Regular)
        Label1.Location = New Point(10, 10)
        Label1.ForeColor = Color.Black
    End Sub

    Private Sub label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Label1.Font = New Font("標楷體", 24, FontStyle.Bold)
        Label1.Location = New Point(50, 50)
        Label1.ForeColor = Color.Red
    End Sub
End Class
