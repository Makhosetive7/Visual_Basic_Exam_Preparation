Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Shopping cart"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim shopping_cart_total As Decimal

        If CheckBox1.Checked Then
            shopping_cart_total += 12
        End If
        If CheckBox2.Checked Then
            shopping_cart_total += 25
        End If
        If CheckBox3.Checked Then
            shopping_cart_total += 55
        End If
        If CheckBox4.Checked Then
            shopping_cart_total += 3.5
        End If
        If CheckBox5.Checked Then
            shopping_cart_total += 5
        End If
        If CheckBox6.Checked Then
            shopping_cart_total += 95
        End If

        Label1.Text = "Total: $" & shopping_cart_total.ToString("0.00")
    End Sub
End Class
