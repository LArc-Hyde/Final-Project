<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Viewer
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
        Me.btnStudents = New System.Windows.Forms.Button()
        Me.btnInstructors = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStudents
        '
        Me.btnStudents.Location = New System.Drawing.Point(36, 39)
        Me.btnStudents.Name = "btnStudents"
        Me.btnStudents.Size = New System.Drawing.Size(124, 52)
        Me.btnStudents.TabIndex = 0
        Me.btnStudents.Text = "Show Students"
        Me.btnStudents.UseVisualStyleBackColor = True
        '
        'btnInstructors
        '
        Me.btnInstructors.Location = New System.Drawing.Point(36, 122)
        Me.btnInstructors.Name = "btnInstructors"
        Me.btnInstructors.Size = New System.Drawing.Size(124, 52)
        Me.btnInstructors.TabIndex = 1
        Me.btnInstructors.Text = "Show Instructors"
        Me.btnInstructors.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(36, 207)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 52)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Show Courses"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(36, 289)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(124, 52)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Show Enrollments"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(36, 360)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(124, 52)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Back"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(215, 39)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(538, 373)
        Me.DataGridView1.TabIndex = 5
        '
        'Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnInstructors)
        Me.Controls.Add(Me.btnStudents)
        Me.Name = "Viewer"
        Me.Text = "View Enrollments"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStudents As Button
    Friend WithEvents btnInstructors As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
