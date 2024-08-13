Module Module1

    Sub Main()
        'Design a VB.NET program that divides one integer by another. The program should handle the 
        'scenario where the user attempts to divide by zero by displaying an error message instead of crashing.

        Dim first_Number As Integer
        Dim second_Number As Integer
        Dim Answer As Integer

        Console.WriteLine("Please enter the first number")
        first_Number = Console.ReadLine()

        Console.WriteLine("Please enter the second number")
        second_Number = Console.ReadLine()

        Try

            Answer = first_Number \ second_Number
            Console.WriteLine("the answer is {0}, {1} / {2} = {0}", Answer, first_Number, second_Number)

        Catch ex As DivideByZeroException
            Console.WriteLine("trying to devide by 0 will definately produce an error")
        End Try

        Console.ReadKey()


    End Sub

End Module
