Imports System.Windows

Public Class main
    Public enroll As New enrollments
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
End Class