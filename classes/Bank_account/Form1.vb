Imports System.ComponentModel.DataAnnotations
Imports System.Security.Cryptography.Pkcs

Public Class Form1

    Public Class rectangle
        Public length As Integer
        Public width As Integer

        Public Sub New(length As Integer, width As Integer)
            length = Me.length
            width = Me.width
        End Sub

        Public Function calculate_perimeter() As String
            Return (2 * length) + (2 * width)
        End Function

        Public Function calculate_area() As String
            Return length * width
        End Function
    End Class

    ' Button to calculate perimeter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim length As Integer
        Dim width As Integer

        ' Convert textbox values to integers
        If Integer.TryParse(TextBox1.Text, length) AndAlso Integer.TryParse(TextBox2.Text, width) Then
            Dim newRectangle As New rectangle(length, width)
            Dim perimeter As Integer = newRectangle.calculate_perimeter()
            MessageBox.Show("Perimeter: " & perimeter.ToString())
        Else
            MessageBox.Show("Please enter valid integer values for length and width.")
        End If
    End Sub

    'button to calculate area
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim length As Integer
        Dim width As Integer

        ' Convert textbox values to integers
        If Integer.TryParse(TextBox1.Text, length) AndAlso Integer.TryParse(TextBox2.Text, width) Then
            Dim newRectangle As New rectangle(length, width)
            Dim area As Integer = newRectangle.calculate_area()
            MessageBox.Show("Area: " & area.ToString())
        Else
            MessageBox.Show("Please enter valid integer values for length and width.")
        End If
    End Sub
End Class
