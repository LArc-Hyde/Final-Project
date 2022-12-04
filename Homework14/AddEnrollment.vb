Public Class AddEnrollment
    Private Sub AddEnrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If main.enroll.getStudentCount = 0 Or main.enroll.InstructorCount = 0 Or
                main.enroll.CourseCount = 0 Then
            MessageBox.Show("Students, Instructors, and Courses must all be created before moving to this page.")
            Creator.Show()
            Me.Close() ' forces closes if any list is empty
        Else
            For iter As Integer = 0 To main.enroll.CourseCount - 1 'populates combo box with Courses
                ComboBox1.Items.Add(main.enroll.Courses(iter).CourseName & " " & main.enroll.Courses(iter).CourseNumber)
            Next
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'clears list boxes for next selection
        lstNotEnrolled.Items.Clear()
        lstEnrolled.Items.Clear()
        txtSeats.Clear()

        Dim courseNum() As String = Split(ComboBox1.SelectedItem.ToString) 'course number will be stored in courseNum(1)
        Dim hits As New List(Of Integer) 'will use this to save Student Numbers and populate list box of students not enrolled in course
        Seats() 'changing txtSeats to selected

        If main.enroll.EnrollmentCount > 0 Then 'if it is not empty then will make search for students enrolled
            For iter As Integer = 0 To main.enroll.EnrollmentCount - 1
                If CInt(courseNum(1)) = main.enroll.GetEnroll(iter).Courses(0).CourseNumber Then 'adds Full name and Student Number to enrolled list box
                    lstEnrolled.Items.Add(main.enroll.GetEnroll(iter).Students(0).FirstName & " " &
                        main.enroll.GetEnroll(iter).Students(0).LastName & " " &
                        main.enroll.GetEnroll(iter).Students(0).StudentNumber)
                    hits.Add(main.enroll.GetEnroll(iter).Students(0).StudentNumber) 'matches addded to hits
                End If
            Next
        Else
            For iterEmpty As Integer = 0 To main.enroll.getStudentCount - 1
                lstNotEnrolled.Items.Add(main.enroll.Students(iterEmpty).FirstName & " " &
                        main.enroll.Students(iterEmpty).LastName & " " &
                        main.enroll.Students(iterEmpty).StudentNumber)
            Next
        End If

        Dim isHit As Boolean 'if false will add Student to listbox of nonenrolled students; if true then will not get added

        If hits.Count > 0 Then
            For iter1 As Integer = 0 To main.enroll.getStudentCount - 1
                isHit = False 'must be reset for every student
                For iter2 As Integer = 0 To hits.Count - 1
                    If hits(iter2) = main.enroll.Students(iter1).StudentNumber Then
                        isHit = True
                    End If
                Next
                If isHit = False Then 'if no matched found will add to listbox
                    lstNotEnrolled.Items.Add(main.enroll.Students(iter1).FirstName & " " &
                                             main.enroll.Students(iter1).LastName & " " &
                                             main.enroll.Students(iter1).StudentNumber)
                End If
            Next
        End If
    End Sub

    'checks Course Number of currently selected Course and retrieves and sets the avaible seats
    Private Sub Seats()
        Dim courseNum() As String = Split(ComboBox1.SelectedItem.ToString)
        Dim seatNum As Integer
        For iter As Integer = 0 To main.enroll.CourseCount - 1
            If (CInt(courseNum(1)) = main.enroll.Courses(iter).CourseNumber) Then
                seatNum = main.enroll.Courses(iter).SeatsOpen
            End If
        Next
        txtSeats.Text = CStr(seatNum)
    End Sub

    'moves text from left to right.  Create Enrollments actually applies changes
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If lstNotEnrolled.SelectedItem.ToString = "" Then
            MessageBox.Show("Must Add a non-empty value")
        Else
            Dim data As String = lstNotEnrolled.SelectedItem.ToString
            lstEnrolled.Items.Add(data)
        lstNotEnrolled.Items.Remove(lstNotEnrolled.Text) 'removes from list
        End If
    End Sub

    'goes back to creator without saving
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Creator.Show()
        Me.Close()
    End Sub

    'adds enrollments to our enrollment instance
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim StudentIndex As Integer, InstructorIndex As Integer, CourseIndex As Integer

        If lstEnrolled.Items.Count <> 0 Then
            For iterList As Integer = 0 To lstEnrolled.Items.Count - 1
                Dim StudentNum() As String = Split(lstEnrolled.Items.Item(iterList)) 'studentnum(2) contains the student number
                For iterStudent As Integer = 0 To main.enroll.getStudentCount - 1
                    If CInt(StudentNum(2)) = main.enroll.Students(iterStudent).StudentNumber Then
                        StudentIndex = iterStudent 'location of matching student
                    End If
                Next
                For iterCourse As Integer = 0 To main.enroll.CourseCount - 1
                    Dim CourseNum() As String = Split(ComboBox1.SelectedItem.ToString) 'CourseNum(1) holds course num
                    If CInt(CourseNum(1)) = main.enroll.Courses(iterCourse).CourseNumber Then
                        CourseIndex = iterCourse 'location of matching course
                    End If
                Next
                For iterInstructor As Integer = 0 To main.enroll.InstructorCount - 1
                    Dim names() As String = Split(main.enroll.Courses(CourseIndex).Professor) 'name(0) firstname | name(1) lastname
                    If names(0) = main.enroll.Instructors(iterInstructor).FirstName And
                    names(1) = main.enroll.Instructors(iterInstructor).LastName Then
                        InstructorIndex = iterInstructor 'location of matching instructor
                    End If
                Next
                'saving enrollment and reducing available seats
                main.enroll.Courses(CourseIndex).FillSeat()
                txtSeats.Text = main.enroll.Courses(CourseIndex).SeatsOpen()
                main.enroll.AddEnroll(main.enroll.Students(StudentIndex), main.enroll.Instructors(InstructorIndex), main.enroll.Courses(CourseIndex))
            Next
        Else
            MessageBox.Show("The Students Enrolled Box must have at least one student to create an enrollment.")
        End If

        'lstNotEnrolled.Items.Clear()
        'lstEnrolled.Items.Clear()
        'txtSeats.Clear()
        'ComboBox1.SelectedIndex = -1
    End Sub
End Class