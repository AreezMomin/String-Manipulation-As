Module Module1

    Sub Main()
        Dim highchar, char1, char2 As Char
        Dim count1, count2, Count, Highest As Integer
        Dim Sentence As String
        Sentence = ""
        highchar = ""
        char1 = ""
        char2 = ""
        count1 = 0
        count2 = 0
        Count = 0
        Highest = 0

        Console.Write(" Enter the sentence please : ")
        Sentence = Console.ReadLine()

        For count1 = 1 To Len(Sentence)
            char1 = Mid(Sentence, count1, 1)
            Count = 0
            char1 = UCase(char1)
            For count2 = 1 To Len(Sentence)
                char2 = Mid(Sentence, count2, 1)
                char2 = UCase(char2)
                If char1 = char2 Then Count = Count + 1

                If Count > Highest Then
                    highchar = char2
                    Highest = Count
                End If

            Next


        Next

        Console.Write(UCase(highchar) & " is  occuring " & Highest & " times in the your sentence.")
        Console.ReadKey()



    End Sub

End Module
