<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewPaymentRecords
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
        Me.DgvPayments = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SerchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtReceipt = New System.Windows.Forms.TextBox()
        Me.LblReceipt = New System.Windows.Forms.Label()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.ViewAllPaymentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchPaymetsByStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnSearchPay = New System.Windows.Forms.Button()
        Me.LblAdmNo = New System.Windows.Forms.Label()
        Me.TxtAdmNo = New System.Windows.Forms.TextBox()
        CType(Me.DgvPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvPayments
        '
        Me.DgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPayments.Location = New System.Drawing.Point(39, 43)
        Me.DgvPayments.Name = "DgvPayments"
        Me.DgvPayments.Size = New System.Drawing.Size(941, 600)
        Me.DgvPayments.TabIndex = 21
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SerchToolStripMenuItem, Me.SearchPaymetsByStudentToolStripMenuItem, Me.ViewAllPaymentsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 24)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SerchToolStripMenuItem
        '
        Me.SerchToolStripMenuItem.Name = "SerchToolStripMenuItem"
        Me.SerchToolStripMenuItem.Size = New System.Drawing.Size(167, 20)
        Me.SerchToolStripMenuItem.Text = "Search Payments By Receipt"
        '
        'TxtReceipt
        '
        Me.TxtReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReceipt.Location = New System.Drawing.Point(457, 122)
        Me.TxtReceipt.Name = "TxtReceipt"
        Me.TxtReceipt.Size = New System.Drawing.Size(246, 29)
        Me.TxtReceipt.TabIndex = 23
        Me.TxtReceipt.Visible = False
        '
        'LblReceipt
        '
        Me.LblReceipt.AutoSize = True
        Me.LblReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReceipt.Location = New System.Drawing.Point(274, 129)
        Me.LblReceipt.Name = "LblReceipt"
        Me.LblReceipt.Size = New System.Drawing.Size(162, 24)
        Me.LblReceipt.TabIndex = 24
        Me.LblReceipt.Text = "Receipt Number"
        Me.LblReceipt.Visible = False
        '
        'BtnSearch
        '
        Me.BtnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.Location = New System.Drawing.Point(457, 203)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(88, 35)
        Me.BtnSearch.TabIndex = 25
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        Me.BtnSearch.Visible = False
        '
        'ViewAllPaymentsToolStripMenuItem
        '
        Me.ViewAllPaymentsToolStripMenuItem.Name = "ViewAllPaymentsToolStripMenuItem"
        Me.ViewAllPaymentsToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.ViewAllPaymentsToolStripMenuItem.Text = "View All Payments"
        '
        'SearchPaymetsByStudentToolStripMenuItem
        '
        Me.SearchPaymetsByStudentToolStripMenuItem.Name = "SearchPaymetsByStudentToolStripMenuItem"
        Me.SearchPaymetsByStudentToolStripMenuItem.Size = New System.Drawing.Size(161, 20)
        Me.SearchPaymetsByStudentToolStripMenuItem.Text = "Search paymets By student"
        '
        'BtnSearchPay
        '
        Me.BtnSearchPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchPay.Location = New System.Drawing.Point(461, 354)
        Me.BtnSearchPay.Name = "BtnSearchPay"
        Me.BtnSearchPay.Size = New System.Drawing.Size(88, 35)
        Me.BtnSearchPay.TabIndex = 28
        Me.BtnSearchPay.Text = "Search"
        Me.BtnSearchPay.UseVisualStyleBackColor = True
        Me.BtnSearchPay.Visible = False
        '
        'LblAdmNo
        '
        Me.LblAdmNo.AutoSize = True
        Me.LblAdmNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdmNo.Location = New System.Drawing.Point(278, 280)
        Me.LblAdmNo.Name = "LblAdmNo"
        Me.LblAdmNo.Size = New System.Drawing.Size(188, 24)
        Me.LblAdmNo.TabIndex = 27
        Me.LblAdmNo.Text = "Admission Number"
        Me.LblAdmNo.Visible = False
        '
        'TxtAdmNo
        '
        Me.TxtAdmNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdmNo.Location = New System.Drawing.Point(496, 277)
        Me.TxtAdmNo.Name = "TxtAdmNo"
        Me.TxtAdmNo.Size = New System.Drawing.Size(246, 29)
        Me.TxtAdmNo.TabIndex = 26
        Me.TxtAdmNo.Visible = False
        '
        'ViewPaymentRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.BtnSearchPay)
        Me.Controls.Add(Me.LblAdmNo)
        Me.Controls.Add(Me.TxtAdmNo)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.LblReceipt)
        Me.Controls.Add(Me.TxtReceipt)
        Me.Controls.Add(Me.DgvPayments)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ViewPaymentRecords"
        Me.Text = "ViewPaymentRecords"
        CType(Me.DgvPayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvPayments As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SerchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtReceipt As TextBox
    Friend WithEvents LblReceipt As Label
    Friend WithEvents BtnSearch As Button
    Friend WithEvents ViewAllPaymentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchPaymetsByStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnSearchPay As Button
    Friend WithEvents LblAdmNo As Label
    Friend WithEvents TxtAdmNo As TextBox
End Class
