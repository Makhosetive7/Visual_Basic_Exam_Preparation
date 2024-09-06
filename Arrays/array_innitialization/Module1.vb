Module Module1
    'Write a Visual Basic program that initializes a single-dimensional array with the
    'following integers :  10, 20, 30, 40, 50. The program should
    '1. Display all the elements in the array.
    '2. Calculate And display the sum of all elements in the array.
    '3. Find And display the maximum value in the array.

    Sub Main()

        Dim array_set() As Integer = {10, 20, 30, 40, 50}
        Dim sum As Integer = 0

        '1. Display all the elements in the array.
        Console.WriteLine("the array set consists of:")
        For i As Integer = 0 To array_set.Length - 1
            Console.WriteLine(array_set(i))

            Console.WriteLine("sum of all elements in array set is:")
            sum = +array_set(i)
        Next

        '2. Calculate And display the sum of all elements in the array.
        For i As Integer = 0 To array_set.Length - 1
            sum += array_set(i)
        Next

        Console.WriteLine("sum = {0}", sum)

        '3. Find And display the maximum value in the array.
        Dim max As Integer
        max = array_set.Max()
        Console.WriteLine("The maximum value in the array is: {0}", max)





        Console.ReadKey()

    End Sub

End Module
