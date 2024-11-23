Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "football_leagues"
        Dim football_leagues_menus As New MainMenu()
        Me.Menu = football_leagues_menus

        Dim african_continent_main_menu As New MenuItem("African Continent")
        football_leagues_menus.MenuItems.Add(african_continent_main_menu)

        african_continent_main_menu.MenuItems.Add("Zimbabwean League")

        Dim south_african_league_sub As New MenuItem("South African league")
        african_continent_main_menu.MenuItems.Add(south_african_league_sub)

        south_african_league_sub.MenuItems.Add("Mamelodi Sundowns")
        south_african_league_sub.MenuItems.Add("Orlando Pirates")



        Dim european_continent_main_menu As New MenuItem("European Continent")
        football_leagues_menus.MenuItems.Add(european_continent_main_menu)

        Dim asian_continent_main_menu As New MenuItem("Asian Continent")
        football_leagues_menus.MenuItems.Add(asian_continent_main_menu)







    End Sub
End Class
