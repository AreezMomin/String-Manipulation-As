Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim thischar, firstchar, char2 As Char
        Dim count1 As Integer

        str1 = ""
        str2 = ""
        thischar = ""
        firstchar = ""
        count1 = 0
        char2 = "*"

        Console.Write("Enter the string: ")
        str1 = Console.ReadLine()
        str1 = UCase(str1)
        firstchar = Left(str1, 1)
        str2 = firstchar

        For count1 = 1 To Len(str1)
            thischar = Mid(str1, count1 + 1, 1)
            If thischar = firstchar Then
                str2 = str2 + char2
            Else : str2 = str2 + thischar
            End If
        Next

        Console.Write("The processed string is: " & LCase(str2))
        Console.ReadKey()





    End Sub

End Module
