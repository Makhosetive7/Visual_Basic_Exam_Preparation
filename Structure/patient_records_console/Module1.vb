Imports System.IO

Module Module1
    'Build an application where users enter patient details (PatientID, Name, Age, Diagnosis) stored in
    'a Patient Structure. Save Each patient's record to a text file when the user clicks a button, and
    'confirm success In a MessageBox.

    Public Structure Patient_details
        Public patient_Id As Double
        Public patient_Name As String
        Public patient_Age As Integer
        Public patient_diagnosis As String
    End Structure

    Sub Main()
        Dim patient As Patient_details = New Patient_details()

        Console.WriteLine("Please enter patient Id: ")
        patient.patient_Id = Console.ReadLine()

        Console.WriteLine("Please enter patient Name: ")
        patient.patient_Name = Console.ReadLine()

        Console.WriteLine("Please enter patient Age: ")
        patient.patient_Age = Console.ReadLine()

        Console.WriteLine("Please enter patient Diagnosis: ")
        patient.patient_diagnosis = Console.ReadLine()

        Console.WriteLine("The patient Id: {0}" & Environment.NewLine &
                          "The patient name is: {1}" & Environment.NewLine &
                          "The patient Age is: {2}" & Environment.NewLine &
                          "The patient diagnosis is: {3},",
                          patient.patient_Id,
                          patient.patient_Name,
                          patient.patient_Age,
                          patient.patient_diagnosis)


        Dim patient_file As String = "C:\Users\USER\Desktop\Desktop\Code\Visual_Basic_local_storage\structure\patient_records.txt"

        Try
            Using sw As StreamWriter = New StreamWriter(patient_file, append:=True)
                sw.WriteLine("Patient ID: " & patient.patient_Id)
                sw.WriteLine("Patient Name: " & patient.patient_Name)
                sw.WriteLine("Patient Age: " & patient.patient_Age)
                sw.WriteLine("Patient Diagnosis: " & patient.patient_diagnosis)
                sw.WriteLine(New String("-"c, 50))
            End Using

            Console.WriteLine(Environment.NewLine & "Patient record saved successfully.")
        Catch ex As Exception
            Console.WriteLine("An error occurred while saving the record: " & ex.Message)
        End Try

        Console.ReadKey()


    End Sub

End Module
