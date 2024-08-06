Imports System

Module Program
    Sub Main(args As String())
        ' You are tasked with developing a simple calculator in VB.NET that allows the user to input two integers.Your Program should then display the sum of these two numbers. Include error handling to ensure the user inputs valid integers

        Dim first_Integer As Integer
        Dim second_Integer As Integer
        Dim ANSWER As Integer

        Console.WriteLine("Good day sir/madam wellcome to out simple Arithmetic problem")

        Console.WriteLine("Please enter our first integer")
        first_Integer = Console.ReadLine()

        Console.WriteLine("Please enter our second integer")
        second_Integer = Console.ReadLine()

        ANSWER = first_Integer + second_Integer

        Console.WriteLine("The answer is: {0} + {1} = {2}", first_Integer, second_Integer, ANSWER)

        Console.ReadKey()
    End Sub
End Module
