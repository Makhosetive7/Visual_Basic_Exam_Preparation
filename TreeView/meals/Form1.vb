Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim African_food_recipe As TreeNode = TreeView1.Nodes.Add("African Meals")

        African_food_recipe.Nodes.Add("Jollof rice")
        African_food_recipe.Nodes.Add("Bunny chow")
        African_food_recipe.Nodes.Add("Umxhanxa")

        Dim mexican_food_recipe As TreeNode = African_food_recipe.Nodes.Add("Mexican Meals")

        mexican_food_recipe.Nodes.Add("Tacos")
        mexican_food_recipe.Nodes.Add("Enchiladas")
        mexican_food_recipe.Nodes.Add("Guacamole")


        Dim italian_food_recipe As TreeNode = mexican_food_recipe.Nodes.Add("Italian Meals")

        italian_food_recipe.Nodes.Add("Spaghetti Carbonara")
        italian_food_recipe.Nodes.Add("Tiramisu")
    End Sub
End Class
