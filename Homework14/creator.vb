Imports System.Windows
Public Class Creator
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Count()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Will save 4 different files max
        SaveFileDialog1.ShowDialog()
        Dim location As String = SaveFileDialog1.FileName
        main.enroll.SaveData(location)

        'getting main for ready for another enrollment
        btnSave.Enabled = False
        btnAddIStudent.Enabled = True 'can now add student
        lstEnrollView.Items.RemoveAt(lstEnrollView.Items.Count - 1) 'removing last instruction
        lstEnrollView.Items.Add("Enrollment saved-----------------------------------------------------------------------------")
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        'ADD LOADING LATER
        'should update counts
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        main.Show()
        Me.Close()
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
        addInstructor.Show() 'opens addInstructor form
    End Sub
    Private Sub btnAddEnroll_Click(sender As Object, e As EventArgs) Handles btnAddEnroll.Click
        Me.Hide()
        'addEnroll.Show() 'opens adddEnrollment form
    End Sub

    Public Sub Count() 'Displays amount of  students, instructors, enrollments
        lstEnrollView.Items.Clear()
        lstEnrollView.Items.Add("Total Students: " & main.enroll.getStudentCount())
        lstEnrollView.Items.Add("Total Instructors: " & main.enroll.InstructorCount())
        lstEnrollView.Items.Add("Total Courses: " & main.enroll.CourseCount())
        lstEnrollView.Items.Add("Total Enrollments: " & main.enroll.EnrollmentCount())
    End Sub
End Class