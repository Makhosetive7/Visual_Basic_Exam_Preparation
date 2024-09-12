Module Module1
    'Factorial
    'square_root
    'exponential
    'cube


    Sub Main()
        Dim number As Double
        Dim cube_answer As Double
        Dim square_root_answer As Double
        Dim exponential_answer As Double


        Console.WriteLine("Please enter number:")
        number = Console.ReadLine()

        'cube root solution
        cube_answer = number ^ (1 / 3)
        Console.WriteLine("The cube of entered number is: {0}", cube_answer)

        'square root solution
        square_root_answer = Math.Sqrt(number)
        Console.WriteLine("The square root if given number is: {0}", square_root_answer)

        'exponential solution
        exponential_answer = Math.Pow(number, 2)
        Console.WriteLine("The exponential of a given number is: {0}", exponential_answer)


        'factorial solution

    End Sub

End Module
