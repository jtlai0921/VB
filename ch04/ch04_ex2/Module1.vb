Module Module1

    Sub Main()
        Dim i As Integer
        Dim week() As String = {"星期一", "星期二", "星期三", "星期四", "星期五", "星期六", "星期日"}
        Console.Write("輸入星期幾(1-7)：")
        i = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine(week(i - 1))
        Console.Read()
    End Sub

End Module
