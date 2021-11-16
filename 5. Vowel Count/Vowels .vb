Module Module1

    Sub Main()
        Dim str1 As String
        Dim count, Acount, Ecount, Icount, Ocount, Ucount As Integer
        Dim thischar As Char

        str1 = ""
        count = 0
        Acount = 0
        Ecount = 0
        Icount = 0
        Ocount = 0
        Ucount = 0
        thischar = ""


        Console.Write("Enter a string : ")
        str1 = UCase(Console.ReadLine())


        For count = 1 To Len(str1)
            thischar = Mid(str1, count, 1)

            If thischar = "A" Then
                Acount = Acount + 1

            ElseIf thischar = "E" Then
                Ecount = Ecount + 1

            ElseIf thischar = "O" Then
                Ocount = Ocount + 1

            ElseIf thischar = "I" Then
                Icount = Icount + 1

            ElseIf thischar = "U" Then
                Ucount = Ucount + 1
            End If
        Next count

        Console.WriteLine("The number of times A came in string is: " & Acount)
        Console.WriteLine("The number of times E came in string is: " & Ecount)
        Console.WriteLine("The number of times I came in string is: " & Icount)
        Console.WriteLine("The number of times O came in string is: " & Ocount)
        Console.WriteLine("The number of times U came in string is: " & Ucount)

        Console.ReadKey()





    End Sub

End Module
