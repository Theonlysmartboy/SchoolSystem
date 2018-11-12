<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Classes
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
		Me.LblNewClass = New System.Windows.Forms.Label()
		Me.TxtName = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TxtSymbol = New System.Windows.Forms.TextBox()
		Me.LblStream = New System.Windows.Forms.Label()
		Me.CboStream = New System.Windows.Forms.ComboBox()
		Me.SuspendLayout()
		'
		'BtnSave
		'
		Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnSave.Location = New System.Drawing.Point(122, 206)
		Me.BtnSave.Name = "BtnSave"
		Me.BtnSave.Size = New System.Drawing.Size(86, 30)
		Me.BtnSave.TabIndex = 7
		Me.BtnSave.Text = "Save"
		Me.BtnSave.UseVisualStyleBackColor = True
		'
		'LblNewClass
		'
		Me.LblNewClass.AutoSize = True
		Me.LblNewClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblNewClass.Location = New System.Drawing.Point(33, 31)
		Me.LblNewClass.Name = "LblNewClass"
		Me.LblNewClass.Size = New System.Drawing.Size(51, 20)
		Me.LblNewClass.TabIndex = 6
		Me.LblNewClass.Text = "Name"
		'
		'TxtName
		'
		Me.TxtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtName.Location = New System.Drawing.Point(122, 31)
		Me.TxtName.Name = "TxtName"
		Me.TxtName.Size = New System.Drawing.Size(172, 26)
		Me.TxtName.TabIndex = 5
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(33, 73)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(61, 20)
		Me.Label1.TabIndex = 9
		Me.Label1.Text = "Symbol"
		'
		'TxtSymbol
		'
		Me.TxtSymbol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtSymbol.Location = New System.Drawing.Point(122, 73)
		Me.TxtSymbol.Name = "TxtSymbol"
		Me.TxtSymbol.Size = New System.Drawing.Size(172, 26)
		Me.TxtSymbol.TabIndex = 8
		'
		'LblStream
		'
		Me.LblStream.AutoSize = True
		Me.LblStream.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblStream.Location = New System.Drawing.Point(33, 126)
		Me.LblStream.Name = "LblStream"
		Me.LblStream.Size = New System.Drawing.Size(61, 20)
		Me.LblStream.TabIndex = 10
		Me.LblStream.Text = "Stream"
		'
		'CboStream
		'
		Me.CboStream.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CboStream.FormattingEnabled = True
		Me.CboStream.Location = New System.Drawing.Point(122, 123)
		Me.CboStream.Name = "CboStream"
		Me.CboStream.Size = New System.Drawing.Size(172, 28)
		Me.CboStream.TabIndex = 11
		'
		'Classes
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(339, 268)
		Me.Controls.Add(Me.CboStream)
		Me.Controls.Add(Me.LblStream)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.TxtSymbol)
		Me.Controls.Add(Me.BtnSave)
		Me.Controls.Add(Me.LblNewClass)
		Me.Controls.Add(Me.TxtName)
		Me.Name = "Classes"
		Me.Text = "Classes"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents BtnSave As Button
    Friend WithEvents LblNewClass As Label
    Friend WithEvents TxtName As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents TxtSymbol As TextBox
	Friend WithEvents LblStream As Label
	Friend WithEvents CboStream As ComboBox
End Class
