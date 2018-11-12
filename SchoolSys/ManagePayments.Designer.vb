<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagePayments
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnVoteHeads = New System.Windows.Forms.Button()
        Me.TxtDop = New System.Windows.Forms.TextBox()
        Me.TxtTypeOfPayment = New System.Windows.Forms.TextBox()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.txtReceiptNo = New System.Windows.Forms.TextBox()
        Me.LblReceiptNo = New System.Windows.Forms.Label()
        Me.TxtAdmno = New System.Windows.Forms.TextBox()
        Me.TxtAmtPaid = New System.Windows.Forms.TextBox()
        Me.LblAmtPaid = New System.Windows.Forms.Label()
        Me.TxtReceivedBy = New System.Windows.Forms.TextBox()
        Me.LblReceivedBy = New System.Windows.Forms.Label()
        Me.LblAdmno = New System.Windows.Forms.Label()
        Me.TxtDocumentNo = New System.Windows.Forms.TextBox()
        Me.LblPaidBy = New System.Windows.Forms.Label()
        Me.TxtPaidBy = New System.Windows.Forms.TextBox()
        Me.LblGrade = New System.Windows.Forms.Label()
        Me.LblDop = New System.Windows.Forms.Label()
        Me.LblGender = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnVoteHeads)
        Me.GroupBox1.Controls.Add(Me.TxtDop)
        Me.GroupBox1.Controls.Add(Me.TxtTypeOfPayment)
        Me.GroupBox1.Controls.Add(Me.BtnEdit)
        Me.GroupBox1.Controls.Add(Me.BtnSearch)
        Me.GroupBox1.Controls.Add(Me.txtReceiptNo)
        Me.GroupBox1.Controls.Add(Me.LblReceiptNo)
        Me.GroupBox1.Controls.Add(Me.TxtAdmno)
        Me.GroupBox1.Controls.Add(Me.TxtAmtPaid)
        Me.GroupBox1.Controls.Add(Me.LblAmtPaid)
        Me.GroupBox1.Controls.Add(Me.TxtReceivedBy)
        Me.GroupBox1.Controls.Add(Me.LblReceivedBy)
        Me.GroupBox1.Controls.Add(Me.LblAdmno)
        Me.GroupBox1.Controls.Add(Me.TxtDocumentNo)
        Me.GroupBox1.Controls.Add(Me.LblPaidBy)
        Me.GroupBox1.Controls.Add(Me.TxtPaidBy)
        Me.GroupBox1.Controls.Add(Me.LblGrade)
        Me.GroupBox1.Controls.Add(Me.LblDop)
        Me.GroupBox1.Controls.Add(Me.LblGender)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(731, 310)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'BtnVoteHeads
        '
        Me.BtnVoteHeads.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVoteHeads.Location = New System.Drawing.Point(539, 176)
        Me.BtnVoteHeads.Name = "BtnVoteHeads"
        Me.BtnVoteHeads.Size = New System.Drawing.Size(164, 40)
        Me.BtnVoteHeads.TabIndex = 62
        Me.BtnVoteHeads.Text = "New VoteHeads"
        Me.BtnVoteHeads.UseVisualStyleBackColor = True
        '
        'TxtDop
        '
        Me.TxtDop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDop.Location = New System.Drawing.Point(189, 96)
        Me.TxtDop.Name = "TxtDop"
        Me.TxtDop.ReadOnly = True
        Me.TxtDop.Size = New System.Drawing.Size(318, 26)
        Me.TxtDop.TabIndex = 63
        '
        'TxtTypeOfPayment
        '
        Me.TxtTypeOfPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTypeOfPayment.Location = New System.Drawing.Point(189, 161)
        Me.TxtTypeOfPayment.Name = "TxtTypeOfPayment"
        Me.TxtTypeOfPayment.ReadOnly = True
        Me.TxtTypeOfPayment.Size = New System.Drawing.Size(318, 26)
        Me.TxtTypeOfPayment.TabIndex = 62
        '
        'BtnEdit
        '
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Location = New System.Drawing.Point(539, 99)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(164, 40)
        Me.BtnEdit.TabIndex = 61
        Me.BtnEdit.Text = "Cancel Receipt"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.Location = New System.Drawing.Point(539, 32)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(164, 40)
        Me.BtnSearch.TabIndex = 60
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.Location = New System.Drawing.Point(190, 32)
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(317, 26)
        Me.txtReceiptNo.TabIndex = 0
        '
        'LblReceiptNo
        '
        Me.LblReceiptNo.AutoSize = True
        Me.LblReceiptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReceiptNo.Location = New System.Drawing.Point(30, 35)
        Me.LblReceiptNo.Name = "LblReceiptNo"
        Me.LblReceiptNo.Size = New System.Drawing.Size(84, 20)
        Me.LblReceiptNo.TabIndex = 52
        Me.LblReceiptNo.Text = "ReceiptNo"
        '
        'TxtAdmno
        '
        Me.TxtAdmno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdmno.Location = New System.Drawing.Point(189, 64)
        Me.TxtAdmno.Name = "TxtAdmno"
        Me.TxtAdmno.ReadOnly = True
        Me.TxtAdmno.Size = New System.Drawing.Size(318, 26)
        Me.TxtAdmno.TabIndex = 33
        '
        'TxtAmtPaid
        '
        Me.TxtAmtPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmtPaid.Location = New System.Drawing.Point(189, 129)
        Me.TxtAmtPaid.Name = "TxtAmtPaid"
        Me.TxtAmtPaid.ReadOnly = True
        Me.TxtAmtPaid.Size = New System.Drawing.Size(318, 26)
        Me.TxtAmtPaid.TabIndex = 35
        '
        'LblAmtPaid
        '
        Me.LblAmtPaid.AutoSize = True
        Me.LblAmtPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmtPaid.Location = New System.Drawing.Point(30, 132)
        Me.LblAmtPaid.Name = "LblAmtPaid"
        Me.LblAmtPaid.Size = New System.Drawing.Size(100, 20)
        Me.LblAmtPaid.TabIndex = 51
        Me.LblAmtPaid.Text = "Amount Paid"
        '
        'TxtReceivedBy
        '
        Me.TxtReceivedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReceivedBy.Location = New System.Drawing.Point(189, 257)
        Me.TxtReceivedBy.Name = "TxtReceivedBy"
        Me.TxtReceivedBy.ReadOnly = True
        Me.TxtReceivedBy.Size = New System.Drawing.Size(318, 26)
        Me.TxtReceivedBy.TabIndex = 42
        '
        'LblReceivedBy
        '
        Me.LblReceivedBy.AutoSize = True
        Me.LblReceivedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReceivedBy.Location = New System.Drawing.Point(30, 260)
        Me.LblReceivedBy.Name = "LblReceivedBy"
        Me.LblReceivedBy.Size = New System.Drawing.Size(93, 20)
        Me.LblReceivedBy.TabIndex = 50
        Me.LblReceivedBy.Text = "ReceivedBy"
        '
        'LblAdmno
        '
        Me.LblAdmno.AutoSize = True
        Me.LblAdmno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdmno.Location = New System.Drawing.Point(30, 67)
        Me.LblAdmno.Name = "LblAdmno"
        Me.LblAdmno.Size = New System.Drawing.Size(60, 20)
        Me.LblAdmno.TabIndex = 49
        Me.LblAdmno.Text = "Admno"
        '
        'TxtDocumentNo
        '
        Me.TxtDocumentNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDocumentNo.Location = New System.Drawing.Point(189, 193)
        Me.TxtDocumentNo.Name = "TxtDocumentNo"
        Me.TxtDocumentNo.ReadOnly = True
        Me.TxtDocumentNo.Size = New System.Drawing.Size(318, 26)
        Me.TxtDocumentNo.TabIndex = 38
        '
        'LblPaidBy
        '
        Me.LblPaidBy.AutoSize = True
        Me.LblPaidBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaidBy.Location = New System.Drawing.Point(30, 228)
        Me.LblPaidBy.Name = "LblPaidBy"
        Me.LblPaidBy.Size = New System.Drawing.Size(58, 20)
        Me.LblPaidBy.TabIndex = 45
        Me.LblPaidBy.Text = "PaidBy"
        '
        'TxtPaidBy
        '
        Me.TxtPaidBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPaidBy.Location = New System.Drawing.Point(189, 225)
        Me.TxtPaidBy.Name = "TxtPaidBy"
        Me.TxtPaidBy.ReadOnly = True
        Me.TxtPaidBy.Size = New System.Drawing.Size(318, 26)
        Me.TxtPaidBy.TabIndex = 40
        '
        'LblGrade
        '
        Me.LblGrade.AutoSize = True
        Me.LblGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGrade.Location = New System.Drawing.Point(30, 196)
        Me.LblGrade.Name = "LblGrade"
        Me.LblGrade.Size = New System.Drawing.Size(58, 20)
        Me.LblGrade.TabIndex = 44
        Me.LblGrade.Text = "Details"
        '
        'LblDop
        '
        Me.LblDop.AutoSize = True
        Me.LblDop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDop.Location = New System.Drawing.Point(30, 99)
        Me.LblDop.Name = "LblDop"
        Me.LblDop.Size = New System.Drawing.Size(44, 20)
        Me.LblDop.TabIndex = 43
        Me.LblDop.Text = "Date"
        '
        'LblGender
        '
        Me.LblGender.AutoSize = True
        Me.LblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGender.Location = New System.Drawing.Point(30, 164)
        Me.LblGender.Name = "LblGender"
        Me.LblGender.Size = New System.Drawing.Size(122, 20)
        Me.LblGender.TabIndex = 41
        Me.LblGender.Text = "TypeOfPayment"
        '
        'ManagePayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 394)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ManagePayments"
        Me.Text = "ManagePayments"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents txtReceiptNo As TextBox
	Friend WithEvents LblReceiptNo As Label
	Friend WithEvents TxtAdmno As TextBox
	Friend WithEvents TxtAmtPaid As TextBox
	Friend WithEvents LblAmtPaid As Label
	Friend WithEvents TxtReceivedBy As TextBox
	Friend WithEvents LblReceivedBy As Label
	Friend WithEvents LblAdmno As Label
	Friend WithEvents TxtDocumentNo As TextBox
	Friend WithEvents LblPaidBy As Label
	Friend WithEvents TxtPaidBy As TextBox
	Friend WithEvents LblGrade As Label
	Friend WithEvents LblDop As Label
	Friend WithEvents LblGender As Label
	Friend WithEvents BtnEdit As Button
	Friend WithEvents BtnSearch As Button
	Friend WithEvents TxtTypeOfPayment As TextBox
	Friend WithEvents TxtDop As TextBox
	Friend WithEvents BtnVoteHeads As Button
End Class
