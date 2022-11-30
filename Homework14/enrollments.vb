Public Class enrollments
    'will save as CSV using each indivdual class' save functions and iterate through list
    Sub SaveEnrollments(location As String)
        If m_studentCount > 0 And m_instructors.Count <> 0 And m_courses.Count <> 0 Then
            For iter As Integer = 0 To m_studentCount - 1
                m_students(iter).CSV(location)
                m_instructors(iter).CSV(location)
                m_courses(iter).CSV(location)
            Next
        Else
            MessageBox.Show("Was not able to save because 1 or more lists were empty.")
        End If
    End Sub
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Function getStudentCount() As Integer
        Return m_studentCount
    End Function
    'I dont anyone to set m_studentCount directly.  I only want it increased when called by addStudent Function
    Private Sub setStudentCount()
        m_studentCount += 1
    End Sub
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'returns whole list of courses
    Function Courses() As List(Of course)
        Return m_courses
    End Function
    'returns a course at specified index
    Function Courses(index As Integer) As course
        Return m_courses(index)
    End Function
    'sets a course at the end of list
    Sub Courses(cour As course)
        m_courses.Add(cour)
    End Sub
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'return list of students
    Function Students() As List(Of student)
        Return m_students
    End Function
    'returns a student at specified index
    Function Students(index As Integer) As student
        Return m_students(index)
    End Function
    'sets student at end of list
    Sub Students(stu As student)
        m_students.Add(stu)
        setStudentCount() 'increments m_studentCount
    End Sub
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'returns list of  instructors
    Function Instructors() As List(Of Instructor)
        Return m_instructors
    End Function
    'returns an instructor at specified index
    Function Instructors(index As Integer) As Instructor
        Return m_instructors(index)
    End Function
    'sets instructor at end of list
    Sub Instructors(inst As Instructor)
        m_instructors.Add(inst)
    End Sub
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Private m_courses As New List(Of course)
    Private m_students As New List(Of student)
    Private m_instructors As New List(Of Instructor)
    Private m_studentCount As Integer = 0 'will start at zero then increment everytimes a stuiident is added
End Class
