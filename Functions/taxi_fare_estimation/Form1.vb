Public Class Form1
    'A taxi service charges:
    '---o $1.25 per km for daytime rides
    '---o $1.75 per km for nighttime rides
    'Extra services include:
    '--- $3 for a baby seat
    '--- $2 per bag of luggage
    'Design a form that allows the user To input distance, Select time Of day, And add extras,
    'then calculate And display the total fare. Include a 5% tip option.

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim distance As Integer = TextBox1.Text

        Dim taxi_charges As Double = calculate_taxi_charges(distance)
        Dim extra_charges As Boolean = calculate_extra_charges()

        Dim total_cost As Double = taxi_charges * extra_charges
        total_cost = ApplyTip(total_cost)
        MessageBox.Show("Total Fare: $" & total_cost.ToString("F2"))
    End Sub

    Function calculate_taxi_charges(distance As Integer) As String
        Dim taxi_fee As Integer

        If RadioButton1.Checked Then
            taxi_fee = 1.25
        ElseIf RadioButton2.Checked Then
            taxi_fee = 1.75
        End If
        Return taxi_fee * distance
    End Function

    Function calculate_extra_charges() As String
        Dim extra As Integer

        If RadioButton3.Checked Then
            extra = 3.0
        ElseIf RadioButton4.checked Then
            extra = 2.0
        Else
            extra = 0
        End If
        Return extra
    End Function

    Function ApplyTip(fare As Double) As Double
        If RadioButton5.Checked Then
            Return fare * 1.05
        Else
            Return fare
        End If
    End Function


End Class
