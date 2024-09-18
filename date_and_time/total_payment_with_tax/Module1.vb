Module Module1
    'Build a console program where the user inputs the rental start date, return date, and
    'daily rental fee. The program calculates the total rental days And the total amount
    'payable, including a 12% tax. Output the total amount

    Sub Main()
        Dim rental_start_date As DateTime
        Dim rental_return_date As DateTime
        Dim total_rental_days As Long
        Dim daily_rental_fee As Double = 2
        Dim total_amount_payable_before_taxes As Double
        Dim total_amount_payable_after_taxes As Double


        Console.WriteLine("Please enter Rental start date:")
        rental_start_date = Console.ReadLine()

        Console.WriteLine("Please enter Rental return date:")
        rental_return_date = Console.ReadLine()


        total_rental_days = DateDiff(DateInterval.Day, rental_start_date, rental_return_date)
        'total_rental_days = (rental_return_date - rental_start_date).Days
        Console.WriteLine("Total rental days amounts to: {0}", total_rental_days)

        total_amount_payable_before_taxes = daily_rental_fee * total_rental_days

        Console.WriteLine("Total amount payable before taxes is: {0}", total_amount_payable_before_taxes)

        total_amount_payable_after_taxes = (12 / 100) * total_amount_payable_before_taxes
        Console.WriteLine("Total amount payable after taxes is: {0}", total_amount_payable_after_taxes)


        Console.ReadLine()

    End Sub

End Module
