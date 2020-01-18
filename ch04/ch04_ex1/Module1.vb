Module Module1

    Sub Main()
        Dim Mount(,) As String = {{"玉山", "4000公尺"}, {"陽明山", "1000公尺"}, {"阿里山", "2500公尺"}}
        Dim i, j As Integer
        For i = 0 To 2
            For j = 0 To 1
                If (j = 1) Then
                    Console.Write(" 的高度是：")
                End If
                Console.Write(Mount(i, j))
            Next
            Console.WriteLine()
        Next
        Console.Read()
    End Sub

End Module
