Module Module1
    'Write a program that asks the user to input two numbers and an operation (add, subtract, multiply, divide).
    'Use a Select Case statement to perform the corresponding operation and display the result.
    'If the user enters an invalid operation, display an appropriate Error message.

    Sub Main()
        Dim number_1 As Integer
        Dim number_2 As Integer
        Dim operation As String
        Dim result As Double



        Console.WriteLine("Please enter first number : ")
            number_1 = Console.ReadLine()

            Console.WriteLine("Please enter second number : ")
        number_2 = Console.ReadLine()

        Console.WriteLine("Please enter intended operation :")
        operation = Console.ReadLine()

        Select Case operation
            Case "addition"
                result = number_1 + number_2
                Console.WriteLine("the total is : {0} + {1} = {2}", number_1, number_2, result)
            Case "subtract"
                result = number_1 - number_2
                Console.WriteLine("the total is : {0} - {1} = {2}", number_1, number_2, result)
            Case "multiplication"
                result = number_1 * number_2
                Console.WriteLine("the total is : {0} * {1} = {2}", number_1, number_2, result)
            Case "division"
                result = number_1 / number_2
                Console.WriteLine("the total is : {0} / {1} = {2}", number_1, number_2, result)
        End Select

        Console.ReadKey()

    End Sub

End Module
