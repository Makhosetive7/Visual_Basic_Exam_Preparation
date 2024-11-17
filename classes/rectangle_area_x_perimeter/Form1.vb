Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    'Design a class Rectangle with properties Length and Width. Implement methods to calculate
    'Area() And Perimeter(). Create a Windows Form that allows users to input the length And width,
    'then displays the calculated area And perimeter when a Button Is clicked

    Public Class Rectangle_class
        Public rectangle_length As Integer
        Public rectangle_width As Integer

        Public Sub New(ByVal length As Integer, ByVal width As Integer)
            Me.rectangle_length = length
            Me.rectangle_width = width
        End Sub

        Function calculate_area_of_rectangle() As Integer
            Return rectangle_length * rectangle_width
        End Function

        Function calculate_perimeter_of_rectangle() As Integer
            Return 2 * (rectangle_length + rectangle_width)
        End Function
    End Class
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim length As Integer = TextBox1.Text
        Dim width As Integer = TextBox2.Text

        Dim rectangle_calculation As Rectangle_class = New Rectangle_class(length, Width)


        Dim area As Integer = rectangle_calculation.calculate_area_of_rectangle()
        Dim perimeter As Integer = rectangle_calculation.calculate_perimeter_of_rectangle()


        Label3.Text = area.ToString()
        Label4.Text = perimeter.ToString()



    End Sub
End Class
