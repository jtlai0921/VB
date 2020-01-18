Public Class Form1

    Dim x, y As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        taco.Image = New Bitmap("taco.png")  '小章魚
        taco.SizeMode = PictureBoxSizeMode.StretchImage
        x = taco.Left
        y = taco.Top
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                If (taco.Top + taco.Height <= 0) Then
                    taco.Top = Me.Height
                Else
                    taco.Top -= 5
                End If
            Case Keys.Down
                If (taco.Top >= Me.Height) Then
                    taco.Top = 0 - taco.Height
                Else
                    taco.Top += 5
                End If
            Case Keys.Left
                If (taco.Width + taco.Left <= 0) Then
                    taco.Left = Me.Width
                Else
                    taco.Left -= 5
                End If
            Case Keys.Right
                If (taco.Left >= Me.Width) Then
                    taco.Left = 0 - taco.Width
                Else
                    taco.Left += 5
                End If
       End Select 
    End Sub

    Private Sub Form1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        taco.Left = x
        taco.Top = y
    End Sub
End Class
