<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Payments
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
        Me.components = New System.ComponentModel.Container()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtReceiptNo = New System.Windows.Forms.TextBox()
        Me.LblAdmno = New System.Windows.Forms.Label()
        Me.LblReceiptNo = New System.Windows.Forms.Label()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.LblLastName = New System.Windows.Forms.Label()
        Me.TxtAdmno = New System.Windows.Forms.TextBox()
        Me.TxtAmtPaid = New System.Windows.Forms.TextBox()
        Me.TxtFirstName = New System.Windows.Forms.TextBox()
        Me.TxtOtherNames = New System.Windows.Forms.TextBox()
        Me.LblAmtPaid = New System.Windows.Forms.Label()
        Me.TxtLastName = New System.Windows.Forms.TextBox()
        Me.TxtReceivedBy = New System.Windows.Forms.TextBox()
        Me.LblReceivedBy = New System.Windows.Forms.Label()
        Me.TxtDocumentNo = New System.Windows.Forms.TextBox()
        Me.CboTypeOfPayment = New System.Windows.Forms.ComboBox()
        Me.LblPaidBy = New System.Windows.Forms.Label()
        Me.TxtPaidBy = New System.Windows.Forms.TextBox()
        Me.LblGrade = New System.Windows.Forms.Label()
        Me.LblGender = New System.Windows.Forms.Label()
        Me.LblDateTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(346, 347)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(122, 31)
        Me.BtnSave.TabIndex = 19
        Me.BtnSave.Text = "Submit"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.Location = New System.Drawing.Point(190, 347)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(129, 31)
        Me.BtnNew.TabIndex = 18
        Me.BtnNew.Text = "Clear"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.BtnNew)
        Me.GroupBox1.Controls.Add(Me.txtReceiptNo)
        Me.GroupBox1.Controls.Add(Me.LblAdmno)
        Me.GroupBox1.Controls.Add(Me.LblReceiptNo)
        Me.GroupBox1.Controls.Add(Me.BtnSearch)
        Me.GroupBox1.Controls.Add(Me.LblLastName)
        Me.GroupBox1.Controls.Add(Me.TxtAdmno)
        Me.GroupBox1.Controls.Add(Me.TxtAmtPaid)
        Me.GroupBox1.Controls.Add(Me.TxtFirstName)
        Me.GroupBox1.Controls.Add(Me.TxtOtherNames)
        Me.GroupBox1.Controls.Add(Me.LblAmtPaid)
        Me.GroupBox1.Controls.Add(Me.TxtLastName)
        Me.GroupBox1.Controls.Add(Me.TxtReceivedBy)
        Me.GroupBox1.Controls.Add(Me.LblReceivedBy)
        Me.GroupBox1.Controls.Add(Me.TxtDocumentNo)
        Me.GroupBox1.Controls.Add(Me.CboTypeOfPayment)
        Me.GroupBox1.Controls.Add(Me.LblPaidBy)
        Me.GroupBox1.Controls.Add(Me.TxtPaidBy)
        Me.GroupBox1.Controls.Add(Me.LblGrade)
        Me.GroupBox1.Controls.Add(Me.LblGender)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(49, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(627, 388)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.Enabled = False
        Me.txtReceiptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtReceiptNo.Location = New System.Drawing.Point(190, 130)
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(278, 29)
        Me.txtReceiptNo.TabIndex = 0
        '
        'LblAdmno
        '
        Me.LblAdmno.AutoSize = True
        Me.LblAdmno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdmno.Location = New System.Drawing.Point(32, 40)
        Me.LblAdmno.Name = "LblAdmno"
        Me.LblAdmno.Size = New System.Drawing.Size(72, 24)
        Me.LblAdmno.TabIndex = 24
        Me.LblAdmno.Text = "Admno"
        '
        'LblReceiptNo
        '
        Me.LblReceiptNo.AutoSize = True
        Me.LblReceiptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReceiptNo.Location = New System.Drawing.Point(31, 133)
        Me.LblReceiptNo.Name = "LblReceiptNo"
        Me.LblReceiptNo.Size = New System.Drawing.Size(99, 24)
        Me.LblReceiptNo.TabIndex = 31
        Me.LblReceiptNo.Text = "ReceiptNo"
        '
        'BtnSearch
        '
        Me.BtnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.Location = New System.Drawing.Point(365, 38)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(132, 29)
        Me.BtnSearch.TabIndex = 2
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'LblLastName
        '
        Me.LblLastName.AutoSize = True
        Me.LblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLastName.Location = New System.Drawing.Point(32, 95)
        Me.LblLastName.Name = "LblLastName"
        Me.LblLastName.Size = New System.Drawing.Size(61, 24)
        Me.LblLastName.TabIndex = 1
        Me.LblLastName.Text = "Name"
        '
        'TxtAdmno
        '
        Me.TxtAdmno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdmno.Location = New System.Drawing.Point(191, 38)
        Me.TxtAdmno.Name = "TxtAdmno"
        Me.TxtAdmno.Size = New System.Drawing.Size(139, 29)
        Me.TxtAdmno.TabIndex = 1
        '
        'TxtAmtPaid
        '
        Me.TxtAmtPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmtPaid.Location = New System.Drawing.Point(190, 165)
        Me.TxtAmtPaid.Name = "TxtAmtPaid"
        Me.TxtAmtPaid.Size = New System.Drawing.Size(279, 29)
        Me.TxtAmtPaid.TabIndex = 2
        '
        'TxtFirstName
        '
        Me.TxtFirstName.BackColor = System.Drawing.SystemColors.Control
        Me.TxtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFirstName.Location = New System.Drawing.Point(336, 95)
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.ReadOnly = True
        Me.TxtFirstName.Size = New System.Drawing.Size(132, 29)
        Me.TxtFirstName.TabIndex = 2
        '
        'TxtOtherNames
        '
        Me.TxtOtherNames.BackColor = System.Drawing.SystemColors.Control
        Me.TxtOtherNames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOtherNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOtherNames.Location = New System.Drawing.Point(474, 95)
        Me.TxtOtherNames.Name = "TxtOtherNames"
        Me.TxtOtherNames.ReadOnly = True
        Me.TxtOtherNames.Size = New System.Drawing.Size(128, 29)
        Me.TxtOtherNames.TabIndex = 20
        '
        'LblAmtPaid
        '
        Me.LblAmtPaid.AutoSize = True
        Me.LblAmtPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmtPaid.Location = New System.Drawing.Point(31, 168)
        Me.LblAmtPaid.Name = "LblAmtPaid"
        Me.LblAmtPaid.Size = New System.Drawing.Size(118, 24)
        Me.LblAmtPaid.TabIndex = 28
        Me.LblAmtPaid.Text = "Amount Paid"
        '
        'TxtLastName
        '
        Me.TxtLastName.BackColor = System.Drawing.SystemColors.Control
        Me.TxtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLastName.Location = New System.Drawing.Point(190, 95)
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.ReadOnly = True
        Me.TxtLastName.Size = New System.Drawing.Size(140, 29)
        Me.TxtLastName.TabIndex = 23
        '
        'TxtReceivedBy
        '
        Me.TxtReceivedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReceivedBy.Location = New System.Drawing.Point(190, 308)
        Me.TxtReceivedBy.Name = "TxtReceivedBy"
        Me.TxtReceivedBy.Size = New System.Drawing.Size(279, 29)
        Me.TxtReceivedBy.TabIndex = 5
        '
        'LblReceivedBy
        '
        Me.LblReceivedBy.AutoSize = True
        Me.LblReceivedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReceivedBy.Location = New System.Drawing.Point(31, 308)
        Me.LblReceivedBy.Name = "LblReceivedBy"
        Me.LblReceivedBy.Size = New System.Drawing.Size(111, 24)
        Me.LblReceivedBy.TabIndex = 26
        Me.LblReceivedBy.Text = "ReceivedBy"
        '
        'TxtDocumentNo
        '
        Me.TxtDocumentNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDocumentNo.Location = New System.Drawing.Point(190, 238)
        Me.TxtDocumentNo.Name = "TxtDocumentNo"
        Me.TxtDocumentNo.Size = New System.Drawing.Size(279, 29)
        Me.TxtDocumentNo.TabIndex = 3
        '
        'CboTypeOfPayment
        '
        Me.CboTypeOfPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTypeOfPayment.FormattingEnabled = True
        Me.CboTypeOfPayment.Location = New System.Drawing.Point(190, 200)
        Me.CboTypeOfPayment.Name = "CboTypeOfPayment"
        Me.CboTypeOfPayment.Size = New System.Drawing.Size(278, 32)
        Me.CboTypeOfPayment.TabIndex = 16
        '
        'LblPaidBy
        '
        Me.LblPaidBy.AutoSize = True
        Me.LblPaidBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaidBy.Location = New System.Drawing.Point(31, 276)
        Me.LblPaidBy.Name = "LblPaidBy"
        Me.LblPaidBy.Size = New System.Drawing.Size(68, 24)
        Me.LblPaidBy.TabIndex = 13
        Me.LblPaidBy.Text = "PaidBy"
        '
        'TxtPaidBy
        '
        Me.TxtPaidBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPaidBy.Location = New System.Drawing.Point(190, 273)
        Me.TxtPaidBy.Name = "TxtPaidBy"
        Me.TxtPaidBy.Size = New System.Drawing.Size(279, 29)
        Me.TxtPaidBy.TabIndex = 4
        '
        'LblGrade
        '
        Me.LblGrade.AutoSize = True
        Me.LblGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGrade.Location = New System.Drawing.Point(31, 241)
        Me.LblGrade.Name = "LblGrade"
        Me.LblGrade.Size = New System.Drawing.Size(65, 24)
        Me.LblGrade.TabIndex = 11
        Me.LblGrade.Text = "Details"
        '
        'LblGender
        '
        Me.LblGender.AutoSize = True
        Me.LblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGender.Location = New System.Drawing.Point(31, 205)
        Me.LblGender.Name = "LblGender"
        Me.LblGender.Size = New System.Drawing.Size(145, 24)
        Me.LblGender.TabIndex = 5
        Me.LblGender.Text = "TypeOfPayment"
        '
        'LblDateTime
        '
        Me.LblDateTime.AutoSize = True
        Me.LblDateTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDateTime.Location = New System.Drawing.Point(183, 9)
        Me.LblDateTime.Name = "LblDateTime"
        Me.LblDateTime.Size = New System.Drawing.Size(84, 22)
        Me.LblDateTime.TabIndex = 25
        Me.LblDateTime.Text = "Date/Time"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 24)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Date/Time"
        '
        'Payments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 451)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblDateTime)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Payments"
        Me.Text = "Payments"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSave As Button
	Friend WithEvents BtnNew As Button
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents TxtAmtPaid As TextBox
	Friend WithEvents LblAmtPaid As Label
	Friend WithEvents TxtReceivedBy As TextBox
	Friend WithEvents LblReceivedBy As Label
	Friend WithEvents LblAdmno As Label
	Friend WithEvents TxtLastName As TextBox
	Friend WithEvents TxtDocumentNo As TextBox
	Friend WithEvents TxtOtherNames As TextBox
	Friend WithEvents CboTypeOfPayment As ComboBox
	Friend WithEvents LblPaidBy As Label
	Friend WithEvents TxtPaidBy As TextBox
	Friend WithEvents LblGrade As Label
	Friend WithEvents LblGender As Label
	Friend WithEvents TxtFirstName As TextBox
	Friend WithEvents LblLastName As Label
	Friend WithEvents TxtAdmno As TextBox
	Friend WithEvents BtnSearch As Button
	Friend WithEvents txtReceiptNo As TextBox
	Friend WithEvents LblReceiptNo As Label
	Friend WithEvents LblDateTime As Label
	Friend WithEvents Timer1 As Timer
	Friend WithEvents Label1 As Label
End Class
