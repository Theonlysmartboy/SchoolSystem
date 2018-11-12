Imports MySql.Data.MySqlClient
Public Class ManagePayments
	Dim result As Integer
	Dim myConnection As MySqlConnection
	Dim myCommand As MySqlCommand
    Dim connection As New MySqlConnection("server='" & My.Settings.Server & "';user='" & My.Settings.DbUser & "';password='" & My.Settings.DbPass & "';database='" & My.Settings.Db & "';SslMode=none")
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
		Authenticate()
	End Sub

	Private Sub Authenticate()
		If TxtAmtPaid.Text = "" Then
			result = MessageBox.Show("Enter Amount Paid", "Error", MessageBoxButtons.OKCancel)
			If result = DialogResult.OK Then
				Me.Show()
				TxtAmtPaid.Focus()
			Else
				Me.Close()
			End If
		ElseIf TxtDocumentNo.text = "" Then
			result = MessageBox.Show("Enter Payment Details", "Error", MessageBoxButtons.OKCancel)
			If result = DialogResult.OK Then
				Me.Show()
				TxtDocumentNo.Focus()
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
			'Update1()
		End If
	End Sub

	Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
		Dim search_command As New MySqlCommand("SELECT * FROM payments WHERE  receiptno=@receiptno", connection)
		search_command.Parameters.Add("@receiptno", MySqlDbType.Int64).Value = txtReceiptNo.Text
		Dim adapter As New MySqlDataAdapter(search_command)
		Dim table As New DataTable()
		Try
			adapter.Fill(table)
			If table.Rows.Count > 0 Then
				TxtAdmno.Text = table(0)(0)
				TxtDop.Text = table(0)(2)
				TxtAmtPaid.Text = table(0)(3)
				TxtTypeOfPayment.Text = table(0)(4)
				TxtDocumentNo.Text = table(0)(5)
				TxtPaidBy.Text = table(0)(6)
				TxtReceivedBy.Text = table(0)(7)
			Else
				TxtAdmno.Text = ""
				TxtAmtPaid.Text = ""
				TxtDocumentNo.Text = ""
				TxtPaidBy.Text = ""
				TxtReceivedBy.Text = ""
				MessageBox.Show("Data Not Found")
			End If
		Catch ex As Exception
			MessageBox.Show("ERROR")
		End Try
	End Sub
	Function execCommand(ByVal cmd As MySqlCommand) As Boolean
		If Connection.State = ConnectionState.Closed Then
			Connection.Open()
		End If
		If cmd.ExecuteNonQuery() = 1 Then
			Return True
		Else
			Return False
		End If
		If Connection.State = ConnectionState.Open Then
			Connection.Close()
		End If
	End Function
	Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
		Edit()
	End Sub
	Private Sub Edit()
		'connection string variabl intialized 
		myConnection = New MySqlConnection
        'connection  made to the db
        myConnection.ConnectionString = "server='" & My.Settings.Server & "';user='" & My.Settings.DbUser & "';password='" & My.Settings.DbPass & "';database='" & My.Settings.Db & "';SslMode=none"
        Try
			'connection to db openned
			myConnection.Open()
			'sql query variable created
			Dim query As String
			'sql variable initialized to the sql update statement
			query = "UPDATE payments SET amtpaid=0,documentno= 'Cancelled Receipt' WHERE receiptno='" & txtReceiptNo.Text & "'"
			'command object created
			myCommand = New MySqlCommand(query, myConnection)
			'sql query executed using command object
			myCommand.ExecuteNonQuery()
			'connection closed
			MessageBox.Show("Receipt Cancelled")
			myConnection.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		Finally
			myConnection.Dispose()
		End Try
	End Sub

	Private Sub BtnVoteHeads_Click(sender As Object, e As EventArgs) Handles BtnVoteHeads.Click
		VoteHead.TxtReceiptNo.Text = txtReceiptNo.Text
		VoteHead.TxtTotalPaid.Text = TxtAmtPaid.Text
		Delete()
		VoteHead.Show()
		Me.Close()
	End Sub
	Private Sub Delete()
		'connection string variabl intialized 
		myConnection = New MySqlConnection
        'connection  made to the db
        myConnection.ConnectionString = "server='" & My.Settings.Server & "';user='" & My.Settings.DbUser & "';password='" & My.Settings.DbPass & "';database='" & My.Settings.Db & "';SslMode=none"
        Try
			'connection to db openned
			myConnection.Open()
			'sql query variable created
			Dim query As String
			'sql variable initialized to the sql update statement
			query = "Delete from voteheads WHERE receiptno= '" & txtReceiptNo.Text & "'"
			'command object created
			myCommand = New MySqlCommand(query, myConnection)
			'sql query executed using command object
			myCommand.ExecuteNonQuery()
			'connection closed
			MessageBox.Show("Old voteheads have been Deleted, Enter New VoteHeads for this receipt")
			myConnection.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		Finally
			myConnection.Dispose()
		End Try
		'clear()
	End Sub
End Class