Public Class Form1

    Dim X, Y As Integer
    Dim Initx, Inity As Integer  ' button1 的初始位置
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Initx = taco.Left
        Inity = taco.Top
    End Sub

    Private Sub taco_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles taco.MouseMove
        If e.Button = MouseButtons.Left Then  '按滑鼠左鍵
            taco.Left = taco.Left + e.X - X   '移動 button1
            taco.Top = taco.Top + e.Y - Y
        End If
    End Sub

    Private Sub taco_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles taco.MouseDown
        X = e.X : Y = e.Y
        Me.Cursor = Cursors.Hand  '顯示手形狀滑鼠游標
    End Sub

    Private Sub taco_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles taco.MouseUp
        taco.Left = Initx
        taco.Top = Inity
    End Sub
End Class
