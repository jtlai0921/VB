Public Class Form1

    Dim g As Graphics      '在表單建立繪圖物件
    Dim pen As Pen = New Pen(Color.Blue, 2) '藍色畫筆
    Dim P1, P2 As Point
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        g = Me.CreateGraphics()   '建立畫布 g
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        P1 = New Point(e.X, e.Y)  '直線起點
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        P2 = New Point(e.X, e.Y)  '直線終點
        g.DrawLine(pen, P1.X, P1.Y, P2.X, P2.Y)  '繪製藍色直線
    End Sub

    Private Sub BtnColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnColor.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            pen.Color = ColorDialog1.Color  '設定顏色
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        g.Clear(Me.BackColor)
    End Sub
End Class
