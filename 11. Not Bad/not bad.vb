Module Module1

    Sub Main()
        Dim notStr, badStr, str1, str2 As String
        Dim count, notPos, badPos As Integer
        Dim char1 As Char

        notStr = "not"
        badStr = "bad"
        str1 = ""
        str2 = ""
        count = 0
        char1 = ""
        badPos = 0
        notPos = 0

        Console.Write("Enter the string: ")
        str1 = Console.ReadLine()
        str1 = LCase(str1)

        notPos = InStr(str1, notStr)
        If notPos = 0 Then
            Console.Write("String does not contain the word 'not' ")
            Console.ReadKey()
            End
        End If

        badPos = InStr(str1, badStr)
        If badPos = 0 Then
            Console.Write("String does not contain the word 'bad' ")
            Console.ReadKey()
            End
        End If

        If badPos < notPos Then
            Console.Write("Inappropiate string. 'bad comes before not'")
            Console.ReadKey()
            End
        End If

        If notPos < badPos Then
            For count = 1 To Len(str1)
                char1 = Mid(str1, count, 1)

                If count = notPos Then
                    str2 = str2 + "good"
                    count = badPos + 3
                Else
                    str2 = str2 + char1
                End If
            Next
        End If

        Console.Write("The processed string is: " & str2)
        Console.ReadKey()
        








    End Sub

End Module
