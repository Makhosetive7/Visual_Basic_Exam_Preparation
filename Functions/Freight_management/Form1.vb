Public Class Form1
    Dim road_transport As Decimal = 0.15
    Dim rail_tramsport As Decimal = 0.12
    Dim ship_transport As Decimal = 0.25
    Dim air_transport As Decimal = 0.36


    Public Function basic_cost(ByVal distance As Double, ByVal weight As Double, ByVal transport_mode As Decimal) As Double
        Dim cost As Double
        cost = 1.23 * distance * weight * transport_mode
        Return cost
    End Function

    Public Function insurance(ByVal basic_cost As Double) As String
        Dim insurance_cost As Decimal = 0.11
        If CheckBox1.Checked Then
            Return basic_cost * insurance_cost
        End If
        Return 0
    End Function

    Public Function priority(ByVal basic_cost As Double) As String
        Dim priority_cost As Decimal = 0.15
        If CheckBox2.Checked Then
            Return basic_cost * priority_cost
        End If
        Return 0
    End Function

    Public Function mode_of_transport() As String
        If RadioButton1.Checked Then
            Return road_transport
        ElseIf RadioButton2.Checked Then
            Return rail_tramsport
        ElseIf RadioButton3.Checked Then
            Return air_transport
        ElseIf RadioButton4.Checked Then
            Return ship_transport
        End If
        Return 0
    End Function

    Public Function total_cost(ByVal basic_cost As Double, ByVal insurance As Decimal, ByVal priority As Decimal, ByVal mode_of_transport As String) As Double
        Dim total As Decimal
        Dim sub_total As Decimal
        Dim VAT As Decimal = 0.15

        sub_total = basic_cost + insurance + priority + mode_of_transport

        total = sub_total * VAT
        Return total
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim weight As Double = TextBox1.Text
        Dim distance As Double = TextBox2.Text



    End Sub
End Class
