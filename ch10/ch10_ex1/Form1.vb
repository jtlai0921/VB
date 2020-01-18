Public Class Form1

    Dim FontStyle As String '文字字體
    Dim FontSize As Integer '文字大小
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FontStyle = "標楷體"
        FontSize = 20
        lblShow.ForeColor = Color.Blue
        lblShow.Text = "設定文字字型和顏色"
        lblShow.Font = New Font(FontStyle, FontSize) '設定文字字型、顏色
        標楷體ToolStripMenuItem.Checked = True       '預設勾選「標楷體」
        細明體ToolStripMenuItem.Checked = False
    End Sub
  
    Private Sub 標楷體ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 標楷體ToolStripMenuItem.Click
        FontStyle = "標楷體"
        lblShow.Font = New Font(FontStyle, FontSize)
        標楷體ToolStripMenuItem.Checked = True     '勾選「標楷體」
        細明體ToolStripMenuItem.Checked = False
    End Sub

    Private Sub 細明體ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 細明體ToolStripMenuItem.Click
        FontStyle = "細明體"
        lblShow.Font = New Font(FontStyle, FontSize)
        標楷體ToolStripMenuItem.Checked = False
        細明體ToolStripMenuItem.Checked = True  '勾選「細明體」
    End Sub

    Private Sub 紅色RToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 紅色RToolStripMenuItem.Click
        lblShow.ForeColor = Color.Red
    End Sub

    Private Sub 黑色BToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 黑色BToolStripMenuItem.Click
        lblShow.ForeColor = Color.Black
    End Sub

    Private Sub 綠色GToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 綠色GToolStripMenuItem.Click
        lblShow.ForeColor = Color.Green
    End Sub
End Class
