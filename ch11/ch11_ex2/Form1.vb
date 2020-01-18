Public Class Form1

    Dim file As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenFileDialog1.Filter = "純文字(*.txt)|*.txt"
        OpenFileDialog1.InitialDirectory = "C:\VB2010\延伸練習\ch11\ch11_ex2\bin\Debug"
        OpenFileDialog1.FileName = "test.txt"
        RichTextBox1.Multiline = True
    End Sub
    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            file = OpenFileDialog1.FileName
            RichTextBox1.LoadFile(file, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveFileDialog1.DefaultExt = "txt"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            file = SaveFileDialog1.FileName
            RichTextBox1.SaveFile(file, RichTextBoxStreamType.PlainText)
            Me.Text = file
        End If
    End Sub
End Class
