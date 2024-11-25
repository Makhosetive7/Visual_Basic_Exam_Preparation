Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Progressbar and Timer"


        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 23

        ProgressBar2.Minimum = 0
        ProgressBar2.Maximum = 59

        ProgressBar3.Minimum = 0
        ProgressBar3.Maximum = 59

        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Value = Date.Now.Hour
        ProgressBar2.Value = Date.Now.Minute
        ProgressBar3.Value = Date.Now.Second

        Label4.Text = Date.Now.Hour
        Label5.Text = Date.Now.Minute
        Label6.Text = Date.Now.Second
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


End Class
