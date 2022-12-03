Public Class addInstructor
    Private Sub btnCreateInstructor_Click(sender As Object, e As EventArgs) Handles btnCreateInstructor.Click
        'making sure everything is filled and valid
        If txtFName.Text = "" Or txtLName.Text = "" Or txtEmail.Text = "" Or txtOfficeNum.Text = "" Or
            IsNumeric(txtOfficeNum.Text) = False Then
            MessageBox.Show("All Fields must be filled and of the correct type.")
        Else
            'assigning an Instructor
            Dim inst As New Instructor
            inst.FirstName() = txtFName.Text
            inst.LastName() = txtLName.Text
            inst.Email() = txtEmail.Text
            inst.OfficeNumber = txtOfficeNum.Text
            main.enroll.Instructors(inst) 'adding an Instructor to enroll

            'clearing textboxes
            txtFName.Clear()
            txtLName.Clear()
            txtEmail.Clear()
            txtOfficeNum.Clear()
            txtFName.Focus()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Creator.Count() 'Updates if new Students are added
        Creator.Show() 'gets back to main form without saving any data
        Me.Hide()
    End Sub
End Class