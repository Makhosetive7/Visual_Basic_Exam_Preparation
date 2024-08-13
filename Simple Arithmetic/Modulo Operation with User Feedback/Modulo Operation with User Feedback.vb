Module Module1
    'Write a VB.NET application that calculates the remainder when an integer is divided by 
    'another integer. If the remainder Is zero, inform the user that the first number Is perfectly divisible by 
    'the second.

    Sub Main()
        Dim first_Number As Integer
        Dim second_number As Integer
        Dim answer As Integer

        Console.WriteLine("Please enter first number")
        first_Number = Console.ReadLine()

        Console.WriteLine("Please enter second number")
        second_number = Console.ReadLine()

        answer = first_Number Mod second_number
        Console.WriteLine("the remainder is {0}, {1} Mod {2} = {0} ", answer, first_Number, second_number)

        If answer = 0 Then
            Console.WriteLine("the first number Is perfectly divisible by the second")
        Else
            Console.WriteLine("oooooops")
        End If

        Console.ReadKey()

    End Sub

End Module
