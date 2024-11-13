Public Class Form1
    ' Create a Windows Forms application where the user inputs employee details 
    ' (EmployeeID, Name, Position, Salary) in text boxes. Store this data in an Employee 
    ' structure and display the information in labels when the user clicks a button.

    Public Structure Employee
        Dim employee_Id As Double
        Dim employee_Name As String
        Dim employee_Position As String
        Dim employee_Salary As String
    End Structure

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim employee_data As Employee

        employee_data.employee_Id = CDbl(TextBox1.Text)
        employee_data.employee_Name = TextBox2.Text
        employee_data.employee_Position = TextBox3.Text
        employee_data.employee_Salary = TextBox4.Text

        Label5.Text = "Employee ID: " & employee_data.employee_Id
        Label6.Text = "Name: " & employee_data.employee_Name
        Label7.Text = "Position: " & employee_data.employee_Position
        Label8.Text = "Salary: " & employee_data.employee_Salary
    End Sub
End Class
