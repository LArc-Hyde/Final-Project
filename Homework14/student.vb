﻿Public Class student
    Inherits Person
    Public Property StudentNumber() As Integer
    Public Sub CSV(location As String)
        Dim save As System.IO.StreamWriter
        save = My.Computer.FileSystem.OpenTextFileWriter(location & "_student.csv", True)
        save.WriteLine(FirstName & "," & LastName & "," & Email & "," & StudentNumber)
        save.Close()
        MessageBox.Show("Student " & FirstName & " " & LastName & " has been saved.")
    End Sub
    Private m_count As Integer
End Class
