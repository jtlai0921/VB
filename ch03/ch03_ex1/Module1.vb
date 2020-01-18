Module Module1

    Sub Main()
        Dim Payment As Integer
        Console.Write("請輸入購買金額:")
        Payment = Convert.ToInt32(Console.ReadLine())
        If (Payment <= 1000) Then
            Console.WriteLine("實付金額：{0}", Payment * (1 - 0.06))
        ElseIf (Payment > 1000 And Payment <= 5000) Then
            Console.WriteLine("實付金額：{0}", Payment * (1 - 0.1))
        ElseIf (Payment > 5000 And Payment <= 20000) Then
            Console.WriteLine("實付金額：{0}", Payment * (1 - 0.15))
        ElseIf (Payment > 20000 And Payment <= 50000) Then
            Console.WriteLine("實付金額：{0}", Payment * (1 - 0.2))
        Else
            Console.WriteLine("實付金額：{0}", Payment * (1 - 0.25))
        End If
        Console.Read()

    End Sub

End Module
