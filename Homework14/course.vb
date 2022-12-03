Public Class course
    Public Property CourseNumber() As Integer
    Public Property CourseName() As String
    Public Property Units() As Integer
    Public Property RoomNumber() As Integer
    Public Sub CSV(location As String)
        Dim save As System.IO.StreamWriter
        save = My.Computer.FileSystem.OpenTextFileWriter(location & "_course.csv", True)
        save.WriteLine(CourseNumber & "," & CourseName & "," & Units & "," & RoomNumber & "," &
                       Professor() & "," & SeatsOpen())
        save.Close()
        MessageBox.Show("Course: " & CourseName & ": " & CourseNumber & " has been saved.")
    End Sub

    Function SeatsOpen() As Integer 'returns seats avaialble
        Return m_SeatsOpened
    End Function

    Sub FillSeat() 'fills a seat for a new student
        If m_SeatsOpened > 0 Then
            m_SeatsOpened -= 1
        Else
            MessageBox.Show("Cannot add more students. Max Course size has been reached.")
        End If
    End Sub

    Function Professor() As String 'Returns Professor  Full Name
        If m_Professor = "" Then
            Return "No Professor"
        End If
        Return m_Professor
    End Function

    Sub Professor(fname As String, lname As String) 'sets Professor name
        m_Professor = fname & " " & lname
    End Sub

    Sub Professor(name As String) 'sets Professor name
        m_Professor = name
    End Sub

    Function FirstProf() As String 'returns Professor First Name
        Dim name() As String = Split(m_Professor)
        Return name(0)
    End Function

    Function LastProf() As String 'returns Professor last name
        Dim name() As String = Split(m_Professor)
        Return name(1)
    End Function

    Private m_Professor As String = ""
    Private m_SeatsOpened As Integer = 20
End Class
