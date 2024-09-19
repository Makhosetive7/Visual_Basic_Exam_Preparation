Module Module1
    'Jane is a typist who works freelance and she charges the following rates:
    'A page typed Single spacing $4.75
    'A page typed Double spacing $3.50
    'The user must enter the number Of pages she typed In Single spacing And the number Of pages she
    'typed in double spacing. Calculate the amount due. She saves 15% of this amount to buy supplies.
    'Write a console application To display the net amount she earned For her work.

    Sub Main()
        Dim single_spacing As Decimal = 4.75
        Dim double_spacing As Decimal = 3.5

        Dim single_spacing_page_number As Integer
        Dim double_spacing_page_number As Integer
        Dim total_amount_before_deduction As Decimal
        Dim total_amount_earned_after_deduction As Decimal


        Console.WriteLine("Please enter the number of pages for single spacing")
        single_spacing_page_number = Console.ReadLine()

        Console.WriteLine("Please enter the number of pages for double spacing")
        double_spacing_page_number = Console.ReadLine()

        total_amount_before_deduction = (single_spacing_page_number * single_spacing) + (double_spacing_page_number - double_spacing)
        Console.WriteLine($"The total amount earned before deductions is: {total_amount_before_deduction}")

        total_amount_earned_after_deduction = (single_spacing_page_number * single_spacing) + (double_spacing_page_number - double_spacing) - 0.15
        Console.WriteLine("The total weekly amount earned after deductions is {0}", total_amount_earned_after_deduction)



        Console.ReadKey()






    End Sub

End Module
