Module Module1

    Sub Main()
        Dim isPangram As Boolean
        Dim count, alphapos As Integer
        Dim str1, alpha As String
        Dim thischar As Char

        str1 = ""
        thischar = ""
        count = 0
        alphapos = 0
        isPangram = True
        alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"

        Console.Write("Enter the string: ")
        str1 = UCase(Console.ReadLine)

        For count = 1 To Len(alpha)
            thischar = Mid(alpha, count, 1)
            alphapos = InStr(str1, thischar)
            If alphapos = 0 Then
                isPangram = False
                Exit For
            End If



        Next

        If isPangram = True Then
            Console.Write("The string is pangram")
        ElseIf isPangram = False Then
            Console.Write(" The string is not a pangram ")

        End If
        Console.ReadKey()








    End Sub

End Module
