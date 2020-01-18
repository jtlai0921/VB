Module Module1

    Sub Main()
        Dim nat, eng, math As Integer    '宣告儲存成績的變數 
        Console.Write("請輸入國文成績：")   '輸入國文成績 
        nat = Convert.ToInt16(Console.ReadLine())
        Console.Write("請輸入英文成績：")     '輸入英文成績 
        eng = Convert.ToInt16(Console.ReadLine())
        Console.Write("請輸入數學成績：")    '輸入數學成績 
        math = Convert.ToInt16(Console.ReadLine())
        Dim sum As Integer = nat + eng + math     '計算總分 
        Dim ave As Single = Convert.ToSingle(sum) / 3    '計算平均 
        Console.WriteLine("您的總分為 {0} 分，平均為 {1} 分", sum, ave)
        Console.Read()
    End Sub

End Module
