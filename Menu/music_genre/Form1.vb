Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Music Genre"
        Dim music_genre_ As New MainMenu
        Me.Menu = music_genre_

        Dim rnb_music_genre As New MenuItem("RNB Music")
        Dim kwaito_music_genre As New MenuItem("Kwaito Music")
        Dim gospel_music_genre As New MenuItem("Gospel Music")

        music_genre_.MenuItems.Add(rnb_music_genre)
        music_genre_.MenuItems.Add(kwaito_music_genre)
        music_genre_.MenuItems.Add(gospel_music_genre)

        Dim rnb_music_singers As New MenuItem("Akon")
        Dim kwaito_music_singers As New MenuItem("Zola 7")
        Dim gospel_music_singers As New MenuItem("Winnie Mashaba")

        rnb_music_genre.MenuItems.Add(rnb_music_singers)
        kwaito_music_genre.MenuItems.Add(kwaito_music_singers)
        gospel_music_genre.MenuItems.Add(gospel_music_singers)

        Dim rnb_songs_lonely As New MenuItem("lonely")
        Dim rnb_songs_smack_that As New MenuItem("Smack that")
        Dim rnb_songs_beautiful As New MenuItem("Beautifull")


        rnb_music_singers.MenuItems.Add(rnb_songs_lonely)
        rnb_music_singers.MenuItems.Add(rnb_songs_smack_that)
        rnb_music_singers.MenuItems.Add(rnb_songs_beautiful)




    End Sub
End Class
