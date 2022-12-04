Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class enrollments
    'will save as CSV using each indivdual class' save functions and iterate through list
    Sub SaveData(location As String)
        If m_studentCount > 0 Then
            For iterST As Integer = 0 To m_students.Count - 1
                m_students(iterST).CSV(location)
            Next
        End If
        If m_instructors.Count <> 0 Then
            For iterIN As Integer = 0 To m_instructors.Count - 1
                m_instructors(iterIN).CSV(location)
            Next
        End If
        If m_courses.Count <> 0 Then
            For iterCO As Integer = 0 To m_courses.Count - 1
                m_courses(iterCO).CSV(location)
            Next
        End If
        If m_enrollments.Count <> 0 Then
            For iterEn As Integer = 0 To m_enrollments.Count - 1
                CSV(location, iterEn)
            Next
        End If
    End Sub
    Sub CSV(location As String, iter As Integer)
        Dim save As System.IO.StreamWriter
        save = My.Computer.FileSystem.OpenTextFileWriter(location & "_enrollments.csv", True)
        'Saves the student part of enrollment in 1 line
        save.WriteLine(m_enrollments(iter).Students(0).FirstName & "," &
            m_enrollments(iter).Students(0).LastName & "," &
            m_enrollments(iter).Students(0).Email & "," &
            m_enrollments(iter).Students(0).StudentNumber)
        'saves the instructor part of enrollment 
        save.WriteLine(m_enrollments(iter).Instructors(0).FirstName & "," &
            m_enrollments(iter).Instructors(0).LastName & "," &
            m_enrollments(iter).Instructors(0).Email & "," &
            m_enrollments(iter).Instructors(0).OfficeNumber)
        'saves course part
        save.WriteLine(m_enrollments(iter).Courses(0).CourseNumber & "," &
                       m_enrollments(iter).Courses(0).CourseName & "," &
                       m_enrollments(iter).Courses(0).Units & "," &
                       m_enrollments(iter).Courses(0).RoomNumber & "," &
                       m_enrollments(iter).Courses(0).Professor() & "," &
                       m_enrollments(iter).Courses(0).SeatsOpen())
        save.Close()
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

    Function InstructorCount()
        Return m_instructors.Count()
    End Function

    Function CourseCount() As Integer
        Return m_courses.Count()
    End Function

    Function EnrollmentCount() As Integer
        Return m_enrollments.Count()
    End Function
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
        If m_courses.Count = 0 Then
            m_courses.Add(cour)
            MessageBox.Show("Course " & cour.CourseName & " " & cour.CourseNumber & " has been saved.")
        Else
            Dim duplicate As Boolean = False 'checks whether duplicate is found
            For iter = 0 To m_courses.Count - 1
                If cour.CourseNumber = m_courses(iter).CourseNumber Then
                    duplicate = True
                End If
            Next
            If duplicate = False Then
                m_courses.Add(cour)
                MessageBox.Show("Course " & cour.CourseName & " " & cour.CourseNumber & " has been saved.")
            Else
                MessageBox.Show("Course: " & cour.CourseNumber & " has already been added.")
            End If
        End If
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
        If m_studentCount = 0 Then 'if list empty add student
            m_students.Add(stu)
            setStudentCount() 'increments m_studentCount
            MessageBox.Show("Student " & stu.FirstName & " " & stu.LastName & " " & stu.StudentNumber & " has been added")
        Else 'If Student list is not empty will search list for duplicate student num. (STUDENT NUMBER MUST BE UNIQUE)
            Dim duplicate As Boolean = False
            For iter = 0 To m_students.Count - 1
                If m_students(iter).StudentNumber = stu.StudentNumber Then 'if duplicate is found then will not add
                    duplicate = True 'duplicate found and marked
                End If
            Next
            If duplicate = False Then
                m_students.Add(stu)
                setStudentCount() 'increments m_studentCount
                MessageBox.Show("Student " & stu.FirstName & " " & stu.LastName & " " & stu.StudentNumber & " has been added")
            Else
                MessageBox.Show("Student: " & stu.StudentNumber & " has already been added.") 'will not be added
            End If
        End If
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
    Public Sub AddEnroll(s As student, i As Instructor, c As course)
        Dim e As New enrollments
        e.Students.Add(s)
        e.Instructors.Add(i)
        e.Courses.Add(c)
        m_enrollments.Add(e) 'once the user assigns an enrollment the class can save itself
    End Sub
    'returns enrollment at specified index
    Function GetEnroll(index As Integer) As enrollments
        Return m_enrollments(index)
    End Function
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'These 3 hold all selectable students, instructors and courses
    Private m_courses As New List(Of course)
    Private m_students As New List(Of student)
    Private m_instructors As New List(Of Instructor)

    Private m_enrollments As New List(Of enrollments) 'saves each individual enrollment

    Private m_studentCount As Integer = 0 'will start at zero then increment everytimes a student is added
End Class
