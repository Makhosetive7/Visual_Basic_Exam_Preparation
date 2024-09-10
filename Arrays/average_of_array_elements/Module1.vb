Module Module1
    'Write a Visual Basic program that asks the user to input 8 floating-point numbers,
    'stores them In a Single-dimensional array, And Then calculates And displays the average Of those
    'numbers

    Sub Main()
        Dim inputed_numbers(3) As Decimal
        Dim calculate_average As Decimal
        Dim sum As Decimal = 0


        For i As Integer = 0 To inputed_numbers.Length - 1
            Console.WriteLine("please input number" & i + 1 & ":")
            inputed_numbers(i) = Console.ReadLine
            sum += inputed_numbers(i)
        Next


        Console.WriteLine("the inputed array is:")
        For Each number In inputed_numbers
            Console.WriteLine(number)
        Next

        calculate_average = sum / 4
        Console.WriteLine("the average of array elements is: {0}", calculate_average)

        Console.ReadKey()
    End Sub

End Module
