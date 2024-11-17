Module Module1
    'Develop a console program that calculates and displays the rental period in days, hours,
    'And minutes. The user provides the rental start And return dates And times. Output the
    'period in days, hours, And minutes format.
    '---o Hint: Use TimeSpan To break down the difference into days, hours, And minutes.


    Sub Main()
        Dim rental_start_date As DateTime
        Dim rental_return_date As DateTime
        Dim result_date As TimeSpan

        Console.WriteLine("Please enter rental start date:")
        rental_start_date = Console.ReadLine()

        Console.WriteLine("Please enter rental return date:")
        rental_return_date = Console.ReadLine()


        result_date = (rental_return_date - rental_start_date)

        Console.WriteLine("the rental return date is in {0}days {1}hours and {2}minutes", result_date.Days, result_date.Hours, result_date.Minutes)

        Console.ReadKey()
    End Sub

End Module
