Module Module1
    'Write a console program that accepts the current date and the rental duration (in days)
    'from the user. Calculate And display the payment due Date, which Is 5 days after the
    'rental end date.
    'Use DateTime.AddDays() method to compute the payment due date.



    Sub Main()
        Dim current_date As DateTime = Date.Today
        Dim rental_duration As Integer
        Dim payment_due_date As DateTime
        Dim rental_end_date As DateTime

        Console.WriteLine("please enter rental duration:")
        rental_duration = Console.ReadLine()

        rental_end_date = current_date.AddDays(rental_duration)

        payment_due_date = rental_end_date.AddDays(5)

        Console.WriteLine("Rental End Date: " & rental_end_date.ToShortDateString())
        Console.WriteLine("Payment Due Date: " & payment_due_date.ToShortDateString())

        Console.ReadKey()





    End Sub

End Module
