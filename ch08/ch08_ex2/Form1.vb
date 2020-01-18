Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LinkLabel1.Text = "按這裡連結文淵閣工作室"
        LinkLabel1.LinkArea = New LinkArea(5, 6)
        LinkLabel2.Text = "按這裡連結Google首頁"
        LinkLabel2.LinkArea = New LinkArea(5, 8)
        LinkLabel3.Text = "按這裡連結Yahoo首頁"
        LinkLabel3.LinkArea = New LinkArea(5, 7)
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.e-happy.com.tw")
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLabel2.LinkClicked
        System.Diagnostics.Process.Start("http://www.google.com.tw")
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLabel3.LinkClicked
        System.Diagnostics.Process.Start("http://www.yahoo.com.tw")
    End Sub
End Class
