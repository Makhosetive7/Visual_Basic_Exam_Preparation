Imports System.IO

Public Class Form1
    'Build an application where users enter patient details (PatientID, Name, Age, Diagnosis) stored In
    'a Patient Structure. Save Each patient's record to a text file when the user clicks a button, and
    'confirm success In a MessageBox.

    Public Structure patient_details
        Public patient_id As Double
        Public patient_name As String
        Public patient_Age As Integer
        Public patient_diagnosis As String
    End Structure
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim patient As patient_details = New patient_details()

        patient.patient_id = TextBox1.Text
        patient.patient_name = TextBox2.Text
        patient.patient_Age = TextBox3.Text
        patient.patient_diagnosis = TextBox4.Text


        Dim patient_file As String = "C:\Users\USER\Desktop\Desktop\Code\Visual_Basic_local_storage\structure\patient_records_windows_form\patient_records.txt"

        If File.Exists(patient_file) Then
            Using sw As StreamWriter = New StreamWriter(patient_file, append:=True)
                sw.WriteLine("Patient Id: {0}" & Environment.NewLine &
                             "Patient name: {1}" & Environment.NewLine &
                             "Patient Age: {2}" & Environment.NewLine &
                             "Patient diagnosis: {3}",
                             patient.patient_id, patient.patient_name, patient.patient_Age, patient.patient_diagnosis)
                MessageBox.Show("Patient details have been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Else
            MessageBox.Show("Failed to save Patient deatils", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If











    End Sub
End Class
