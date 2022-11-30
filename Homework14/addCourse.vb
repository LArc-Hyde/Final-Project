Public Class addCourse
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'making sure everything is filled and valid
        If txtCourseName.Text = "" Or txtCourseNum.Text = "" Or IsNumeric(txtCourseNum.Text) = False Or
                txtRoomNum.Text = "" Or IsNumeric(txtRoomNum.Text) = False Or txtUnits.Text = "" Or
                IsNumeric(txtUnits.Text) = False Then
            MessageBox.Show("All Fields must be filled and of the correct type.")
        Else
            'assigning a course
            Dim cour As New course
            cour.CourseNumber() = txtCourseNum.Text
            cour.RoomNumber() = txtRoomNum.Text
            cour.CourseName() = txtCourseName.Text
            cour.Units() = txtUnits.Text
            main.enroll.Courses(cour) 'adding a course to enroll

            'getting main form ready for user
            main.btnAddCourse.Enabled = False 'disabling addCourse button to force user to continue desired path
            main.btnAddInstructor.Enabled = True 'next step is adding Instructor
            main.lstEnrollView.Items.RemoveAt(main.lstEnrollView.Items.Count - 1) 'removing last instruction
            main.lstEnrollView.Items.Add("Course: " & cour.CourseName & " " & cour.CourseNumber) 'showing Course was added
            main.lstEnrollView.Items.Add("Must Add Instructor Next") 'Displaying next instruction

            'getting back to main form
            main.Show()
            Me.Close()
        End If
    End Sub
End Class