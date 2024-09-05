Module Module1
    'write a visual basic console application to swap the values of
    'two variables entered by the user without using third variable
    Sub Main()
        Dim first_variable As Integer
        Dim second_variable As Integer

        Console.WriteLine("please enter first variable")
        first_variable = Console.ReadLine()

        Console.WriteLine("please enter second variable")
        second_variable = Console.ReadLine()

        first_variable = first_variable Xor second_variable
        second_variable = second_variable Xor first_variable
        first_variable = second_variable Xor first_variable

        Console.WriteLine("the swapped variables without using third variable output as:")
        Console.WriteLine("{0} and {1}", first_variable, second_variable)

        Console.ReadKey()



    End Sub

End Module
