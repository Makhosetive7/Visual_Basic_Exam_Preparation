Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim IT_course_menu As New MainMenu()
        Me.Menu = IT_course_menu

        Dim national_Certificate As New MenuItem("National Certificate")
        Dim national_diploma As New MenuItem("National Diploma")

        IT_course_menu.MenuItems.Add(national_Certificate)
        IT_course_menu.MenuItems.Add(national_diploma)

        Dim C_plus_plus As New MenuItem("C++")
        Dim C_A_S As New MenuItem("CAS")

        national_Certificate.MenuItems.Add(C_plus_plus)
        national_Certificate.MenuItems.Add(C_A_S)

        Dim visual_basic As New MenuItem("Visual basic.net")
        Dim maths_x_statistics As New MenuItem("Mathematics and statistics")

        national_diploma.MenuItems.Add(visual_basic)
        national_diploma.MenuItems.Add(maths_x_statistics)
    End Sub
End Class
