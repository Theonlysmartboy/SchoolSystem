<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtDob = New System.Windows.Forms.TextBox()
        Me.CboTerm = New System.Windows.Forms.ComboBox()
        Me.CboStream = New System.Windows.Forms.ComboBox()
        Me.LblTerm = New System.Windows.Forms.Label()
        Me.LblStream = New System.Windows.Forms.Label()
        Me.lblAdmno = New System.Windows.Forms.Label()
        Me.TxtAdmno = New System.Windows.Forms.TextBox()
        Me.TxtKCPEMarks = New System.Windows.Forms.TextBox()
        Me.LblOtherNames = New System.Windows.Forms.Label()
        Me.TxtOtherNames = New System.Windows.Forms.TextBox()
        Me.CboClass = New System.Windows.Forms.ComboBox()
        Me.CboGender = New System.Windows.Forms.ComboBox()
        Me.LblClass = New System.Windows.Forms.Label()
        Me.LblSchool = New System.Windows.Forms.Label()
        Me.TxtKcpeSchool = New System.Windows.Forms.TextBox()
        Me.LblGrade = New System.Windows.Forms.Label()
        Me.LblDob = New System.Windows.Forms.Label()
        Me.LblGender = New System.Windows.Forms.Label()
        Me.LblFirstNAme = New System.Windows.Forms.Label()
        Me.TxtFirstName = New System.Windows.Forms.TextBox()
        Me.LblLastName = New System.Windows.Forms.Label()
        Me.TxtLastName = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnSave)
        Me.GroupBox2.Controls.Add(Me.BtnNew)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 416)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(523, 62)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(302, 19)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(173, 31)
        Me.BtnSave.TabIndex = 12
        Me.BtnSave.Text = "Save and proceed"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.Location = New System.Drawing.Point(50, 19)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(173, 31)
        Me.BtnNew.TabIndex = 13
        Me.BtnNew.Text = "Clear"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtDob)
        Me.GroupBox1.Controls.Add(Me.CboTerm)
        Me.GroupBox1.Controls.Add(Me.CboStream)
        Me.GroupBox1.Controls.Add(Me.LblTerm)
        Me.GroupBox1.Controls.Add(Me.LblStream)
        Me.GroupBox1.Controls.Add(Me.lblAdmno)
        Me.GroupBox1.Controls.Add(Me.TxtAdmno)
        Me.GroupBox1.Controls.Add(Me.TxtKCPEMarks)
        Me.GroupBox1.Controls.Add(Me.LblOtherNames)
        Me.GroupBox1.Controls.Add(Me.TxtOtherNames)
        Me.GroupBox1.Controls.Add(Me.CboClass)
        Me.GroupBox1.Controls.Add(Me.CboGender)
        Me.GroupBox1.Controls.Add(Me.LblClass)
        Me.GroupBox1.Controls.Add(Me.LblSchool)
        Me.GroupBox1.Controls.Add(Me.TxtKcpeSchool)
        Me.GroupBox1.Controls.Add(Me.LblGrade)
        Me.GroupBox1.Controls.Add(Me.LblDob)
        Me.GroupBox1.Controls.Add(Me.LblGender)
        Me.GroupBox1.Controls.Add(Me.LblFirstNAme)
        Me.GroupBox1.Controls.Add(Me.TxtFirstName)
        Me.GroupBox1.Controls.Add(Me.LblLastName)
        Me.GroupBox1.Controls.Add(Me.TxtLastName)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 405)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'TxtDob
        '
        Me.TxtDob.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDob.Location = New System.Drawing.Point(182, 188)
        Me.TxtDob.Name = "TxtDob"
        Me.TxtDob.Size = New System.Drawing.Size(318, 29)
        Me.TxtDob.TabIndex = 4
        '
        'CboTerm
        '
        Me.CboTerm.DisplayMember = "Male"
        Me.CboTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTerm.FormattingEnabled = True
        Me.CboTerm.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CboTerm.Location = New System.Drawing.Point(182, 355)
        Me.CboTerm.Name = "CboTerm"
        Me.CboTerm.Size = New System.Drawing.Size(318, 32)
        Me.CboTerm.TabIndex = 11
        Me.CboTerm.ValueMember = "Male"
        '
        'CboStream
        '
        Me.CboStream.DisplayMember = "Male"
        Me.CboStream.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboStream.FormattingEnabled = True
        Me.CboStream.Items.AddRange(New Object() {"Red", "Blue", "Green", "Yellow"})
        Me.CboStream.Location = New System.Drawing.Point(182, 319)
        Me.CboStream.Name = "CboStream"
        Me.CboStream.Size = New System.Drawing.Size(318, 32)
        Me.CboStream.TabIndex = 10
        Me.CboStream.ValueMember = "Male"
        '
        'LblTerm
        '
        Me.LblTerm.AutoSize = True
        Me.LblTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTerm.Location = New System.Drawing.Point(23, 353)
        Me.LblTerm.Name = "LblTerm"
        Me.LblTerm.Size = New System.Drawing.Size(55, 24)
        Me.LblTerm.TabIndex = 28
        Me.LblTerm.Text = "Term"
        '
        'LblStream
        '
        Me.LblStream.AutoSize = True
        Me.LblStream.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStream.Location = New System.Drawing.Point(23, 321)
        Me.LblStream.Name = "LblStream"
        Me.LblStream.Size = New System.Drawing.Size(69, 24)
        Me.LblStream.TabIndex = 26
        Me.LblStream.Text = "Stream"
        '
        'lblAdmno
        '
        Me.lblAdmno.AutoSize = True
        Me.lblAdmno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmno.Location = New System.Drawing.Point(23, 27)
        Me.lblAdmno.Name = "lblAdmno"
        Me.lblAdmno.Size = New System.Drawing.Size(72, 24)
        Me.lblAdmno.TabIndex = 24
        Me.lblAdmno.Text = "Admno"
        '
        'TxtAdmno
        '
        Me.TxtAdmno.Enabled = False
        Me.TxtAdmno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdmno.Location = New System.Drawing.Point(182, 24)
        Me.TxtAdmno.Name = "TxtAdmno"
        Me.TxtAdmno.Size = New System.Drawing.Size(318, 29)
        Me.TxtAdmno.TabIndex = 1
        '
        'TxtKCPEMarks
        '
        Me.TxtKCPEMarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKCPEMarks.Location = New System.Drawing.Point(182, 220)
        Me.TxtKCPEMarks.Name = "TxtKCPEMarks"
        Me.TxtKCPEMarks.Size = New System.Drawing.Size(318, 29)
        Me.TxtKCPEMarks.TabIndex = 5
        '
        'LblOtherNames
        '
        Me.LblOtherNames.AutoSize = True
        Me.LblOtherNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOtherNames.Location = New System.Drawing.Point(23, 123)
        Me.LblOtherNames.Name = "LblOtherNames"
        Me.LblOtherNames.Size = New System.Drawing.Size(122, 24)
        Me.LblOtherNames.TabIndex = 21
        Me.LblOtherNames.Text = "Other Names"
        '
        'TxtOtherNames
        '
        Me.TxtOtherNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOtherNames.Location = New System.Drawing.Point(182, 120)
        Me.TxtOtherNames.Name = "TxtOtherNames"
        Me.TxtOtherNames.Size = New System.Drawing.Size(318, 29)
        Me.TxtOtherNames.TabIndex = 3
        '
        'CboClass
        '
        Me.CboClass.DisplayMember = "Male"
        Me.CboClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboClass.FormattingEnabled = True
        Me.CboClass.Location = New System.Drawing.Point(182, 284)
        Me.CboClass.Name = "CboClass"
        Me.CboClass.Size = New System.Drawing.Size(318, 32)
        Me.CboClass.TabIndex = 9
        '
        'CboGender
        '
        Me.CboGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboGender.FormattingEnabled = True
        Me.CboGender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.CboGender.Location = New System.Drawing.Point(182, 152)
        Me.CboGender.Name = "CboGender"
        Me.CboGender.Size = New System.Drawing.Size(318, 32)
        Me.CboGender.TabIndex = 5
        '
        'LblClass
        '
        Me.LblClass.AutoSize = True
        Me.LblClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClass.Location = New System.Drawing.Point(23, 287)
        Me.LblClass.Name = "LblClass"
        Me.LblClass.Size = New System.Drawing.Size(55, 24)
        Me.LblClass.TabIndex = 15
        Me.LblClass.Text = "Class"
        '
        'LblSchool
        '
        Me.LblSchool.AutoSize = True
        Me.LblSchool.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSchool.Location = New System.Drawing.Point(23, 255)
        Me.LblSchool.Name = "LblSchool"
        Me.LblSchool.Size = New System.Drawing.Size(124, 24)
        Me.LblSchool.TabIndex = 13
        Me.LblSchool.Text = "KCPE School"
        '
        'TxtKcpeSchool
        '
        Me.TxtKcpeSchool.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKcpeSchool.Location = New System.Drawing.Point(182, 252)
        Me.TxtKcpeSchool.Name = "TxtKcpeSchool"
        Me.TxtKcpeSchool.Size = New System.Drawing.Size(318, 29)
        Me.TxtKcpeSchool.TabIndex = 6
        '
        'LblGrade
        '
        Me.LblGrade.AutoSize = True
        Me.LblGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGrade.Location = New System.Drawing.Point(23, 223)
        Me.LblGrade.Name = "LblGrade"
        Me.LblGrade.Size = New System.Drawing.Size(115, 24)
        Me.LblGrade.TabIndex = 11
        Me.LblGrade.Text = "KCPE Marks"
        '
        'LblDob
        '
        Me.LblDob.AutoSize = True
        Me.LblDob.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDob.Location = New System.Drawing.Point(23, 191)
        Me.LblDob.Name = "LblDob"
        Me.LblDob.Size = New System.Drawing.Size(110, 24)
        Me.LblDob.TabIndex = 9
        Me.LblDob.Text = "Date of Birth"
        '
        'LblGender
        '
        Me.LblGender.AutoSize = True
        Me.LblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGender.Location = New System.Drawing.Point(23, 157)
        Me.LblGender.Name = "LblGender"
        Me.LblGender.Size = New System.Drawing.Size(74, 24)
        Me.LblGender.TabIndex = 5
        Me.LblGender.Text = "Gender"
        '
        'LblFirstNAme
        '
        Me.LblFirstNAme.AutoSize = True
        Me.LblFirstNAme.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFirstNAme.Location = New System.Drawing.Point(23, 91)
        Me.LblFirstNAme.Name = "LblFirstNAme"
        Me.LblFirstNAme.Size = New System.Drawing.Size(101, 24)
        Me.LblFirstNAme.TabIndex = 3
        Me.LblFirstNAme.Text = "First Name"
        '
        'TxtFirstName
        '
        Me.TxtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFirstName.Location = New System.Drawing.Point(182, 88)
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.Size = New System.Drawing.Size(318, 29)
        Me.TxtFirstName.TabIndex = 1
        '
        'LblLastName
        '
        Me.LblLastName.AutoSize = True
        Me.LblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLastName.Location = New System.Drawing.Point(23, 59)
        Me.LblLastName.Name = "LblLastName"
        Me.LblLastName.Size = New System.Drawing.Size(99, 24)
        Me.LblLastName.TabIndex = 1
        Me.LblLastName.Text = "Last Name"
        '
        'TxtLastName
        '
        Me.TxtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLastName.Location = New System.Drawing.Point(182, 56)
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.Size = New System.Drawing.Size(318, 29)
        Me.TxtLastName.TabIndex = 1
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 486)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Student"
        Me.Text = "Student"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents BtnSave As Button
	Friend WithEvents BtnNew As Button
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents CboTerm As ComboBox
	Friend WithEvents CboStream As ComboBox
	Friend WithEvents LblTerm As Label
	Friend WithEvents LblStream As Label
	Friend WithEvents lblAdmno As Label
	Friend WithEvents TxtAdmno As TextBox
	Friend WithEvents TxtKCPEMarks As TextBox
	Friend WithEvents LblOtherNames As Label
	Friend WithEvents TxtOtherNames As TextBox
	Friend WithEvents CboClass As ComboBox
	Friend WithEvents CboGender As ComboBox
	Friend WithEvents LblClass As Label
	Friend WithEvents LblSchool As Label
	Friend WithEvents TxtKcpeSchool As TextBox
	Friend WithEvents LblGrade As Label
	Friend WithEvents LblDob As Label
	Friend WithEvents LblGender As Label
	Friend WithEvents LblFirstNAme As Label
	Friend WithEvents TxtFirstName As TextBox
	Friend WithEvents LblLastName As Label
	Friend WithEvents TxtLastName As TextBox
	Friend WithEvents TxtDob As TextBox
End Class
