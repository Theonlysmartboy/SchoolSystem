Public Class Dashboard
    Private Sub ClassesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassesToolStripMenuItem.Click
        Classes.Show()
    End Sub
    Private Sub StreamsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StreamsToolStripMenuItem.Click
        Stream.Show()
    End Sub
    Private Sub TermsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TermsToolStripMenuItem.Click
        Term.Show()
    End Sub
    Private Sub TypeOfPaymentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TypeOfPaymentsToolStripMenuItem.Click
        TypeOfPyment.Show()
    End Sub
    Private Sub ManageClasesStreamsTermsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageClasesStreamsTermsToolStripMenuItem.Click
        FrmEditDeleteClassStreamTerm.Show()
    End Sub
    Private Sub TypeOfPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TypeOfPaymentToolStripMenuItem.Click
        Payments.Show()
    End Sub
    Private Sub StudentAdmissionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentAdmissionsToolStripMenuItem.Click
        Student.Show()
    End Sub
    Private Sub ParentGuardiansToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParentGuardiansToolStripMenuItem.Click
        Pg.Show()
    End Sub
    Private Sub ManageAdmissionRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageAdmissionRecordsToolStripMenuItem.Click
        ManageStudent.Show()
    End Sub
    Private Sub ManagePaymentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManagePaymentsToolStripMenuItem.Click
        ManagePayments.Show()
    End Sub
    Private Sub FeeAmountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeeAmountToolStripMenuItem.Click
        FeeAmt.Show()
    End Sub
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ManageParentsAndGuardiansToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageParentsAndGuardiansToolStripMenuItem.Click
        ManagePG.Show()
    End Sub
    Private Sub ManageStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageStudentsToolStripMenuItem.Click
        ManageStudent.Show()
    End Sub
    Private Sub FeePaymentReposrtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeePaymentReposrtToolStripMenuItem.Click
        ViewPaymentRecords.Show()
    End Sub
    Private Sub StudentsReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentsReportToolStripMenuItem.Click
        VIewStudentRecords.Show()
    End Sub
End Class