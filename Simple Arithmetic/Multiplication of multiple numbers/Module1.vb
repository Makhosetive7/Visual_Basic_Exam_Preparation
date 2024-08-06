Module Module1

    Sub Main()
        'Create a VB.NET program that asks the user to input three integers. The program should 
        'multiply these three numbers And display the product. Additionally, If the product Is negative, display a 
        'warning message to the user


        Dim first_Number As Integer
        Dim second_number As Integer
        Dim third_Number As Integer

        Dim ANSWER As Integer

        Console.WriteLine("Wellcome to our Multiplication of multiple numbers simple Arithmatic test")

        Console.WriteLine("Enter first number")
        first_Number = Console.ReadLine()

        Console.WriteLine("Enter second number")
        second_number = Console.ReadLine()

        Console.Write("Enter third number")
        third_Number = Console.ReadLine()

        ANSWER = first_Number * second_number * third_Number

        Console.WriteLine("the output is: {0} * {1} * {2} = {3}", first_Number, second_number, third_Number, ANSWER)

        If ANSWER < 1 Then
            Console.Write("Warning Warning there is something wrong, the output is negative")
        End If

        Console.ReadKey()
    End Sub

End Module
