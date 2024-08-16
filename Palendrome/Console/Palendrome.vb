Module Module1
    'checking if a string is a palendrome
    Sub Main()

        Dim word As String
        Dim isPalendrome As String

        Console.WriteLine("Please enter string")
        word = Console.ReadLine()

        isPalendrome = StrReverse(word)

        If word = isPalendrome Then
            Console.WriteLine("the string is a palendrome")
        Else
            Console.WriteLine("its not a palendrome")
        End If

        Console.ReadLine()



    End Sub

End Module
