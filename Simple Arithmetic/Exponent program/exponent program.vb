Module Module1
    'Create a VB.NET program that asks the user for a base number and an exponent. The program 
    'should calculate the result Of raising the base To the power Of the exponent And display the result.

    Sub Main()
        Dim baseNumber As Double
        Dim exponent As Double
        Dim result As Double

        Console.Write("Enter the base number: ")
        baseNumber = Console.ReadLine()

        Console.Write("Enter the exponent: ")
        exponent = Console.ReadLine()

        result = Math.Pow(baseNumber, exponent)

        Console.WriteLine("{0} raised to the power of {1} is {3}", baseNumber, exponent, result)


        Console.ReadKey()
    End Sub

End Module
