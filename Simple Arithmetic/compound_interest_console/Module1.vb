Imports System.IO

Module Module1
    'The formula to calculate compound interest and determine the amount to be earned on a deposit after a number of periods is:
    'Where:
    '𝑃 Is the amount deposited.
    '𝑟 Is the annual interest rate.
    '𝑚 Is the number of compounding periods per year.
    '𝑛 Is the total number of compounding periods.
    '𝐴 Is the amount earned after 𝑛 periods.
    'You are required To come up With a program that calculates the interest earned And amount earned given that the user enters the principal, interest rate, number Of periods, And compound frequency. Use the sample Interface provided below.

    Sub Main()

        Dim P As Double
        Dim R As Double
        Dim M As Double
        Dim N As Double
        Dim A As Double
        Dim interest_earned As Decimal

        Console.WriteLine("Please enter amount deposited (Principal)")
        P = Console.ReadLine()


        Console.WriteLine("please enter annual interest rate (Rate)")
        R = Console.ReadLine()

        Console.WriteLine("Please enter compounding period per year")
        M = Console.ReadLine()

        Console.WriteLine("Please enter total number of compounding periods")
        N = Console.ReadLine()



        A = P * Math.Pow(1 + R / M, N)
        Console.WriteLine("The amount earned after {0} periods is: {1:C}", N, A)

        Console.ReadKey()
    End Sub

End Module
