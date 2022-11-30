<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addCourse
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCourseName = New System.Windows.Forms.TextBox()
        Me.txtCourseNum = New System.Windows.Forms.TextBox()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.txtRoomNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCourseName
        '
        Me.txtCourseName.Location = New System.Drawing.Point(141, 26)
        Me.txtCourseName.Name = "txtCourseName"
        Me.txtCourseName.Size = New System.Drawing.Size(100, 23)
        Me.txtCourseName.TabIndex = 0
        '
        'txtCourseNum
        '
        Me.txtCourseNum.Location = New System.Drawing.Point(141, 73)
        Me.txtCourseNum.Name = "txtCourseNum"
        Me.txtCourseNum.Size = New System.Drawing.Size(100, 23)
        Me.txtCourseNum.TabIndex = 1
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(141, 119)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(100, 23)
        Me.txtUnits.TabIndex = 2
        '
        'txtRoomNum
        '
        Me.txtRoomNum.Location = New System.Drawing.Point(141, 162)
        Me.txtRoomNum.Name = "txtRoomNum"
        Me.txtRoomNum.Size = New System.Drawing.Size(100, 23)
        Me.txtRoomNum.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Course Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Course Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Units:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Room Number:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(47, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 31)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Add to Enrollment"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'addCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 275)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRoomNum)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.txtCourseNum)
        Me.Controls.Add(Me.txtCourseName)
        Me.Name = "addCourse"
        Me.Text = "Add Course"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCourseName As TextBox
    Friend WithEvents txtCourseNum As TextBox
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents txtRoomNum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
