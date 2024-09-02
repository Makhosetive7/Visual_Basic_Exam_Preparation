Module Module1
    'Write a Visual Basic program that initializes a single-dimensional array with the 
    'following integers :  10, 20, 30, 40, 50. The program should
    'Display all the elements in the array.
    'Calculate And display the sum of all elements in the array.
    'Find And display the maximum value in the array


    Sub Main()
        Dim numbers() As Integer = {10, 20, 30, 40, 50}

        Console.WriteLine("the elements in an array are:")

        For Each num In numbers
            Console.WriteLine(num)
        Next


        'calculating total sum
        Dim total As Integer = 0

        For Each num In numbers
            total += num
        Next
        Console.WriteLine("the sum of all elements in an array is:" & total)

        'finding maximum number in an array
        Console.WriteLine("the max is:" & numbers.Max)
        Console.ReadKey()
    End Sub

End Module
