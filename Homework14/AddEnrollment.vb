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

        Dim courseNum() As String = Split(ComboBox1.SelectedText) 'course number will be stored in courseNum(1)
        Dim hits As New List(Of Integer) 'will use this to save Student Numbers and populate list box of students not enrolled in course
        Seats() 'changing txtSeats to selected
        If main.enroll.EnrollmentCount <> 0 Then 'if it is not empty then will make search for students enrolled
            For iter As Integer = 0 To main.enroll.EnrollmentCount - 1
                If CInt(courseNum(1)) = main.enroll.GetEnroll(iter).Courses(0).CourseNumber Then 'adds Full name and Student Number to enrolled list box
                    lstEnrolled.Items.Add(main.enroll.GetEnroll(iter).Students(0).FirstName & " " &
                        main.enroll.GetEnroll(iter).Students(0).LastName & " " &
                        main.enroll.GetEnroll(iter).Students(0).StudentNumber)
                    hits.Add(main.enroll.GetEnroll(iter).Students(0).StudentNumber) 'matches addded to hits
                End If
            Next
        End If

        Dim isHit As Boolean 'if false will add Student to listbox of nonenrolled students; if true then will not get added

        If hits.Count <> 0 Then
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

    'checks Course Number of currently selectec Course and retrieves and sets the avaible seats
    Private Sub Seats()
        Dim courseNum() As String = Split(ComboBox1.SelectedText)
        Dim seatNum As Integer
        For iter As Integer = 0 To main.enroll.CourseCount - 1
            If (CInt(courseNum(1)) = main.enroll.Courses(iter).CourseNumber) Then
                seatNum = main.enroll.Courses(iter).SeatsOpen
            End If
        Next
        txtSeats.Text = CStr(seatNum)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Creator.Show()
        Me.Close()
    End Sub
End Class