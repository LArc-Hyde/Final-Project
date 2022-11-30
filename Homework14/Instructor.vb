Public Class Instructor
    Inherits Person
    Public Property OfficeNumber() As Integer
    Public Sub CSV(location As String)
        Dim save As System.IO.StreamWriter
        save = My.Computer.FileSystem.OpenTextFileWriter(location & "instructor.csv", True)
        save.WriteLine(FirstName & "," & LastName & "," & Email & "," & OfficeNumber)
        save.Close()
        MessageBox.Show("Instructor " & FirstName & " " & LastName & " has been saved.")
    End Sub
End Class
