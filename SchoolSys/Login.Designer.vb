<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TxtName = New System.Windows.Forms.TextBox()
		Me.BtnLogin = New System.Windows.Forms.Button()
		Me.TxtPassword = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(131, 47)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(55, 20)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Name"
		'
		'TxtName
		'
		Me.TxtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtName.Location = New System.Drawing.Point(268, 47)
		Me.TxtName.Name = "TxtName"
		Me.TxtName.Size = New System.Drawing.Size(187, 26)
		Me.TxtName.TabIndex = 0
		'
		'BtnLogin
		'
		Me.BtnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnLogin.Location = New System.Drawing.Point(187, 167)
		Me.BtnLogin.Name = "BtnLogin"
		Me.BtnLogin.Size = New System.Drawing.Size(187, 33)
		Me.BtnLogin.TabIndex = 2
		Me.BtnLogin.Text = "Login"
		Me.BtnLogin.UseVisualStyleBackColor = True
		'
		'TxtPassword
		'
		Me.TxtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtPassword.Location = New System.Drawing.Point(268, 102)
		Me.TxtPassword.Name = "TxtPassword"
		Me.TxtPassword.Size = New System.Drawing.Size(187, 26)
		Me.TxtPassword.TabIndex = 1
		Me.TxtPassword.UseSystemPasswordChar = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(131, 105)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(86, 20)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Password"
		'
		'Login
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(564, 277)
		Me.Controls.Add(Me.TxtPassword)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.BtnLogin)
		Me.Controls.Add(Me.TxtName)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Login"
		Me.Text = "Login"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label2 As Label
End Class
