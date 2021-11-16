Module Module1

    Sub Main()
        Dim str1, str2, str3, str4 As String
        Dim count1, count2 As Integer
        Dim char1, char2, thischar1, thischar2 As Char

        str1 = ""
        str2 = ""
        str3 = ""
        str4 = ""
        count1 = 0
        count2 = 0
        char1 = ""
        char2 = ""
        thischar1 = ""
        thischar2 = ""


        Console.Write("Enter the first word: ")
        str1 = Console.ReadLine()
        Console.Write("Enter the second word: ")
        str2 = Console.ReadLine()

        char1 = Left(str1, 1)
        char2 = Left(str2, 1)

        str3 = char2
        str4 = char1
        For count1 = 2 To Len(str2)
            thischar1 = Mid(str2, count1, 1)
            str4 = str4 + thischar1

        Next

        For count2 = 2 To Len(str1)
            thischar2 = Mid(str1, count2, 1)
            str3 = str3 + thischar2

        Next

        Console.Write("The processed string is: " & str3 & " " & str4)
        Console.ReadKey()


    End Sub

End Module
