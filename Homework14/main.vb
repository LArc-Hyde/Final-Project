Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class main
    Public enroll As New enrollments

    'testing
    'Public st1 As New student
    'Public st2 As New student
    'Public in1 As New Instructor
    'Public in2 As New Instructor
    'Public co1 As New course
    'Public co2 As New course


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

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'THIS IS TESTING CODE
        'st1.FirstName() = "Bryan"
        'st1.LastName() = "Toscano"
        'st1.Email() = "bt@mail.com"
        'st1.StudentNumber = 313

        'st2.FirstName() = "Nathen"
        'st2.LastName() = "Toscano"
        'st2.Email() = "nt@mail.com"
        'st2.StudentNumber = 461

        'in1.FirstName() = "Joe"
        'in1.LastName() = "Biden"
        'in1.Email() = "jb@mail.com"
        'in1.OfficeNumber = 115

        'in2.FirstName() = "George"
        'in2.LastName() = "Washington"
        'in2.Email() = "gw@mail.com"
        'in2.OfficeNumber = 116

        'co1.CourseNumber() = 999
        'co1.RoomNumber() = 215
        'co1.CourseName() = "Comp105"
        'co1.Units() = 3
        'co1.Professor("Joe", "Biden")

        'co2.CourseNumber() = 888
        'co2.RoomNumber() = 216
        'co2.CourseName() = "Eng101"
        'co2.Units() = 3
        'co2.Professor("George", "Washington")

        'enroll.Students(st1)
        'enroll.Students(st2)
        'enroll.Instructors(in1)
        'enroll.Instructors(in2)
        'enroll.Courses(co1)
        'enroll.Courses(co2)
    End Sub




End Class
