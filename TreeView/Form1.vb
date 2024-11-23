Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Football Leagues"

        Dim football_leagues As TreeNode = TreeView1.Nodes.Add("Football leagues")

        ' Adding African continent leagues
        Dim African_continent As TreeNode = football_leagues.Nodes.Add("African Continent")
        Dim south_African_league As TreeNode = African_continent.Nodes.Add("South African League")

        south_African_league.Nodes.Add("Mamelodi Sundowns")
        south_African_league.Nodes.Add("Orlando Pirates")
        south_African_league.Nodes.Add("Kaizer Chiefs")

        Dim zimbabwean_league As TreeNode = African_continent.Nodes.Add("Zimbabwean league")

        zimbabwean_league.Nodes.Add("Highlanders")
        zimbabwean_league.Nodes.Add("Arenel Movers")
        zimbabwean_league.Nodes.Add("Bulawayo Chiefs")

        Dim European_continent As TreeNode = football_leagues.Nodes.Add("European Continent")

        European_continent.Nodes.Add("English Premier League")
        European_continent.Nodes.Add("La Liga")


        Dim Asian_continent As TreeNode = football_leagues.Nodes.Add("Asian Continent")
        Asian_continent.Nodes.Add("J1 League")
        Asian_continent.Nodes.Add("Chinese Super League")
    End Sub
End Class
