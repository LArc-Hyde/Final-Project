<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddEnrollment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstNotEnrolled = New System.Windows.Forms.ListBox()
        Me.lstEnrolled = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.txtSeats = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 31)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(250, 23)
        Me.ComboBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Courses:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Students Not Enrolled to this Course:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(474, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Students Enrolled to this Course:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(474, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Seats Availiable:"
        '
        'lstNotEnrolled
        '
        Me.lstNotEnrolled.FormattingEnabled = True
        Me.lstNotEnrolled.ItemHeight = 15
        Me.lstNotEnrolled.Location = New System.Drawing.Point(12, 93)
        Me.lstNotEnrolled.Name = "lstNotEnrolled"
        Me.lstNotEnrolled.Size = New System.Drawing.Size(250, 199)
        Me.lstNotEnrolled.TabIndex = 6
        '
        'lstEnrolled
        '
        Me.lstEnrolled.FormattingEnabled = True
        Me.lstEnrolled.ItemHeight = 15
        Me.lstEnrolled.Location = New System.Drawing.Point(474, 93)
        Me.lstEnrolled.Name = "lstEnrolled"
        Me.lstEnrolled.Size = New System.Drawing.Size(250, 199)
        Me.lstEnrolled.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(298, 155)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(129, 50)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add to Course" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--->"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(608, 315)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(116, 33)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(474, 315)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(116, 33)
        Me.btnCreate.TabIndex = 10
        Me.btnCreate.Text = "Create Enrollments"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'txtSeats
        '
        Me.txtSeats.Enabled = False
        Me.txtSeats.Location = New System.Drawing.Point(582, 46)
        Me.txtSeats.Name = "txtSeats"
        Me.txtSeats.Size = New System.Drawing.Size(32, 23)
        Me.txtSeats.TabIndex = 11
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(283, 31)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(104, 23)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "Search Course"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'AddEnrollment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 368)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSeats)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstEnrolled)
        Me.Controls.Add(Me.lstNotEnrolled)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "AddEnrollment"
        Me.Text = "AddEnrollment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lstNotEnrolled As ListBox
    Friend WithEvents lstEnrolled As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents txtSeats As TextBox
    Friend WithEvents btnSearch As Button
End Class
