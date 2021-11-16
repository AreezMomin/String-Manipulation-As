Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim char1, char2, char3, char4 As Char

        str1 = ""
        str2 = ""
        char1 = ""
        char2 = ""
        char3 = ""
        char4 = ""

        Console.Write("Enter the string: ")
        str1 = Console.ReadLine


        If Len(str1) <= 2 Then
            Console.Write(str1)
            Console.ReadKey()
            End
        End If


        char1 = Mid(str1, (Len(str1) - (Len(str1) - 1)), 1)
        char2 = Mid(str1, (Len(str1) - (Len(str1) - 2)), 1)
        char3 = Mid(str1, (Len(str1) - 1), 1)
        char4 = Mid(str1, Len(str1), 1)

        str2 = char1 + char2 + char3 + char4

        Console.Write(str2)
        Console.ReadKey()








    End Sub

End Module
