Module Module1
    'Write a Visual Basic program that prompts the user to enter 5 integers, stores them
    'in a single-dimensional array, And then displays the array in reverse order

    Sub Main()

        Dim numbers(4) As Integer

        'prompting user
        For i As Integer = 0 To 4
            Console.WriteLine("the prompted numbers are")
            numbers(i) = Console.ReadLine()
        Next

        'reversing array
        Array.Reverse(numbers)
        Console.WriteLine("Array in reverse order:")

        For Each num In numbers
            Console.WriteLine(num)
        Next
        Console.ReadKey()


    End Sub

End Module
