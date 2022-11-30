Public Class course
    Public Property CourseNumber() As Integer
    Public Property CourseName() As String
    Public Property Units() As Integer
    Public Property RoomNumber() As Integer
    Public Sub CSV(location As String)
        Dim save As System.IO.StreamWriter
        save = My.Computer.FileSystem.OpenTextFileWriter(location & "course.csv", True)
        save.WriteLine(CourseNumber & "," & CourseName & "," & Units & "," & RoomNumber)
        save.Close()
        MessageBox.Show("Course: " & CourseName & ": " & CourseNumber & " has been saved.")
    End Sub
End Class
