Public Class Form1

    Dim g As Graphics      '在表單建立繪圖物件
    Dim brush As Brush = New SolidBrush(Color.Blue)  '藍色畫刷
    Dim P1, P2 As Point
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        g = Me.CreateGraphics()   '建立畫布 g
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        P1 = New Point(e.X, e.Y)  '起點
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        P2 = New Point(e.X, e.Y)  '終點
        g.FillEllipse(brush, P1.X, P1.Y, P2.X - P1.X, P2.Y - P1.Y)  '繪製藍色填滿楕圓
    End Sub

    Private Sub BtnColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnColor.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            brush = New SolidBrush(ColorDialog1.Color)  '設定畫刷顏色
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        g.Clear(Me.BackColor)
    End Sub
End Class
