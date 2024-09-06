Module Module1
    'Write a Visual Basic program that prompts the user To enter 5 integers, stores them
    'in a single-dimensional array, And then displays the array in reverse order

    Sub Main()
        Dim array_integers(4) As Integer
        'user input
        For i As Integer = 0 To array_integers.Length - 1
            Console.WriteLine("Please enter array integers:")
            array_integers(i) = Console.ReadLine
        Next

        'array reversal
        Console.WriteLine("the reversed order if entered array integers is:")
        Array.Reverse(array_integers)

        For Each num As Integer In array_integers
            Console.WriteLine(num)
        Next



        Console.ReadKey()

    End Sub


End Module
