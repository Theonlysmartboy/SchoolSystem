<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TypeOfPyment
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
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.LblTypeOfPayment = New System.Windows.Forms.Label()
        Me.TxtTypeOfPayment = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(120, 151)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(86, 30)
        Me.BtnSave.TabIndex = 10
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'LblTypeOfPayment
        '
        Me.LblTypeOfPayment.AutoSize = True
        Me.LblTypeOfPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTypeOfPayment.Location = New System.Drawing.Point(104, 63)
        Me.LblTypeOfPayment.Name = "LblTypeOfPayment"
        Me.LblTypeOfPayment.Size = New System.Drawing.Size(127, 20)
        Me.LblTypeOfPayment.TabIndex = 9
        Me.LblTypeOfPayment.Text = "Type of Payment"
        '
        'TxtTypeOfPayment
        '
        Me.TxtTypeOfPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTypeOfPayment.Location = New System.Drawing.Point(76, 102)
        Me.TxtTypeOfPayment.Name = "TxtTypeOfPayment"
        Me.TxtTypeOfPayment.Size = New System.Drawing.Size(172, 26)
        Me.TxtTypeOfPayment.TabIndex = 8
        '
        'TypeOfPyment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(323, 248)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.LblTypeOfPayment)
        Me.Controls.Add(Me.TxtTypeOfPayment)
        Me.Name = "TypeOfPyment"
        Me.Text = "Type of Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSave As Button
	Friend WithEvents LblTypeOfPayment As Label
	Friend WithEvents TxtTypeOfPayment As TextBox
End Class
