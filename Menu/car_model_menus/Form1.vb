Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim car_main_menu As New MainMenu()

        Dim _Toyota_main_menu As New MenuItem("&Toyota")
        Dim _Mazda_main_menu As New MenuItem("&Mazda")
        Dim _Honda_main_menu As New MenuItem("&Honda")

        car_main_menu.MenuItems.Add(_Toyota_main_menu)
        car_main_menu.MenuItems.Add(_Mazda_main_menu)
        car_main_menu.MenuItems.Add(_Honda_main_menu)

        Dim _toyota_corolla_sub_menu As New MenuItem("&Toyota Corolla")
        Dim _toyota_Avansa_sub_menu As New MenuItem("&Toyota Avansa")
        Dim _toyota_323_sub_menu As New MenuItem("Toyota 323")

        _Toyota_main_menu.MenuItems.Add(_toyota_corolla_sub_menu)
        _Toyota_main_menu.MenuItems.Add(_toyota_Avansa_sub_menu)
        _Toyota_main_menu.MenuItems.Add(_toyota_323_sub_menu)

        Dim _mazda_BT_50_sub_menu As New MenuItem("&Mazda BT-50")
        Dim _mazda_626_sub_menu As New MenuItem("&Mazda 626")
        Dim _mazda_RX_7_sub_menu As New MenuItem("&Mazda RX-7")

        _Mazda_main_menu.MenuItems.Add(_mazda_BT_50_sub_menu)
        _Mazda_main_menu.MenuItems.Add(_mazda_626_sub_menu)
        _Mazda_main_menu.MenuItems.Add(_mazda_RX_7_sub_menu)

        Dim _mazda_sub_sub_menu As New MenuItem("&1234")

        _mazda_626_sub_menu.MenuItems.Add(_mazda_sub_sub_menu)











        Me.Menu = car_main_menu
    End Sub
End Class
