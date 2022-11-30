Public Class student
    Inherits Person
    Public Property StudentNumber() As Integer
    Public Sub CSV(location As String)
        Dim save As System.IO.StreamWriter
        save = My.Computer.FileSystem.OpenTextFileWriter(location & "student.csv", True)
        save.WriteLine(FirstName & "," & LastName & "," & Email & "," & StudentNumber)
        save.Close()
        MessageBox.Show("Student " & FirstName & " " & LastName & " has been saved.")
    End Sub
    'might have to have a counter to for a student to have multiple courses
End Class
