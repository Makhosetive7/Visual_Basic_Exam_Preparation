Module Module1
    'Develop a VB.NET program that allows the user to enter a single integer. The program should
    'then compute both the square And square root of the number. Ensure that the square root result Is
    'formatted to three decimal places

    Sub Main()
        Dim number As Integer
        Dim square_answer As Double
        Dim square_rooted_answer As Double


        Console.WriteLine("Please enter number:")
        number = Console.ReadLine()

        square_answer = Math.Pow(number, 2)
        square_rooted_answer = Math.Sqrt(number)

        Console.WriteLine("The output of squared number is: {0} ", square_answer)
        Console.WriteLine("The output of square rooted number is: {0:F3}", square_rooted_answer)

        Console.ReadLine()
    End Sub

End Module
