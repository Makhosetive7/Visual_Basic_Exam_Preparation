Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim top_menu_bar As New MainMenu()


        Dim main_menu_item_File As New MenuItem("&File")
        Dim main_menu_item_Edit As New MenuItem("&Edit")

        top_menu_bar.MenuItems.Add(main_menu_item_File)
        top_menu_bar.MenuItems.Add(main_menu_item_Edit)

        Dim sub_menu_item_New As New MenuItem("&New")
        Dim sub_menu_item_Open As New MenuItem("&Open")
        Dim sub_menu_item_Save As New MenuItem("&Save")

        main_menu_item_File.MenuItems.Add(sub_menu_item_New)
        main_menu_item_File.MenuItems.Add(sub_menu_item_Open)
        main_menu_item_File.MenuItems.Add(sub_menu_item_Save)


        Dim sub_menu_item_copy As New MenuItem("&Copy")
        Dim sub_menu_item_cut As New MenuItem("&Cut")
        Dim sub_menu_item_paste As New MenuItem("&Paste")


        main_menu_item_Edit.MenuItems.Add(sub_menu_item_copy)
        main_menu_item_Edit.MenuItems.Add(sub_menu_item_cut)
        main_menu_item_Edit.MenuItems.Add(sub_menu_item_paste)

        Me.Menu = top_menu_bar
    End Sub
End Class
