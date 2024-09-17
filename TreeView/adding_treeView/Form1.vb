Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Tree view adding"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim treeView_node As TreeNode = TreeView1.Nodes.Add("Fruits")

        treeView_node.Nodes.Add("apple")
        treeView_node.Nodes.Add("orange")

        Dim banana_node As TreeNode = treeView_node.Nodes.Add("banana")
        banana_node.Nodes.Add("yellow banana")
        banana_node.Nodes.Add("green banana")
        banana_node.Nodes.Add("red banana")

        Dim mangoe_node As TreeNode = treeView_node.Nodes.Add("mangoe")
        mangoe_node.Nodes.Add("green mangoe")
        mangoe_node.Nodes.Add("parafin mangoe")
    End Sub
End Class
