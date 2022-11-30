<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.btnAddIStudent = New System.Windows.Forms.Button()
        Me.btnAddInstructor = New System.Windows.Forms.Button()
        Me.btnAddCourse = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.lstEnrollView = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnAddIStudent
        '
        Me.btnAddIStudent.Location = New System.Drawing.Point(28, 35)
        Me.btnAddIStudent.Name = "btnAddIStudent"
        Me.btnAddIStudent.Size = New System.Drawing.Size(112, 43)
        Me.btnAddIStudent.TabIndex = 0
        Me.btnAddIStudent.Text = "Add Student"
        Me.btnAddIStudent.UseVisualStyleBackColor = True
        '
        'btnAddInstructor
        '
        Me.btnAddInstructor.Location = New System.Drawing.Point(28, 175)
        Me.btnAddInstructor.Name = "btnAddInstructor"
        Me.btnAddInstructor.Size = New System.Drawing.Size(112, 43)
        Me.btnAddInstructor.TabIndex = 1
        Me.btnAddInstructor.Text = "Add Instructor"
        Me.btnAddInstructor.UseVisualStyleBackColor = True
        '
        'btnAddCourse
        '
        Me.btnAddCourse.Location = New System.Drawing.Point(28, 106)
        Me.btnAddCourse.Name = "btnAddCourse"
        Me.btnAddCourse.Size = New System.Drawing.Size(112, 43)
        Me.btnAddCourse.TabIndex = 2
        Me.btnAddCourse.Text = "Add Course"
        Me.btnAddCourse.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(28, 245)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 43)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(28, 309)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(112, 43)
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'lstEnrollView
        '
        Me.lstEnrollView.FormattingEnabled = True
        Me.lstEnrollView.ItemHeight = 15
        Me.lstEnrollView.Location = New System.Drawing.Point(219, 35)
        Me.lstEnrollView.Name = "lstEnrollView"
        Me.lstEnrollView.Size = New System.Drawing.Size(301, 319)
        Me.lstEnrollView.TabIndex = 5
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 364)
        Me.Controls.Add(Me.lstEnrollView)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAddCourse)
        Me.Controls.Add(Me.btnAddInstructor)
        Me.Controls.Add(Me.btnAddIStudent)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "main"
        Me.Text = "Add Enrollment"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddIStudent As Button
    Friend WithEvents btnAddInstructor As Button
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents lstEnrollView As ListBox
End Class
