<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeeAmt
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
		Me.LblOtherNames = New System.Windows.Forms.Label()
		Me.TxtTerm = New System.Windows.Forms.TextBox()
		Me.LbCode = New System.Windows.Forms.Label()
		Me.TxtCode = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TxtAmount = New System.Windows.Forms.TextBox()
		Me.LblClass = New System.Windows.Forms.Label()
		Me.TxtClass = New System.Windows.Forms.TextBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.BtnSave)
		Me.GroupBox2.Controls.Add(Me.BtnNew)
		Me.GroupBox2.Location = New System.Drawing.Point(120, 263)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(294, 50)
		Me.GroupBox2.TabIndex = 19
		Me.GroupBox2.TabStop = False
		'
		'BtnSave
		'
		Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnSave.Location = New System.Drawing.Point(176, 13)
		Me.BtnSave.Name = "BtnSave"
		Me.BtnSave.Size = New System.Drawing.Size(106, 31)
		Me.BtnSave.TabIndex = 19
		Me.BtnSave.Text = "Save"
		Me.BtnSave.UseVisualStyleBackColor = True
		'
		'BtnNew
		'
		Me.BtnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnNew.Location = New System.Drawing.Point(6, 13)
		Me.BtnNew.Name = "BtnNew"
		Me.BtnNew.Size = New System.Drawing.Size(106, 31)
		Me.BtnNew.TabIndex = 18
		Me.BtnNew.Text = "Clear"
		Me.BtnNew.UseVisualStyleBackColor = True
		'
		'LblOtherNames
		'
		Me.LblOtherNames.AutoSize = True
		Me.LblOtherNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblOtherNames.Location = New System.Drawing.Point(34, 74)
		Me.LblOtherNames.Name = "LblOtherNames"
		Me.LblOtherNames.Size = New System.Drawing.Size(55, 24)
		Me.LblOtherNames.TabIndex = 21
		Me.LblOtherNames.Text = "Term"
		'
		'TxtTerm
		'
		Me.TxtTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtTerm.Location = New System.Drawing.Point(149, 69)
		Me.TxtTerm.Name = "TxtTerm"
		Me.TxtTerm.Size = New System.Drawing.Size(183, 29)
		Me.TxtTerm.TabIndex = 3
		'
		'LbCode
		'
		Me.LbCode.AutoSize = True
		Me.LbCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbCode.Location = New System.Drawing.Point(34, 37)
		Me.LbCode.Name = "LbCode"
		Me.LbCode.Size = New System.Drawing.Size(56, 24)
		Me.LbCode.TabIndex = 27
		Me.LbCode.Text = "Code"
		'
		'TxtCode
		'
		Me.TxtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtCode.Location = New System.Drawing.Point(149, 32)
		Me.TxtCode.Name = "TxtCode"
		Me.TxtCode.Size = New System.Drawing.Size(183, 29)
		Me.TxtCode.TabIndex = 26
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(34, 109)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(76, 24)
		Me.Label2.TabIndex = 29
		Me.Label2.Text = "Amount"
		'
		'TxtAmount
		'
		Me.TxtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtAmount.Location = New System.Drawing.Point(149, 104)
		Me.TxtAmount.Name = "TxtAmount"
		Me.TxtAmount.Size = New System.Drawing.Size(183, 29)
		Me.TxtAmount.TabIndex = 28
		'
		'LblClass
		'
		Me.LblClass.AutoSize = True
		Me.LblClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblClass.Location = New System.Drawing.Point(34, 158)
		Me.LblClass.Name = "LblClass"
		Me.LblClass.Size = New System.Drawing.Size(56, 24)
		Me.LblClass.TabIndex = 35
		Me.LblClass.Text = "Code"
		'
		'TxtClass
		'
		Me.TxtClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtClass.Location = New System.Drawing.Point(149, 153)
		Me.TxtClass.Name = "TxtClass"
		Me.TxtClass.Size = New System.Drawing.Size(183, 29)
		Me.TxtClass.TabIndex = 34
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.TxtClass)
		Me.GroupBox1.Controls.Add(Me.LblClass)
		Me.GroupBox1.Controls.Add(Me.TxtAmount)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.TxtCode)
		Me.GroupBox1.Controls.Add(Me.LbCode)
		Me.GroupBox1.Controls.Add(Me.TxtTerm)
		Me.GroupBox1.Controls.Add(Me.LblOtherNames)
		Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.Location = New System.Drawing.Point(82, 33)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(373, 197)
		Me.GroupBox1.TabIndex = 18
		Me.GroupBox1.TabStop = False
		'
		'FeeAmt
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(537, 344)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "FeeAmt"
		Me.Text = " "
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnNew As Button
	Friend WithEvents LblOtherNames As Label
	Friend WithEvents TxtTerm As TextBox
	Friend WithEvents LbCode As Label
	Friend WithEvents TxtCode As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents TxtAmount As TextBox
	Friend WithEvents LblClass As Label
	Friend WithEvents TxtClass As TextBox
	Friend WithEvents GroupBox1 As GroupBox
End Class
