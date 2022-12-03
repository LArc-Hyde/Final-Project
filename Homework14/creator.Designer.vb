<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Creator
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
        Me.lstEnrollView = New System.Windows.Forms.ListBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAddCourse = New System.Windows.Forms.Button()
        Me.btnAddInstructor = New System.Windows.Forms.Button()
        Me.btnAddIStudent = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnAddEnroll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstEnrollView
        '
        Me.lstEnrollView.FormattingEnabled = True
        Me.lstEnrollView.ItemHeight = 15
        Me.lstEnrollView.Location = New System.Drawing.Point(225, 27)
        Me.lstEnrollView.Name = "lstEnrollView"
        Me.lstEnrollView.Size = New System.Drawing.Size(301, 274)
        Me.lstEnrollView.TabIndex = 11
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(225, 346)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(112, 43)
        Me.btnLoad.TabIndex = 10
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(34, 346)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 43)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAddCourse
        '
        Me.btnAddCourse.Location = New System.Drawing.Point(34, 185)
        Me.btnAddCourse.Name = "btnAddCourse"
        Me.btnAddCourse.Size = New System.Drawing.Size(112, 43)
        Me.btnAddCourse.TabIndex = 8
        Me.btnAddCourse.Text = "Add Course"
        Me.btnAddCourse.UseVisualStyleBackColor = True
        '
        'btnAddInstructor
        '
        Me.btnAddInstructor.Location = New System.Drawing.Point(34, 105)
        Me.btnAddInstructor.Name = "btnAddInstructor"
        Me.btnAddInstructor.Size = New System.Drawing.Size(112, 43)
        Me.btnAddInstructor.TabIndex = 7
        Me.btnAddInstructor.Text = "Add Instructor"
        Me.btnAddInstructor.UseVisualStyleBackColor = True
        '
        'btnAddIStudent
        '
        Me.btnAddIStudent.Location = New System.Drawing.Point(34, 27)
        Me.btnAddIStudent.Name = "btnAddIStudent"
        Me.btnAddIStudent.Size = New System.Drawing.Size(112, 43)
        Me.btnAddIStudent.TabIndex = 6
        Me.btnAddIStudent.Text = "Add Student"
        Me.btnAddIStudent.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(414, 346)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(112, 43)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnAddEnroll
        '
        Me.btnAddEnroll.Location = New System.Drawing.Point(34, 258)
        Me.btnAddEnroll.Name = "btnAddEnroll"
        Me.btnAddEnroll.Size = New System.Drawing.Size(112, 43)
        Me.btnAddEnroll.TabIndex = 13
        Me.btnAddEnroll.Text = "Add Enrollment"
        Me.btnAddEnroll.UseVisualStyleBackColor = True
        '
        'Creator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 403)
        Me.Controls.Add(Me.btnAddEnroll)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lstEnrollView)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAddCourse)
        Me.Controls.Add(Me.btnAddInstructor)
        Me.Controls.Add(Me.btnAddIStudent)
        Me.Name = "Creator"
        Me.Text = "creator"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstEnrollView As ListBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents btnAddInstructor As Button
    Friend WithEvents btnAddIStudent As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnBack As Button
    Friend WithEvents btnAddEnroll As Button
End Class
