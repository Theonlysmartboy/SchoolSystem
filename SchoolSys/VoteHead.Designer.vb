<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VoteHead
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VoteHead))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtTotalPaid = New System.Windows.Forms.TextBox()
        Me.LblTotalPaid = New System.Windows.Forms.Label()
        Me.TxtReceiptNo = New System.Windows.Forms.TextBox()
        Me.TxtVHAmount = New System.Windows.Forms.TextBox()
        Me.CboVHName = New System.Windows.Forms.ComboBox()
        Me.LblVHName = New System.Windows.Forms.Label()
        Me.LblVHAmount = New System.Windows.Forms.Label()
        Me.LblReceiptNo = New System.Windows.Forms.Label()
        Me.DgvReceipt = New System.Windows.Forms.DataGridView()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnSum = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnSave)
        Me.GroupBox2.Controls.Add(Me.BtnNew)
        Me.GroupBox2.Location = New System.Drawing.Point(233, 443)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 50)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(6, 13)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(106, 31)
        Me.BtnSave.TabIndex = 19
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.Location = New System.Drawing.Point(170, 19)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(106, 31)
        Me.BtnNew.TabIndex = 18
        Me.BtnNew.Text = "Print"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSum)
        Me.GroupBox1.Controls.Add(Me.BtnNext)
        Me.GroupBox1.Controls.Add(Me.TxtTotalPaid)
        Me.GroupBox1.Controls.Add(Me.LblTotalPaid)
        Me.GroupBox1.Controls.Add(Me.TxtReceiptNo)
        Me.GroupBox1.Controls.Add(Me.TxtVHAmount)
        Me.GroupBox1.Controls.Add(Me.CboVHName)
        Me.GroupBox1.Controls.Add(Me.LblVHName)
        Me.GroupBox1.Controls.Add(Me.LblVHAmount)
        Me.GroupBox1.Controls.Add(Me.LblReceiptNo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(509, 207)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'TxtTotalPaid
        '
        Me.TxtTotalPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPaid.Location = New System.Drawing.Point(169, 21)
        Me.TxtTotalPaid.Name = "TxtTotalPaid"
        Me.TxtTotalPaid.ReadOnly = True
        Me.TxtTotalPaid.Size = New System.Drawing.Size(216, 26)
        Me.TxtTotalPaid.TabIndex = 25
        '
        'LblTotalPaid
        '
        Me.LblTotalPaid.AutoSize = True
        Me.LblTotalPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalPaid.Location = New System.Drawing.Point(10, 24)
        Me.LblTotalPaid.Name = "LblTotalPaid"
        Me.LblTotalPaid.Size = New System.Drawing.Size(79, 20)
        Me.LblTotalPaid.TabIndex = 24
        Me.LblTotalPaid.Text = "Total Paid"
        '
        'TxtReceiptNo
        '
        Me.TxtReceiptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReceiptNo.Location = New System.Drawing.Point(169, 53)
        Me.TxtReceiptNo.Name = "TxtReceiptNo"
        Me.TxtReceiptNo.ReadOnly = True
        Me.TxtReceiptNo.Size = New System.Drawing.Size(216, 26)
        Me.TxtReceiptNo.TabIndex = 23
        '
        'TxtVHAmount
        '
        Me.TxtVHAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVHAmount.Location = New System.Drawing.Point(169, 119)
        Me.TxtVHAmount.Name = "TxtVHAmount"
        Me.TxtVHAmount.Size = New System.Drawing.Size(216, 26)
        Me.TxtVHAmount.TabIndex = 22
        '
        'CboVHName
        '
        Me.CboVHName.DisplayMember = "Male"
        Me.CboVHName.FormattingEnabled = True
        Me.CboVHName.Items.AddRange(New Object() {"Tuition ", "Boarding", "Exams", "Causion", "Actvity ", "Medical"})
        Me.CboVHName.Location = New System.Drawing.Point(169, 85)
        Me.CboVHName.Name = "CboVHName"
        Me.CboVHName.Size = New System.Drawing.Size(216, 28)
        Me.CboVHName.TabIndex = 19
        Me.CboVHName.ValueMember = "Male"
        '
        'LblVHName
        '
        Me.LblVHName.AutoSize = True
        Me.LblVHName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVHName.Location = New System.Drawing.Point(10, 88)
        Me.LblVHName.Name = "LblVHName"
        Me.LblVHName.Size = New System.Drawing.Size(82, 20)
        Me.LblVHName.TabIndex = 15
        Me.LblVHName.Text = "VoteHead"
        '
        'LblVHAmount
        '
        Me.LblVHAmount.AutoSize = True
        Me.LblVHAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVHAmount.Location = New System.Drawing.Point(10, 122)
        Me.LblVHAmount.Name = "LblVHAmount"
        Me.LblVHAmount.Size = New System.Drawing.Size(65, 20)
        Me.LblVHAmount.TabIndex = 11
        Me.LblVHAmount.Text = "Amount"
        '
        'LblReceiptNo
        '
        Me.LblReceiptNo.AutoSize = True
        Me.LblReceiptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReceiptNo.Location = New System.Drawing.Point(10, 56)
        Me.LblReceiptNo.Name = "LblReceiptNo"
        Me.LblReceiptNo.Size = New System.Drawing.Size(88, 20)
        Me.LblReceiptNo.TabIndex = 5
        Me.LblReceiptNo.Text = "Receipt No"
        '
        'DgvReceipt
        '
        Me.DgvReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvReceipt.Location = New System.Drawing.Point(591, 13)
        Me.DgvReceipt.Name = "DgvReceipt"
        Me.DgvReceipt.Size = New System.Drawing.Size(420, 497)
        Me.DgvReceipt.TabIndex = 20
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(391, 14)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(117, 33)
        Me.BtnNext.TabIndex = 26
        Me.BtnNext.Text = "Add to receipt"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnSum
        '
        Me.BtnSum.Location = New System.Drawing.Point(420, 171)
        Me.BtnSum.Name = "BtnSum"
        Me.BtnSum.Size = New System.Drawing.Size(75, 30)
        Me.BtnSum.TabIndex = 27
        Me.BtnSum.Text = "Sum"
        Me.BtnSum.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 245)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(508, 115)
        Me.TextBox1.TabIndex = 22
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'VoteHead
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 540)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DgvReceipt)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "VoteHead"
        Me.Text = "Vote Heads"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnNew As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtVHAmount As TextBox
    Friend WithEvents CboVHName As ComboBox
    Friend WithEvents LblVHName As Label
    Friend WithEvents LblVHAmount As Label
    Friend WithEvents LblReceiptNo As Label
    Friend WithEvents TxtReceiptNo As TextBox
	Friend WithEvents TxtTotalPaid As TextBox
	Friend WithEvents LblTotalPaid As Label
    Friend WithEvents DgvReceipt As DataGridView
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnSum As Button
    Friend WithEvents TextBox1 As TextBox
End Class
