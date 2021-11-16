Module Module1

    Sub Main()
        Dim donuts As Integer


        donuts = 0

        Console.Write("Enter Number of Donuts: ")
        donuts = Console.ReadLine
        If donuts < 10 Then
            Console.Write("The Number of donuts ordered are: " & donuts)
        ElseIf donuts >= 10 Then
            Console.Write("The number of donuts: Many")

        End If
        Console.ReadKey()

    End Sub

End Module
