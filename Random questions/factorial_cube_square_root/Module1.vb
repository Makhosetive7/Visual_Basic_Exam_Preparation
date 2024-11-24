Module Module1
    Sub Main()

        ' Finding square root
        Dim number_to_square As Integer
        Dim result As Double

        Console.WriteLine("Please enter number to square: ")
        number_to_square = Integer.Parse(Console.ReadLine())

        result = Math.Sqrt(number_to_square)

        Console.WriteLine("The square root of {0} is: {1}", number_to_square, result)


        'Finding Power
        Dim base_number As Double
        Dim exponent_number As Double
        Dim powered_result As Double

        Console.WriteLine("Please enter base number :")
        base_number = Integer.Parse(Console.ReadLine())

        Console.WriteLine("Please enter exponent number :")
        exponent_number = Integer.Parse(Console.ReadLine())

        powered_result = Math.Pow(base_number, exponent_number)

        Console.WriteLine("The power of given number is: {0}", powered_result)

        'Finding cube
        Dim cubed_number As Double
        Dim cubed_result As Double

        Console.WriteLine("Please enter number to be cubed :")
        cubed_number = Integer.Parse(Console.ReadLine())

        cubed_result = cubed_number ^ (1 / 3)

        Console.WriteLine("The cubed result is: {0}", cubed_result)

        'Finding factorial
        Dim number As Integer
        Dim factorial As Long = 1

        Console.WriteLine("Please enter number: ")
        number = Integer.Parse(Console.ReadLine())

        For i As Integer = 1 To number
            factorial *= i
        Next

        Console.WriteLine("The factorial of {0} is {1}", number, factorial)

        Console.ReadKey()
    End Sub
End Module
