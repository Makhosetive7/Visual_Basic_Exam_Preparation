Imports System.Drawing.Text

Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub


    Public Class customer
        Public company As String
        Public address As String
        Public town_city As String
        Public post_code As String
        Public tel As String
        Public fax As String
        Public email As String

        Public Property company_name() As String
            Get
                Return company
            End Get
            Set(value As String)
                company = value
            End Set
        End Property

        Public Property company_address() As String
            Get
                Return address
            End Get
            Set(value As String)
                address = value
            End Set
        End Property

        Public Property company_town_city As String
            Get
                Return town_city
            End Get
            Set(value As String)
                town_city = value
            End Set
        End Property

        Public Property company_code As String
            Get
                Return post_code
            End Get
            Set(value As String)
                post_code = value
            End Set
        End Property

        Public Property company_tel As String
            Get
                Return tel
            End Get
            Set(value As String)
                tel = value
            End Set
        End Property

        Public Property company_fax As String
            Get
                Return fax
            End Get
            Set(value As String)
                fax = value
            End Set

        End Property

        Public Property company_email As String
            Get
                Return email
            End Get
            Set(value As String)
                email = value
            End Set
        End Property

    End Class

    Dim new_customer As customer = New customer

    ' Method to handle "Enter Details" button click
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        new_customer.company = TextBox2.Text
        new_customer.address = TextBox3.Text
        new_customer.town_city = TextBox4.Text
        new_customer.post_code = TextBox5.Text
        new_customer.tel = TextBox6.Text
        new_customer.fax = TextBox7.Text
        new_customer.email = TextBox8.Text
    End Sub

    ' Method to handle "Display Details" button click
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        new_customer.company = TextBox2.Text
        new_customer.address = TextBox3.Text
        new_customer.town_city = TextBox4.Text
        new_customer.post_code = TextBox5.Text
        new_customer.tel = TextBox6.Text
        new_customer.fax = TextBox7.Text
        new_customer.email = TextBox8.Text
    End Sub
End Class
