Imports System.Windows

Public Class addStudent
    Private Sub btnCreateStudent_Click(sender As Object, e As EventArgs) Handles btnCreateStudent.Click
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

            'clearing out textboxes to get ready for next student
            txtFName.Clear()
            txtLName.Clear()
            txtStudentNum.Clear()
            txtEmail.Clear()
            txtFName.Focus()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Creator.Count() 'Updates if new Students are added
        Creator.Show() 'gets back to main form without saving any data
        Me.Hide()
    End Sub
End Class