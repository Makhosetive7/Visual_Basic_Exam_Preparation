Module Module1
    'Develop a VB.NET program that allows the user to enter a single integer. The program should 
    'then compute both the square And square root of the number. Ensure that the square root result Is 
    'formatted to three decimal places.


    Sub Main()
        Dim number As Integer
        Dim square_Of_Number As Double
        Dim square_Root_Of_Number As Double


        Console.WriteLine("Please enter number")
        number = Console.ReadLine()

        square_Of_Number = number * number
        square_Root_Of_Number = Math.Sqrt(number)

        Console.WriteLine("the square of a number is: {0}", square_Of_Number)
        Console.WriteLine("the square root of a number is {0}", square_Root_Of_Number)

        Console.ReadKey()





    End Sub

End Module
