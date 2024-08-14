Module Module1
    'Write a program that accepts the coefficients 𝑎, 𝑏, And 𝑐 of a quadratic equation 𝑎𝑥2+𝑏𝑥+𝑐=0 And calculates the roots using the quadratic formula.

    Sub Main()
        Dim coeffient_A As Double
        Dim coeffient_B As Double
        Dim coeffient_C As Double

        Console.WriteLine("please enter 1st coefficient")
        coeffient_A = Console.ReadLine()

        Console.WriteLine("please enter 2nd coefficient")
        coeffient_B = Console.ReadLine()

        Console.WriteLine("please enter 3rd coefficient")
        coeffient_C = Console.ReadLine()

        Dim discriminate = (coeffient_B * coeffient_B) = (4 * coeffient_A * coeffient_C)

        If discriminate > 0 Then
            Dim root_A As Double = (-coeffient_B + Math.Sqrt(discriminate) / (2 * coeffient_A))
            Dim root_B As Double = (-coeffient_B - Math.Sqrt(discriminate) / (2 * coeffient_A))
            Console.WriteLine("the roots are distinct and real: {0} and {1}", root_A, root_B)

        ElseIf discriminate = 0 Then
            Dim root_A As Double = -coeffient_B / (2 * coeffient_A)
            Console.WriteLine("Roots are real and equal: {0}", root_A)
        Else
            Console.WriteLine("The roots are complex .")


        End If
        Console.ReadKey()
    End Sub

End Module
