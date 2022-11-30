Public Class course
    Public Property CourseNumber() As Integer
    Public Property CourseName() As String
    Public Property Units() As Integer
    Public Property RoomNumber() As Integer
    Public Property Professor() As New Instructor
    Public Sub CSV(location As String)
        Dim save As System.IO.StreamWriter
        save = My.Computer.FileSystem.OpenTextFileWriter(location & "_course.csv", True)
        save.WriteLine(CourseNumber & "," & CourseName & "," & Units & "," & RoomNumber)
        save.Close()
        MessageBox.Show("Course: " & CourseName & ": " & CourseNumber & " has been saved.")
    End Sub
    Function StudentCount() 'returns student count
        Return m_Students.Count
    End Function
    Private Sub Student(Stu As student) 'if course has less that 20 students
        If m_Students.Count < 20 Then
            m_Students.Add(Stu) 'then adds students
        Else 'else you get the message
            MessageBox.Show("Cannot add more students. Max Course size has been reached.")
        End If
    End Sub

    Private m_Students As New List(Of student) 'max of 20
End Class
