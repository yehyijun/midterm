Module Module1

    Sub Main()
        Dim keyin, guess, count, min, max As Integer
        count = 0
        min = 0
        max = 1000
        Dim r As New Random()
        guess = r.Next(1, 1000)
        Do
            Console.Write("數字範圍 {0} < ? < {1} :", min, max)
            keyin = Val(Console.ReadLine())
            count += 1
            If keyin >= 1 And keyin < 1000 Then
                If keyin = guess Then
                    Console.WriteLine("猜對了，答案是{0}", guess)
                    Exit Do
                ElseIf keyin > guess Then
                    max = keyin
                    Console.Write("再小一點")
                ElseIf keyin < guess Then
                    min = keyin
                    Console.Write("再大一點")
                End If
                Console.WriteLine(" 您猜了{0}次", count)
                Console.WriteLine()
            Else
                Console.WriteLine("請輸入提示範圍內的數字")

            End If

        Loop While True
        Console.Read()

    End Sub

End Module
