Imports System.Drawing.Printing

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Printer not connected", "Printer error...", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("File not found", "opening a file", MessageBoxButtons.OKCancel)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Are you show you want delete this file", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("System is shutting down, please continue", "System shutdown", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
    End Sub
End Class
