Module Module1
    'Create a VB.NET program that asks the user for a base number and an exponent. The program
    'should calculate the result Of raising the base To the power Of the exponent And display the result

    Sub Main()
        Dim base_number As Integer
        Dim exponent_number As Integer
        Dim answer As Integer

        Console.WriteLine("Please enter base number:")
        base_number = Console.ReadLine()

        Console.WriteLine("Please enter exponent number")
        exponent_number = Console.ReadLine()


        'answer = base_number ^ exponent_number
        answer = Math.Pow(base_number, exponent_number)
        Console.WriteLine("The output is: {0}", answer)

        Console.ReadKey()
    End Sub

End Module
