Module Module1

    Sub Main()
        Dim Str1, Str2 As String
        Dim StrCounter, IntCounter, SpecialCounter, Count As Integer
        Dim ThisChar As Char

        Str1 = ""
        Str2 = ""
        StrCounter = 0
        IntCounter = 0
        SpecialCounter = 0
        Count = 0
        ThisChar = ""
        Console.WriteLine("Enter the string")
        Str1 = Console.ReadLine()

        For Count = 1 To Len(Str1)
            ThisChar = Mid(Str1, Count, 1)
            ThisChar = UCase(ThisChar)


            If ThisChar >= "A" And ThisChar <= "Z" Then
                StrCounter = StrCounter + 1


            ElseIf Asc(ThisChar) >= 48 And Asc(ThisChar) <= 57 Then
                IntCounter = IntCounter + 1

            ElseIf Asc(ThisChar) >= 32 And Asc(ThisChar) <= 47 Then
                SpecialCounter = SpecialCounter + 1



            End If

        Next

        Console.WriteLine("The number of characters in the string are : " & Len(Str1))


        Console.WriteLine("The number of alphabets are :" & StrCounter)


        Console.WriteLine("The number of digits are :" & IntCounter)


        Console.WriteLine("The number of special characters  : " & SpecialCounter)
        Console.ReadKey()




    End Sub

End Module
