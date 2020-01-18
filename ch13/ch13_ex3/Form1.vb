Public Class Form1

    Dim bmp As Bitmap    '全域變數的記憶體圖像
    Dim draw As Graphics '全域變數的記憶體畫布
    Dim g As Graphics    '在表單建立繪圖物件
    Dim brush As Brush = New SolidBrush(Color.Blue)  '藍色畫刷
    Dim P1, P2 As Point
    Dim pen As Pen = New Pen(Color.Black, 2)
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        g = Me.CreateGraphics()   '建立畫布 g
        bmp = New Bitmap(Me.Width, Me.Height)  '整個表單的大小
        Draw = Graphics.FromImage(bmp)         '以 bmp 建立 記憶體畫布 Draw
        draw.Clear(Me.BackColor)               '設記憶體畫布表單背景色
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        P1 = New Point(e.X, e.Y) '記錄繪圖開始的位置
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then  '按滑鼠左鍵
            g.DrawImage(bmp, 0, 0)   '在表單上顯示 bmp 記憶體圖像
            P2 = New Point(e.X, e.Y) '直線終點
            g.DrawEllipse(pen, P1.X, P1.Y, P2.X - P1.X, P2.Y - P1.Y)  '繪製提示?圓
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        P2 = New Point(e.X, e.Y)  '終點
        Draw.FillEllipse(Brush, P1.X, P1.Y, P2.X - P1.X, P2.Y - P1.Y)  '在 bmp 記憶體繪製?圓
        Form1_Paint(Nothing, Nothing)
    End Sub

    Private Sub BtnColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnColor.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            brush = New SolidBrush(ColorDialog1.Color)  '設定畫刷顏色
            pen = New Pen(ColorDialog1.Color, 2)
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Draw.Clear(Me.BackColor)
        Form1_Paint(Nothing, Nothing)
    End Sub

    Private Sub Form1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        g.DrawImage(bmp, 0, 0) '在表單上顯示 bmp 記憶體圖像
    End Sub
End Class
