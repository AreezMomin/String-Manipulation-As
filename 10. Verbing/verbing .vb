Module Module1

    Sub Main()
        Dim str1, ingStr, str2 As String

        str1 = ""
        str2 = ""
        ingStr = "ING"

        Console.Write("Enter the string: ")
        str1 = Console.ReadLine()
        str1 = UCase(str1)

        If Len(str1) < 3 Then
            Console.Write(str1)
            Console.ReadKey()
            End
        End If

        str2 = Mid(str1, ((Len(str1) - 3) + 1), 3)

        If str2 = ingStr Then
            str1 = str1 + "LY"
        Else
            str1 = str1 + ingStr
        End If

        Console.Write("The processed string is: " & str1)
        Console.ReadKey()






    End Sub

End Module
