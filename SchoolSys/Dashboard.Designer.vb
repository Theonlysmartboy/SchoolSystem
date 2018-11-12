<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CSTEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StreamsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TermsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TypeOfPaymentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdmissionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentAdmissionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParentGuardiansToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TypeOfPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancedOperationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageClasesStreamsTermsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageAdmissionRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManagePaymentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageParentsAndGuardiansToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageVoteHeadsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeeAmountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeePaymentReposrtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentsReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CSTEntryToolStripMenuItem, Me.AdmissionsToolStripMenuItem, Me.PaymentsToolStripMenuItem, Me.AdvancedOperationsToolStripMenuItem, Me.FeeAmountToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(940, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CSTEntryToolStripMenuItem
        '
        Me.CSTEntryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClassesToolStripMenuItem, Me.StreamsToolStripMenuItem, Me.TermsToolStripMenuItem, Me.TypeOfPaymentsToolStripMenuItem})
        Me.CSTEntryToolStripMenuItem.Name = "CSTEntryToolStripMenuItem"
        Me.CSTEntryToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.CSTEntryToolStripMenuItem.Text = "CSTP Entry"
        '
        'ClassesToolStripMenuItem
        '
        Me.ClassesToolStripMenuItem.Name = "ClassesToolStripMenuItem"
        Me.ClassesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClassesToolStripMenuItem.Text = "Classes"
        '
        'StreamsToolStripMenuItem
        '
        Me.StreamsToolStripMenuItem.Name = "StreamsToolStripMenuItem"
        Me.StreamsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StreamsToolStripMenuItem.Text = "Streams"
        '
        'TermsToolStripMenuItem
        '
        Me.TermsToolStripMenuItem.Name = "TermsToolStripMenuItem"
        Me.TermsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TermsToolStripMenuItem.Text = "Terms"
        '
        'TypeOfPaymentsToolStripMenuItem
        '
        Me.TypeOfPaymentsToolStripMenuItem.Name = "TypeOfPaymentsToolStripMenuItem"
        Me.TypeOfPaymentsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TypeOfPaymentsToolStripMenuItem.Text = "Type of Payments"
        '
        'AdmissionsToolStripMenuItem
        '
        Me.AdmissionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentAdmissionsToolStripMenuItem, Me.ParentGuardiansToolStripMenuItem})
        Me.AdmissionsToolStripMenuItem.Name = "AdmissionsToolStripMenuItem"
        Me.AdmissionsToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.AdmissionsToolStripMenuItem.Text = "Admissions"
        '
        'StudentAdmissionsToolStripMenuItem
        '
        Me.StudentAdmissionsToolStripMenuItem.Name = "StudentAdmissionsToolStripMenuItem"
        Me.StudentAdmissionsToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.StudentAdmissionsToolStripMenuItem.Text = "Student Details"
        '
        'ParentGuardiansToolStripMenuItem
        '
        Me.ParentGuardiansToolStripMenuItem.Name = "ParentGuardiansToolStripMenuItem"
        Me.ParentGuardiansToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ParentGuardiansToolStripMenuItem.Text = "Parent/Guardians"
        '
        'PaymentsToolStripMenuItem
        '
        Me.PaymentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TypeOfPaymentToolStripMenuItem, Me.FeeToolStripMenuItem})
        Me.PaymentsToolStripMenuItem.Name = "PaymentsToolStripMenuItem"
        Me.PaymentsToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.PaymentsToolStripMenuItem.Text = "Payments"
        '
        'TypeOfPaymentToolStripMenuItem
        '
        Me.TypeOfPaymentToolStripMenuItem.Name = "TypeOfPaymentToolStripMenuItem"
        Me.TypeOfPaymentToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.TypeOfPaymentToolStripMenuItem.Text = "Fee"
        '
        'FeeToolStripMenuItem
        '
        Me.FeeToolStripMenuItem.Name = "FeeToolStripMenuItem"
        Me.FeeToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.FeeToolStripMenuItem.Text = "Other Payments"
        '
        'AdvancedOperationsToolStripMenuItem
        '
        Me.AdvancedOperationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageClasesStreamsTermsToolStripMenuItem, Me.ManageAdmissionRecordsToolStripMenuItem, Me.ManagePaymentsToolStripMenuItem, Me.ManageParentsAndGuardiansToolStripMenuItem, Me.ManageStudentsToolStripMenuItem, Me.ManageVoteHeadsToolStripMenuItem})
        Me.AdvancedOperationsToolStripMenuItem.Name = "AdvancedOperationsToolStripMenuItem"
        Me.AdvancedOperationsToolStripMenuItem.Size = New System.Drawing.Size(133, 20)
        Me.AdvancedOperationsToolStripMenuItem.Text = "Advanced Operations"
        '
        'ManageClasesStreamsTermsToolStripMenuItem
        '
        Me.ManageClasesStreamsTermsToolStripMenuItem.Name = "ManageClasesStreamsTermsToolStripMenuItem"
        Me.ManageClasesStreamsTermsToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.ManageClasesStreamsTermsToolStripMenuItem.Text = "Manage Classes/Streams/Terms"
        '
        'ManageAdmissionRecordsToolStripMenuItem
        '
        Me.ManageAdmissionRecordsToolStripMenuItem.Name = "ManageAdmissionRecordsToolStripMenuItem"
        Me.ManageAdmissionRecordsToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.ManageAdmissionRecordsToolStripMenuItem.Text = "Manage Admission Records"
        '
        'ManagePaymentsToolStripMenuItem
        '
        Me.ManagePaymentsToolStripMenuItem.Name = "ManagePaymentsToolStripMenuItem"
        Me.ManagePaymentsToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.ManagePaymentsToolStripMenuItem.Text = "Manage Payments"
        '
        'ManageParentsAndGuardiansToolStripMenuItem
        '
        Me.ManageParentsAndGuardiansToolStripMenuItem.Name = "ManageParentsAndGuardiansToolStripMenuItem"
        Me.ManageParentsAndGuardiansToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.ManageParentsAndGuardiansToolStripMenuItem.Text = "Manage Parents and Guardians"
        '
        'ManageStudentsToolStripMenuItem
        '
        Me.ManageStudentsToolStripMenuItem.Name = "ManageStudentsToolStripMenuItem"
        Me.ManageStudentsToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.ManageStudentsToolStripMenuItem.Text = "Manage Students"
        '
        'ManageVoteHeadsToolStripMenuItem
        '
        Me.ManageVoteHeadsToolStripMenuItem.Name = "ManageVoteHeadsToolStripMenuItem"
        Me.ManageVoteHeadsToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.ManageVoteHeadsToolStripMenuItem.Text = "Manage VoteHeads"
        '
        'FeeAmountToolStripMenuItem
        '
        Me.FeeAmountToolStripMenuItem.Name = "FeeAmountToolStripMenuItem"
        Me.FeeAmountToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.FeeAmountToolStripMenuItem.Text = "Fee Amount"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FeePaymentReposrtToolStripMenuItem, Me.StudentsReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'FeePaymentReposrtToolStripMenuItem
        '
        Me.FeePaymentReposrtToolStripMenuItem.Name = "FeePaymentReposrtToolStripMenuItem"
        Me.FeePaymentReposrtToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FeePaymentReposrtToolStripMenuItem.Text = "Fee payment Report"
        '
        'StudentsReportToolStripMenuItem
        '
        Me.StudentsReportToolStripMenuItem.Name = "StudentsReportToolStripMenuItem"
        Me.StudentsReportToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StudentsReportToolStripMenuItem.Text = "Students Report"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(940, 471)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents CSTEntryToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ClassesToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents StreamsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents TermsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents TypeOfPaymentsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AdmissionsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents StudentAdmissionsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ParentGuardiansToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PaymentsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents TypeOfPaymentToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents FeeToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AdvancedOperationsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ManageClasesStreamsTermsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ManageAdmissionRecordsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ManagePaymentsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents FeeAmountToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ManageParentsAndGuardiansToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ManageStudentsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ManageVoteHeadsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeePaymentReposrtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentsReportToolStripMenuItem As ToolStripMenuItem
End Class
