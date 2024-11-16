Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "student_enrollment_treeview"


        Dim information_tech_student_names As TreeNode = TreeView2.Nodes.Add("information_technology_students")

        information_tech_student_names.Nodes.Add("Makhosetive Sibanda")
        information_tech_student_names.Nodes.Add("Laurren Dlodlo_Ncube")

        Dim food_science_student_names As TreeNode = information_tech_student_names.Nodes.Add("food_scieence_students")

        food_science_student_names.Nodes.Add("Phathutshedzo Ndou")
        food_science_student_names.Nodes.Add("Acquila Guyo")

        Dim lab_science_student_names As TreeNode = food_science_student_names.Nodes.Add("lab_science_student_names")

        lab_science_student_names.Nodes.Add("Mavel Musundire")
        lab_science_student_names.Nodes.Add("Jerald Beya")
    End Sub


End Class
