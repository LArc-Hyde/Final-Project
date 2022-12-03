Public Class addCourse
    Private Sub addCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If main.enroll.InstructorCount = 0 Then 'force closes form if Instructors have not been created
            MessageBox.Show("Cannot Create a Course when no Instructors have been created.  Please create or load in Instructors")
            Creator.Show()
            Me.Close()
        Else
            For iter As Integer = 0 To main.enroll.InstructorCount - 1 'populates combo box with instructors
                ComboBox1.Items.Add(main.enroll.Instructors(iter).FirstName & " " & main.enroll.Instructors(iter).LastName)
            Next
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'making sure everything is filled and valid
        If txtCourseName.Text = "" Or txtCourseNum.Text = "" Or IsNumeric(txtCourseNum.Text) = False Or
                txtRoomNum.Text = "" Or IsNumeric(txtRoomNum.Text) = False Or txtUnits.Text = "" Or
                IsNumeric(txtUnits.Text) = False Then
            MessageBox.Show("All Fields must be filled and of the correct type.")
        Else
            'assigning a course
            Dim cour As New course
            cour.CourseNumber() = txtCourseNum.Text 'must be unique
            cour.RoomNumber() = txtRoomNum.Text
            cour.CourseName() = txtCourseName.Text
            cour.Units() = txtUnits.Text
            cour.Professor() = ComboBox1.SelectedText
            main.enroll.Courses(cour) 'adding a course to enroll
            MessageBox.Show("Course " & cour.CourseName & " " & cour.CourseNumber & " has been saved.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'Back button
        Creator.Count() 'Updates if new Students are added
        Creator.Show() 'gets back to main form without saving any data
        Me.Close()
    End Sub
End Class