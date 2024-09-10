Module Module1
    'Design a VB.NET program that divides one integer by another. The program should handle the
    'scenario where the user attempts To divide by zero by displaying an Error message instead Of crashing

    Sub Main()
        Dim first_integer As Integer
        Dim second_integer As Integer
        Dim answer As Integer


        Try
            Console.WriteLine("Please enter first number:")
            first_integer = Console.ReadLine

            Console.WriteLine("Please enter second number:")
            second_integer = Console.ReadLine


            answer = first_integer / second_integer

            Console.WriteLine("The output is: {0}", answer)

        Catch ex As System.DivideByZeroException
            Console.WriteLine("Error Alert: can't devide a number by zer")
        End Try

        Console.ReadKey()

    End Sub
End Module
