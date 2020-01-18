Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        ComboBox1.Text = "請選擇要開啟的網頁："
        ComboBox1.Items.Add("文淵閣工作室")
        ComboBox1.Items.Add("Google首頁")
        ComboBox1.Items.Add("Yahoo首頁")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            System.Diagnostics.Process.Start("http://www.e-happy.com.tw")
        ElseIf ComboBox1.SelectedIndex = 1 Then
            System.Diagnostics.Process.Start("http://www.google.com.tw")
        Else
            System.Diagnostics.Process.Start("http://www.yahoo.com.tw")
        End If
    End Sub

End Class
