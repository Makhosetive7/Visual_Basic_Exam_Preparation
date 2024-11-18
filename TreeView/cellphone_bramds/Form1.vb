Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "cellphone_brands_treeview"


        Dim nokia_Brands As TreeNode = TreeView1.Nodes.Add("nokia_Brands_treeView")

        nokia_Brands.Nodes.Add("Nokia Lumia")
        nokia_Brands.Nodes.Add("Nokia C2")
        nokia_Brands.Nodes.Add("Nokia Alphine")

        Dim sumsung_Brands As TreeNode = nokia_Brands.Nodes.Add("sumsung_Brands_treeview")

        sumsung_Brands.Nodes.Add("Sumsung S10")
        sumsung_Brands.Nodes.Add("Sumsung A05")
        sumsung_Brands.Nodes.Add("sumsung b16")

        Dim huawai_Brands As TreeNode = sumsung_Brands.Nodes.Add("huawai_Brands_treeview")

        huawai_Brands.Nodes.Add("Huawai Y3")
        huawai_Brands.Nodes.Add("Huawai Flimo")
        huawai_Brands.Nodes.Add("Huawai Proband")









    End Sub
End Class
