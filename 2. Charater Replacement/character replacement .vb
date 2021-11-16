Module Module1

    Sub Main()
        Dim Str1, Str2 As String
        Dim Char1, Char2, ThisChar As Char
        Dim Count As Integer

        Str1 = ""
        Str2 = ""
        Char1 = ""
        Char2 = ""
        ThisChar = ""
        Count = 0

        Console.Write("Enter string: ")
        Str1 = Console.ReadLine

        Console.Write("Enter the character to replace:  ")
        Char1 = Console.ReadLine

        Console.Write("Enter the character to replace with:  ")
        Char2 = Console.ReadLine

        For Count = 1 To Len(Str1)

            ThisChar = Mid(Str1, Count, 1)

            If ThisChar = Char1 Then
                Str2 = Str2 + Char2
            Else
                Str2 = Str2 + ThisChar

            End If
        Next


        Console.WriteLine("The Processed string : " & Str2)
        Console.ReadKey()










    End Sub

End Module
