Module Module1

    Class Rectangle            '建立 Rectangle  類別 
        Public height, width As Integer
        Public Sub show()        '定義函式
            Console.WriteLine("長方形的長 = {0}", height)
            Console.WriteLine("長方形的寬 = {0}", width)
        End Sub
    End Class

    Sub Main()
        Dim Rect As Rectangle = New Rectangle()
        Console.Write("hieght=")
        Rect.height = Convert.ToInt32(Console.ReadLine())
        Console.Write("width=")
        Rect.width = Convert.ToInt32(Console.ReadLine())
        Rect.show()       '呼叫 show() 函式     
        Console.Read()
    End Sub

End Module
