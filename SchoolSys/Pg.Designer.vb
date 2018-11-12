<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pg
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
        Me.LblGrade = New System.Windows.Forms.Label()
        Me.LblEmailAddress = New System.Windows.Forms.Label()
        Me.TxtDescription = New System.Windows.Forms.TextBox()
        Me.LblPhoneNo = New System.Windows.Forms.Label()
        Me.LblDescription = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.TxtPhoneNo = New System.Windows.Forms.TextBox()
        Me.TxtEmailAddress = New System.Windows.Forms.TextBox()
        Me.TxtAdmno = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblGrade
        '
        Me.LblGrade.AutoSize = True
        Me.LblGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGrade.Location = New System.Drawing.Point(19, 31)
        Me.LblGrade.Name = "LblGrade"
        Me.LblGrade.Size = New System.Drawing.Size(60, 20)
        Me.LblGrade.TabIndex = 28
        Me.LblGrade.Text = "Admno"
        '
        'LblEmailAddress
        '
        Me.LblEmailAddress.AutoSize = True
        Me.LblEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmailAddress.Location = New System.Drawing.Point(19, 191)
        Me.LblEmailAddress.Name = "LblEmailAddress"
        Me.LblEmailAddress.Size = New System.Drawing.Size(111, 20)
        Me.LblEmailAddress.TabIndex = 27
        Me.LblEmailAddress.Text = "Email Address"
        '
        'TxtDescription
        '
        Me.TxtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescription.Location = New System.Drawing.Point(178, 123)
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(341, 26)
        Me.TxtDescription.TabIndex = 26
        '
        'LblPhoneNo
        '
        Me.LblPhoneNo.AutoSize = True
        Me.LblPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPhoneNo.Location = New System.Drawing.Point(19, 151)
        Me.LblPhoneNo.Name = "LblPhoneNo"
        Me.LblPhoneNo.Size = New System.Drawing.Size(79, 20)
        Me.LblPhoneNo.TabIndex = 25
        Me.LblPhoneNo.Text = "Phone No"
        '
        'LblDescription
        '
        Me.LblDescription.AccessibleRole = System.Windows.Forms.AccessibleRole.Document
        Me.LblDescription.AutoSize = True
        Me.LblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescription.Location = New System.Drawing.Point(19, 111)
        Me.LblDescription.Name = "LblDescription"
        Me.LblDescription.Size = New System.Drawing.Size(89, 20)
        Me.LblDescription.TabIndex = 24
        Me.LblDescription.Text = "Description"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.Location = New System.Drawing.Point(19, 71)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(51, 20)
        Me.LblName.TabIndex = 23
        Me.LblName.Text = "Name"
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(178, 83)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(341, 26)
        Me.TxtName.TabIndex = 22
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(377, 267)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(95, 31)
        Me.BtnSave.TabIndex = 41
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(131, 267)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(95, 31)
        Me.BtnClear.TabIndex = 36
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'TxtPhoneNo
        '
        Me.TxtPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPhoneNo.Location = New System.Drawing.Point(178, 163)
        Me.TxtPhoneNo.Name = "TxtPhoneNo"
        Me.TxtPhoneNo.Size = New System.Drawing.Size(341, 26)
        Me.TxtPhoneNo.TabIndex = 42
        '
        'TxtEmailAddress
        '
        Me.TxtEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmailAddress.Location = New System.Drawing.Point(178, 203)
        Me.TxtEmailAddress.Name = "TxtEmailAddress"
        Me.TxtEmailAddress.Size = New System.Drawing.Size(341, 26)
        Me.TxtEmailAddress.TabIndex = 43
        '
        'TxtAdmno
        '
        Me.TxtAdmno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdmno.Location = New System.Drawing.Point(178, 43)
        Me.TxtAdmno.Name = "TxtAdmno"
        Me.TxtAdmno.Size = New System.Drawing.Size(341, 26)
        Me.TxtAdmno.TabIndex = 44
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.BtnClear)
        Me.GroupBox1.Controls.Add(Me.LblDescription)
        Me.GroupBox1.Controls.Add(Me.LblGrade)
        Me.GroupBox1.Controls.Add(Me.LblName)
        Me.GroupBox1.Controls.Add(Me.LblEmailAddress)
        Me.GroupBox1.Controls.Add(Me.LblPhoneNo)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(522, 313)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        '
        'Pg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 352)
        Me.Controls.Add(Me.TxtAdmno)
        Me.Controls.Add(Me.TxtEmailAddress)
        Me.Controls.Add(Me.TxtPhoneNo)
        Me.Controls.Add(Me.TxtDescription)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Pg"
        Me.Text = "Parents/Guardian Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblGrade As Label
    Friend WithEvents LblEmailAddress As Label
    Friend WithEvents TxtDescription As TextBox
    Friend WithEvents LblPhoneNo As Label
    Friend WithEvents LblDescription As Label
    Friend WithEvents LblName As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents TxtPhoneNo As TextBox
    Friend WithEvents TxtEmailAddress As TextBox
    Friend WithEvents TxtAdmno As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
