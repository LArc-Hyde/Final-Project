Imports System.Windows

Public Class addStudent
    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        'making sure everything is filled and valid
        If txtFName.Text = "" Or txtLName.Text = "" Or txtEmail.Text = "" Or txtStudentNum.Text = "" Or
            IsNumeric(txtStudentNum.Text) = False Then
            MessageBox.Show("All Fields must be filled and of the correct type.")
        Else
            'assigning a student
            Dim stu As New student
            stu.FirstName() = txtFName.Text
            stu.LastName() = txtLName.Text
            stu.Email() = txtEmail.Text
            stu.StudentNumber = txtStudentNum.Text
            main.enroll.Students(stu) 'adding a student to enroll

            'getting main form ready for user
            main.btnAddIStudent.Enabled = False 'disabling addStudent button to force user to continue desired path
            main.btnAddCourse.Enabled = True 'next step is adding Course
            main.lstEnrollView.Items.RemoveAt(main.lstEnrollView.Items.Count - 1) 'removing last instruction
            main.lstEnrollView.Items.Add("Student: " & stu.FirstName & " " & stu.LastName) 'showing Student was added
            main.lstEnrollView.Items.Add("Must Add Course Next") 'Displaying next instruction

            'getting back to main form
            main.Show()
            Me.Close()
        End If
    End Sub
End Class