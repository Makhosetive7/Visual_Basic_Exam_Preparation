Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "car_treeview"

        Dim Toyota_cars As TreeNode = TreeView1.Nodes.Add("Toyota_car_treeview")

        Toyota_cars.Nodes.Add("Toyota Corolla")
        Toyota_cars.Nodes.Add("Toyota Camry")
        Toyota_cars.Nodes.Add("Toyota Rav4")

        Dim Mazda_cars As TreeNode = Toyota_cars.Nodes.Add("Mazda_car_treeview")

        Mazda_cars.Nodes.Add("Mazda 323")
        Mazda_cars.Nodes.Add("Mazda 625")
        Mazda_cars.Nodes.Add("Mazda RX-7")

        Dim volkswagon_cars As TreeNode = Mazda_cars.Nodes.Add("VW_cars_treeview")

        volkswagon_cars.Nodes.Add("VW_Citi")
        volkswagon_cars.Nodes.Add("VW_Golf_7")
        volkswagon_cars.Nodes.Add("VW_Polo")

    End Sub
End Class
