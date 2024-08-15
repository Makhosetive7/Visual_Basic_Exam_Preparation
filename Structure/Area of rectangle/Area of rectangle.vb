Module Module1

    'Create a structure named Rectangle with two fields: Width (Double) and 
    'Height (Double). Write a method within the Rectangle structure called CalculateArea
    'that returns the area Of the rectangle As a Double.

    Public Structure Rectangle
        Dim width As Double
        Dim height As Double

        Public Function CalculateArea() As Double
            Return width * height
        End Function

    End Structure
    Sub Main()
        Dim new_Rectange As Rectangle = New Rectangle()

        Console.WriteLine("Please enter Width of rectangle")
        new_Rectange.width = Console.ReadLine()

        Console.WriteLine("Please enter height of rectangle")
        new_Rectange.height = Console.ReadLine()

        Dim Area As Double = new_Rectange.CalculateArea()

        Console.WriteLine("Rectangle dimensions: {0} x {1}", new_Rectange.width, new_Rectange.height)
        Console.WriteLine("Area of the rectangle: {0:F2} square units", Area)


        Console.ReadLine()


    End Sub

End Module
