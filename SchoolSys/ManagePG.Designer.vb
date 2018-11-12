<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagePG
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
        Me.TxtAdmno = New System.Windows.Forms.TextBox()
        Me.TxtEmailAddress = New System.Windows.Forms.TextBox()
        Me.TxtPhoneNo = New System.Windows.Forms.TextBox()
        Me.LblGrade = New System.Windows.Forms.Label()
        Me.LblEmailAddress = New System.Windows.Forms.Label()
        Me.TxtDescription = New System.Windows.Forms.TextBox()
        Me.LblPhoneNo = New System.Windows.Forms.Label()
        Me.LblDescription = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.LblId = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtAdmno
        '
        Me.TxtAdmno.Enabled = False
        Me.TxtAdmno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdmno.Location = New System.Drawing.Point(169, 87)
        Me.TxtAdmno.Name = "TxtAdmno"
        Me.TxtAdmno.Size = New System.Drawing.Size(358, 29)
        Me.TxtAdmno.TabIndex = 2
        '
        'TxtEmailAddress
        '
        Me.TxtEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmailAddress.Location = New System.Drawing.Point(169, 239)
        Me.TxtEmailAddress.Name = "TxtEmailAddress"
        Me.TxtEmailAddress.Size = New System.Drawing.Size(358, 29)
        Me.TxtEmailAddress.TabIndex = 5
        '
        'TxtPhoneNo
        '
        Me.TxtPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPhoneNo.Location = New System.Drawing.Point(169, 201)
        Me.TxtPhoneNo.Name = "TxtPhoneNo"
        Me.TxtPhoneNo.Size = New System.Drawing.Size(358, 29)
        Me.TxtPhoneNo.TabIndex = 5
        '
        'LblGrade
        '
        Me.LblGrade.AutoSize = True
        Me.LblGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGrade.Location = New System.Drawing.Point(18, 87)
        Me.LblGrade.Name = "LblGrade"
        Me.LblGrade.Size = New System.Drawing.Size(72, 24)
        Me.LblGrade.TabIndex = 52
        Me.LblGrade.Text = "Admno"
        '
        'LblEmailAddress
        '
        Me.LblEmailAddress.AutoSize = True
        Me.LblEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmailAddress.Location = New System.Drawing.Point(18, 239)
        Me.LblEmailAddress.Name = "LblEmailAddress"
        Me.LblEmailAddress.Size = New System.Drawing.Size(132, 24)
        Me.LblEmailAddress.TabIndex = 51
        Me.LblEmailAddress.Text = "Email Address"
        '
        'TxtDescription
        '
        Me.TxtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescription.Location = New System.Drawing.Point(169, 163)
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(358, 29)
        Me.TxtDescription.TabIndex = 4
        '
        'LblPhoneNo
        '
        Me.LblPhoneNo.AutoSize = True
        Me.LblPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPhoneNo.Location = New System.Drawing.Point(18, 201)
        Me.LblPhoneNo.Name = "LblPhoneNo"
        Me.LblPhoneNo.Size = New System.Drawing.Size(96, 24)
        Me.LblPhoneNo.TabIndex = 49
        Me.LblPhoneNo.Text = "Phone No"
        '
        'LblDescription
        '
        Me.LblDescription.AccessibleRole = System.Windows.Forms.AccessibleRole.Document
        Me.LblDescription.AutoSize = True
        Me.LblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescription.Location = New System.Drawing.Point(18, 163)
        Me.LblDescription.Name = "LblDescription"
        Me.LblDescription.Size = New System.Drawing.Size(104, 24)
        Me.LblDescription.TabIndex = 48
        Me.LblDescription.Text = "Description"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.Location = New System.Drawing.Point(18, 125)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(61, 24)
        Me.LblName.TabIndex = 47
        Me.LblName.Text = "Name"
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(169, 125)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(358, 29)
        Me.TxtName.TabIndex = 3
        '
        'BtnSearch
        '
        Me.BtnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.Location = New System.Drawing.Point(565, 48)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(121, 30)
        Me.BtnSearch.TabIndex = 1
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Location = New System.Drawing.Point(565, 114)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(121, 30)
        Me.BtnEdit.TabIndex = 7
        Me.BtnEdit.Text = "Update"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Location = New System.Drawing.Point(565, 188)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(121, 30)
        Me.BtnDelete.TabIndex = 8
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'TxtId
        '
        Me.TxtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtId.Location = New System.Drawing.Point(169, 49)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(358, 29)
        Me.TxtId.TabIndex = 0
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblId.Location = New System.Drawing.Point(18, 49)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(25, 24)
        Me.LblId.TabIndex = 60
        Me.LblId.Text = "Id"
        '
        'ManagePG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 289)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.LblId)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TxtAdmno)
        Me.Controls.Add(Me.TxtEmailAddress)
        Me.Controls.Add(Me.TxtPhoneNo)
        Me.Controls.Add(Me.LblGrade)
        Me.Controls.Add(Me.LblEmailAddress)
        Me.Controls.Add(Me.TxtDescription)
        Me.Controls.Add(Me.LblPhoneNo)
        Me.Controls.Add(Me.LblDescription)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.TxtName)
        Me.Name = "ManagePG"
        Me.Text = "ManagePG"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtAdmno As TextBox
	Friend WithEvents TxtEmailAddress As TextBox
	Friend WithEvents TxtPhoneNo As TextBox
	Friend WithEvents LblGrade As Label
	Friend WithEvents LblEmailAddress As Label
	Friend WithEvents TxtDescription As TextBox
	Friend WithEvents LblPhoneNo As Label
	Friend WithEvents LblDescription As Label
	Friend WithEvents LblName As Label
	Friend WithEvents TxtName As TextBox
	Friend WithEvents BtnSearch As Button
	Friend WithEvents BtnEdit As Button
	Friend WithEvents BtnDelete As Button
	Friend WithEvents TxtId As TextBox
	Friend WithEvents LblId As Label
End Class
