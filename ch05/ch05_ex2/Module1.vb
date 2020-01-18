Module Module1

    Sub Main()
        Dim n As Integer
        Dim c As Char
        Console.Write("請輸入要顯示的字元：")
        c = Convert.ToChar(Console.ReadLine())
        Console.Write("請輸入顯示字元數：")
        n = Convert.ToInt32(Console.ReadLine())
        showchar(n, c)
        Console.Read()
    End Sub

    Sub showchar(ByVal n As Integer, ByVal c As Char)
        Dim i As Integer
        For i = 0 To n - 1
            Console.Write(c)
        Next
        Console.ReadLine()
    End Sub

End Module
