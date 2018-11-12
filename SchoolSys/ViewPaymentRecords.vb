Imports MySql.Data.MySqlClient
Public Class ViewPaymentRecords
    'variable for mysql connection
    Dim MysqlConn As MySqlConnection
    Dim result As Integer
    Private Sub ViewPaymentRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayPayments()
    End Sub
    Private Sub SerchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SerchToolStripMenuItem.Click
        'Hide and display relevant controls
        DgvPayments.Visible = False
        TxtAdmNo.Visible = False
        LblAdmNo.Visible = False
        BtnSearchPay.Visible = False
        LblReceipt.Visible = True
        TxtReceipt.Visible = True
        BtnSearch.Visible = True
    End Sub
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Try
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server='" & My.Settings.Server & "';user='" & My.Settings.DbUser & "';password='" & My.Settings.DbPass & "';database='" & My.Settings.Db & "';SslMode=none"
            Dim sql As String = "SELECT admno as Admission_Number,receiptno as Receipt_Number, amtpaid as Amount, typeofpayment.types as Type_of_Payment, documentno as Document_Number, paidby as Paid_By, receivedby as Recieved_By FROM payments INNER JOIN typeofpayment on type = typeofpayment.id where receiptno ='" & TxtReceipt.Text & "'"
            Dim dataadapter As New MySqlDataAdapter(sql, MysqlConn)
            Dim ds As New DataSet()
            LblReceipt.Visible = False
            TxtReceipt.Visible = False
            TxtAdmNo.Visible = False
            LblAdmNo.Visible = False
            BtnSearchPay.Visible = False
            BtnSearch.Visible = False
            DgvPayments.Visible = True
            MysqlConn.Open()
            dataadapter.Fill(ds, "payments")
            MysqlConn.Close()
            DgvPayments.DataSource = ds
            DgvPayments.DataMember = "payments"
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub ViewAllPaymentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllPaymentsToolStripMenuItem.Click
        LblReceipt.Visible = False
        TxtReceipt.Visible = False
        BtnSearch.Visible = False
        TxtAdmNo.Visible = False
        LblAdmNo.Visible = False
        BtnSearchPay.Visible = False
        DgvPayments.Visible = True
        DisplayPayments()
    End Sub
    Private Sub DisplayPayments()
        Try
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server='" & My.Settings.Server & "';user='" & My.Settings.DbUser & "';password='" & My.Settings.DbPass & "';database='" & My.Settings.Db & "';SslMode=none"
            Dim sql As String = "SELECT admno as Admission_Number,receiptno as Receipt_Number, amtpaid as Amount, typeofpayment.types as Type_of_Payment, documentno as Document_Number, paidby as Paid_By, receivedby as Recieved_By FROM payments INNER JOIN typeofpayment on type = typeofpayment.id"
            Dim dataadapter As New MySqlDataAdapter(sql, MysqlConn)
            Dim ds As New DataSet()
            MysqlConn.Open()
            dataadapter.Fill(ds, "payments")
            MysqlConn.Close()
            DgvPayments.DataSource = ds
            DgvPayments.DataMember = "payments"
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub SearchPaymetsByStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchPaymetsByStudentToolStripMenuItem.Click
        'Hide and display relevant controls
        DgvPayments.Visible = False
        TxtAdmNo.Visible = True
        LblAdmNo.Visible = True
        BtnSearchPay.Visible = True
        LblReceipt.Visible = False
        TxtReceipt.Visible = False
        BtnSearch.Visible = False
    End Sub

    Private Sub BtnSearchPay_Click(sender As Object, e As EventArgs) Handles BtnSearchPay.Click
        Try
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server='" & My.Settings.Server & "';user='" & My.Settings.DbUser & "';password='" & My.Settings.DbPass & "';database='" & My.Settings.Db & "';SslMode=none"
            Dim sql As String = "SELECT admno as Admission_Number,receiptno as Receipt_Number, amtpaid as Amount, typeofpayment.types as Type_of_Payment, documentno as Document_Number, paidby as Paid_By, receivedby as Recieved_By FROM payments INNER JOIN typeofpayment on type = typeofpayment.id where admno ='" & TxtAdmNo.Text & "'"
            Dim dataadapter As New MySqlDataAdapter(sql, MysqlConn)
            Dim ds As New DataSet()
            LblReceipt.Visible = False
            TxtReceipt.Visible = False
            TxtAdmNo.Visible = False
            LblAdmNo.Visible = False
            BtnSearchPay.Visible = False
            BtnSearch.Visible = False
            DgvPayments.Visible = True
            MysqlConn.Open()
            dataadapter.Fill(ds, "payments")
            MysqlConn.Close()
            DgvPayments.DataSource = ds
            DgvPayments.DataMember = "payments"
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
End Class