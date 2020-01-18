Module Module1

    Class Rectangle            '建立 Rectangle  類別 
        Public height, width As Integer
        Public Sub show()        '定義方法
            Console.WriteLine("長方形的長 = {0}", height)
            Console.WriteLine("長方形的寬 = {0}", width)
        End Sub
        Public Function area()
            Return height * width
        End Function
    End Class

    Sub Main()
        Dim Rect As Rectangle = New Rectangle()
        Console.Write("hieght=")
        Rect.height = Convert.ToInt32(Console.ReadLine())
        Console.Write("width=")
        Rect.width = Convert.ToInt32(Console.ReadLine())
        Dim a As Integer = Rect.area()
        Console.WriteLine("面積 = {0}", a)
        Console.Read()
    End Sub

End Module
