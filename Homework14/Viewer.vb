Public Class Viewer
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
        DataGridView1.DataSource = main.enroll.AllEnrollments
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