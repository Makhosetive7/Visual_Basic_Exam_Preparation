Module Module1
    Public Class RectangleArea
        Dim length As Integer
        Dim width As Integer

        Public Sub New(ByVal length As Integer, ByVal width As Integer)
            Me.length = length
            Me.width = width
        End Sub

        Public Function CalculateArea() As Integer
            Dim area As Integer
            area = length * width
            Return area
        End Function
    End Class

    Sub Main()
        Console.WriteLine("Please enter rectangle Length: ")
        Dim length As Integer = Integer.Parse(Console.ReadLine())

        Console.WriteLine("Please enter rectangle Width: ")
        Dim width As Integer = Integer.Parse(Console.ReadLine())

        Dim newArea As New RectangleArea(length, width)
        Dim area As Integer = newArea.CalculateArea()

        Console.WriteLine("The area of the rectangle is: {0}", area)
        Console.ReadKey()
    End Sub
End Module
