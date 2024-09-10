Module Module1
    'Write a VB.NET application that calculates the remainder when an integer is divided by
    'another integer. If the remainder Is zero, inform the user that the first number Is perfectly divisible by
    'the second.

    Sub Main()
        Dim first_integer As Integer
        Dim second_integer As Integer
        Dim answer As Integer

        Console.WriteLine("Please enter first number:")
        first_integer = Console.ReadLine()

        Console.WriteLine("Please enter second number:")
        second_integer = Console.ReadLine()

        answer = first_integer Mod second_integer
        Console.WriteLine("The output is: {0}", answer)

        If answer = 0 Then
            Console.WriteLine("first number Is perfectly divisible by the second")
        Else
            Console.WriteLine("ooooouch... first number Is not perfectly divisible by the second")
        End If

        Console.ReadKey()
    End Sub

End Module
