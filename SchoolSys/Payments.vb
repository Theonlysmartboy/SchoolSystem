Imports MySql.Data.MySqlClient
Public Class Payments
	Dim result As Integer
	Dim myConnection As MySqlConnection
    Dim myCommand As MySqlCommand
    Public Shared receiptno As Integer
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
		Authenticate()
	End Sub
	Private Sub Authenticate()
		If TxtAdmno.Text = "" And TxtPaidBy.Text = "" And TxtReceivedBy.Text = "" Then
			result = MessageBox.Show("All Fields are Empty. Fill Them and try again", "Error", MessageBoxButtons.OKCancel)
			If result = DialogResult.OK Then
				Me.Show()
				TxtLastName.Focus()
			Else
				Me.Close()
			End If
		ElseIf TxtAdmno.Text = "" Then
			result = MessageBox.Show("Enter Admission Number", "Error", MessageBoxButtons.OKCancel)
			If result = DialogResult.OK Then
				Me.Show()
				TxtAdmno.Focus()
			Else
				Me.Close()
			End If
		ElseIf TxtPaidBy.Text = "" Then
			result = MessageBox.Show("Enter Paid By Info", "Error", MessageBoxButtons.OKCancel)
			If result = DialogResult.OK Then
				Me.Show()
				TxtPaidBy.Focus()
			Else
				Me.Close()
			End If
		ElseIf TxtReceivedBy.Text = "" Then
			result = MessageBox.Show("Enter Received By Info", "Error", MessageBoxButtons.OKCancel)
			If result = DialogResult.OK Then
				Me.Show()
				TxtReceivedBy.Focus()
			Else
				Me.Close()
			End If
		Else
			Save()
		End If
	End Sub
    Private Sub Save()
        Dim query As String = String.Empty
        query &= "INSERT INTO payments(receiptno,admno, amtpaid, type, documentno, paidby, receivedby)"
        query &= " VALUES (@receiptno,@admno, @amtPaid, @type, @documentno, @paidby, @receivedby)"
        Using MyConnection As New MySqlConnection("server='" & My.Settings.Server & "';user='" & My.Settings.DbUser & "';password='" & My.Settings.DbPass & "';database='" & My.Settings.Db & "';SslMode=none")
            Using MyCommand As New MySqlCommand()
                With MyCommand
                    .Connection = MyConnection
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@receiptno", txtReceiptNo.Text)
                    .Parameters.AddWithValue("@admno", TxtAdmno.Text)
                    .Parameters.AddWithValue("@amtpaid", TxtAmtPaid.Text)
                    .Parameters.AddWithValue("@type", CboTypeOfPayment.SelectedValue)
                    .Parameters.AddWithValue("@documentno", TxtDocumentNo.Text)
                    .Parameters.AddWithValue("@paidby", TxtPaidBy.Text)
                    .Parameters.AddWithValue("@receivedby", TxtReceivedBy.Text)
                End With
                Try
                    MyConnection.Open()
                    MyCommand.ExecuteNonQuery()
                    MessageBox.Show("Save Successful", "Success")
                    VoteHead.Show()
                    VoteHead.TxtReceiptNo.Text = txtReceiptNo.Text
                    VoteHead.TxtTotalPaid.Text = TxtAmtPaid.Text
                    Me.Close()
                Catch e As MySqlException
                    MessageBox.Show(e.Message.ToString(), "Error")
                Finally
                    MyConnection.Close()
                    MyConnection.Dispose()
                End Try
            End Using
        End Using
    End Sub
    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        ClearFields()
    End Sub
    Private Sub ClearFields()
		TxtAmtPaid.Clear()
		TxtDocumentNo.Clear()
		TxtPaidBy.Clear()
		TxtReceivedBy.Clear()
	End Sub
    Public Sub FrmPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        CboTypeOfPayment.DataSource = GetTypeofPaymentItem()
        CboTypeOfPayment.DisplayMember = "types"
        CboTypeOfPayment.ValueMember = "id"
        myConnection = New MySqlConnection
        myConnection.ConnectionString = "server='" & My.Settings.Server & "';user='" & My.Settings.DbUser & "';password='" & My.Settings.DbPass & "';database='" & My.Settings.Db & "';SslMode=none"
        Dim reader As MySqlDataReader
        Try
            myConnection.Open()
            Dim query As String = String.Empty
            query &= "select tempno from tempreceiptno where id=0"
            myCommand = New MySqlCommand(query, myConnection)
            reader = myCommand.ExecuteReader
            Dim found As Boolean = False
            While reader.Read
                found = True
            End While
            If found = True Then
                receiptno = reader("tempno")
                txtReceiptNo.Text = "SCS/" & receiptno & "/18"
                'query &= "UPDATE tempreceiptno SET tempno='" & txtReceiptNo.Text & "' WHERE tempno='" & txtReceiptNo.Text & "'"
            Else
                If result = DialogResult.OK Then
                    Me.Show()
                Else
                    Me.Close()
                End If
            End If
            myConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            myConnection.Dispose()
        End Try
    End Sub
    Function GetTypeofPaymentItem() As List(Of TypeofPaymentItem)
		Dim streamItems = New List(Of TypeofPaymentItem)
		Dim reader As MySqlDataReader
		myConnection = New MySqlConnection
        myConnection.ConnectionString = "server='" & My.Settings.Server & "';user='" & My.Settings.DbUser & "';password='" & My.Settings.DbPass & "';database='" & My.Settings.Db & "';SslMode=none"
        Dim sql As String = "Select id, types from typeofpayment"
		myConnection.Open()
		Dim Command As New MySqlCommand(sql, myConnection)
		Command.CommandTimeout = 30
		reader = Command.ExecuteReader
		If reader.HasRows = True Then
			While reader.Read()
				streamItems.Add(New TypeofPaymentItem(reader("id"), reader("types")))
			End While
			myConnection.Close()
			myConnection.Dispose()
		End If
		Return streamItems
	End Function
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
		Try
			myConnection.Open()
			Dim query As String = String.Empty
			Dim reader As MySqlDataReader
			Dim found As Boolean = False
			query &= "Select firstname, lastname, othernames from student where admno='" & TxtAdmno.Text & "'"
			myCommand = New MySqlCommand(query, myConnection)
			reader = myCommand.ExecuteReader
			While reader.Read
				found = True
			End While
			If found = True Then
				TxtFirstName.Text = reader("firstname")
				TxtLastName.Text = reader("lastname")
				TxtOtherNames.Text = reader("othernames")
			Else MessageBox.Show("Student Not Found", "Error: Not found")
			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		Finally
			myConnection.Close()
			myConnection.Dispose()
		End Try
	End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblDateTime.Text = Date.Now.ToString("dd-MM-yyyy hh:mm")
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class