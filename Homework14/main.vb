Imports System.Windows

Public Class main
    Public enroll As New enrollments
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'saving should only be available when a 1 COURSE, 1 STUDENT, & 1 INSTRUCTOR ARE LOADED
        SaveFileDialog1.ShowDialog()
        Dim location As String = SaveFileDialog1.FileName
        enroll.SaveEnrollments(location)

        'getting main for ready for another enrollment
        btnSave.Enabled = False
        btnAddIStudent.Enabled = True 'can now add student
        lstEnrollView.Items.RemoveAt(lstEnrollView.Items.Count - 1) 'removing last instruction
        lstEnrollView.Items.Add("Enrollment saved-----------------------------------------------------------------------------")
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Will start disabled but will be enabled when user goes through desired path
        btnAddInstructor.Enabled = False
        btnAddCourse.Enabled = False
        btnSave.Enabled = False
        lstEnrollView.Items.Add("Must Add Student Next")
    End Sub

    Private Sub btnAddIStudent_Click(sender As Object, e As EventArgs) Handles btnAddIStudent.Click
        Me.Hide()
        addStudent.Show() 'opens addStudent Form
    End Sub

    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        Me.Hide()
        addCourse.Show() 'opens addCourse form
    End Sub

    Private Sub btnAddInstructor_Click(sender As Object, e As EventArgs) Handles btnAddInstructor.Click
        Me.Hide()
        addInstructor.show() 'opens addInstructor form
    End Sub
End Class