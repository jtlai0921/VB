Public Class Form1

    Dim MyFontStyle As String '文字字型
    Dim MyFontSize As Integer     '文字大小
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyFontStyle = "標楷體"
        MyFontSize = 20
        lblShow.ForeColor = Color.Blue
        lblShow.Text = "設定文字字型和顏色"
        標楷體ToolStripMenuItem.Checked = True  '預設勾選「標楷體」
        細明體ToolStripMenuItem.Checked = False
        lblShow.Font = New Font(MyFontStyle, MyFontSize, FontStyle.Regular) '預設標楷體、20、藍色
    End Sub

    Private Sub 標楷體ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 標楷體ToolStripMenuItem.Click
        MyFontStyle = "標楷體"
        標楷體ToolStripMenuItem.Checked = True '勾選「標楷體」
        細明體ToolStripMenuItem.Checked = False
        lblShow.Font = New Font(MyFontStyle, MyFontSize, lblShow.Font.Style)
    End Sub

    Private Sub 細明體ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 細明體ToolStripMenuItem.Click
        MyFontStyle = "細明體"
        標楷體ToolStripMenuItem.Checked = False
        細明體ToolStripMenuItem.Checked = True   '勾選「細明體」
        lblShow.Font = New Font(MyFontStyle, MyFontSize, lblShow.Font.Style)
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

    Private Sub ToolStripComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Select Case ToolStripComboBox1.SelectedIndex
            Case 0 : MyFontSize = 12
            Case 1 : MyFontSize = 24
            Case 2 : MyFontSize = 32
        End Select
        lblShow.Font = New Font(MyFontStyle, MyFontSize, lblShow.Font.Style)
    End Sub

    Private Sub ToolStripComboBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ToolStripComboBox1.KeyPress
        If e.KeyChar = Chr(Keys.Return) Then '按 Enter鍵後開始變化文字大
            MyFontSize = Convert.ToInt32(ToolStripComboBox1.Text)
            lblShow.Font = New Font(MyFontStyle, MyFontSize, lblShow.Font.Style)
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If ToolStripButton1.Checked = True Then
            ToolStripButton1.Checked = False
        Else
            ToolStripButton1.Checked = True
        End If
        lblShow.Font = New Font(MyFontStyle, MyFontSize, lblShow.Font.Style Xor FontStyle.Bold) '粗體
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If (ToolStripButton2.Checked = True) Then
            ToolStripButton2.Checked = False
        Else
            ToolStripButton2.Checked = True
        End If
        lblShow.Font = New Font(MyFontStyle, MyFontSize, lblShow.Font.Style Xor FontStyle.Italic) '斜體
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        If ToolStripButton3.Checked = True Then
            ToolStripButton3.Checked = False
        Else
            ToolStripButton3.Checked = True
        End If
        lblShow.Font = New Font(MyFontStyle, MyFontSize, lblShow.Font.Style Xor FontStyle.Underline) '加底線
    End Sub
End Class