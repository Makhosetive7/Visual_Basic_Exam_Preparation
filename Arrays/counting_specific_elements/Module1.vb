Imports System.Runtime.CompilerServices

Module Module1
    'Write a Visual Basic program that initializes an array with 10 integers. The program
    'should prompt the user To enter a specific Integer And Then count how many times that Integer appears
    'in the array.

    Sub Main()
        Dim initialized_array(4) As Integer
        Dim specific_integer As Integer
        Dim count As Integer = 0

        For i As Integer = 0 To 4
            Console.WriteLine("Please enter array integers:" & (i + 1) & ":")
            initialized_array(i) = Console.ReadLine()

        Next

        Console.WriteLine("Please enter specific integer:")
        specific_integer = Console.ReadLine()

        For i As Integer = 0 To 4
            If initialized_array(i) = specific_integer Then
                count += 1
            End If
        Next

        Console.WriteLine("Output counts: {0}", count)




        Console.ReadLine()
    End Sub
End Module
