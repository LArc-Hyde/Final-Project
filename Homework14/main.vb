Imports System.Windows

Public Class main
    Public enroll As New enrollments

    'for testing
    Public st As New student

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnCreator_Click(sender As Object, e As EventArgs) Handles btnCreator.Click
        Me.Hide()
        Creator.Show()
    End Sub

    Private Sub btnViewer_Click(sender As Object, e As EventArgs) Handles btnViewer.Click
        Me.Hide()
        Viewer.Show()
    End Sub

    'for testing

    'st1.FirstName() = "Bryan"
    'st1.LastName() = txtLName.Text
    'st1.Email() = txtEmail.Text
    'st1.StudentNumber = txtStudentNum.Text 
    'Dim st2 As New student
    'Dim in1 As New Instructor
    'Dim in2 As New Instructor
    'Dim co1 As New course
    'Dim co2 As New course


End Class
