Public Class addInstructor
    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
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

            'getting main form ready for user
            main.btnAddInstructor.Enabled = False 'disabling addInstructor button to force user to continue desired path
            main.btnSave.Enabled = True 'next step is saving enroll
            main.lstEnrollView.Items.RemoveAt(main.lstEnrollView.Items.Count - 1) 'removing last instruction
            main.lstEnrollView.Items.Add("Instructor: " & inst.FirstName & " " & inst.LastName) 'showing an Instructor was added
            main.lstEnrollView.Items.Add("Must save Next") 'Displaying next instruction

            'getting back to main form
            main.Show()
            Me.Close()
        End If
    End Sub
End Class