Imports System.Runtime.CompilerServices

Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim width As Double = TextBox1.Text
        Dim length As Double = TextBox2.Text
        Dim height As Double = TextBox3.Text
        Dim volume As Double


        volume = width * length * height

        TextBox4.Text = volume

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
End Class
