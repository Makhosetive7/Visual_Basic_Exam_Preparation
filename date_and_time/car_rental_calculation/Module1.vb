Module Module1
    'Write a console application that calculates the number of rental days for a car. The user
    'will input the rental start Date And Return Date. The program should output the total
    'rental days.

    Sub Main()
        Dim start_date As DateTime
        Dim end_date As DateTime
        Dim total_number_of_days As Integer

        Console.WriteLine("please enter start date (yyyy-md-d):")
        start_date = Console.ReadLine()

        Console.WriteLine("please enter end date (yyyy-md-d):")
        end_date = Console.ReadLine

        total_number_of_days = (end_date - start_date).Days

        Console.WriteLine("the total number of rental days for a car are: {0}", total_number_of_days)



        Console.ReadKey()

    End Sub

End Module
