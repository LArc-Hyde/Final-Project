Public Class Viewer
    Public view As New List(Of EnrollmentViewHelper)
    Public views As Integer = 0
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        main.Show()
        Me.Close()
    End Sub

    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        DataGridView1.DataSource = main.enroll.Students
    End Sub

    Private Sub btnInstructors_Click(sender As Object, e As EventArgs) Handles btnInstructors.Click
        DataGridView1.DataSource = main.enroll.Instructors
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.DataSource = main.enroll.Courses
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView1.ClearSelection()
        If views > 0 Then
            For iterView As Integer = 0 To views - 1
                view.RemoveAt(view.Count - 1) 'removes at end
            Next
        End If

        For iter As Integer = 0 To main.enroll.EnrollmentCount - 1
            Dim view1 As New EnrollmentViewHelper
            view.Add(view1)
            view(iter).StudentName = main.enroll.GetEnroll(iter).Students(0).FirstName & " " & main.enroll.GetEnroll(iter).Students(0).LastName
            view(iter).StudentNumber = main.enroll.GetEnroll(iter).Students(0).StudentNumber
            view(iter).InstructorName = main.enroll.GetEnroll(iter).Instructors(0).FirstName & " " & main.enroll.GetEnroll(iter).Instructors(0).LastName
            view(iter).CourseNumber = main.enroll.GetEnroll(iter).Courses(0).CourseNumber
            view(iter).CourseName = main.enroll.GetEnroll(iter).Courses(0).CourseName
        Next
        DataGridView1.DataSource = view

        'reset for next view
        views = main.enroll.EnrollmentCount
    End Sub

    Private Sub Viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If main.enroll.EnrollmentCount = 0 Or main.enroll.getStudentCount = 0 Or
                main.enroll.InstructorCount = 0 Or main.enroll.CourseCount = 0 Then
            MessageBox.Show("Student List, Instructor List, Course List, and Enrollment List must not be empty")
            main.Show()
            Me.Close()
        End If
    End Sub
End Class