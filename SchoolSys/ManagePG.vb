Imports MySql.Data.MySqlClient
Public Class ManagePG
	Dim MyConnection As MySqlConnection
	Dim Command As MySqlCommand
    Dim connection As New MySqlConnection("server='" & My.Settings.Server & "';user='" & My.Settings.DbUser & "';password='" & My.Settings.DbPass & "';database='" & My.Settings.Db & "';SslMode=none")
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
		Dim search_command As New MySqlCommand("SELECT * FROM pg WHERE  id=@id", connection)
		search_command.Parameters.Add("@id", MySqlDbType.Int64).Value = TxtId.Text
		Dim adapter As New MySqlDataAdapter(search_command)
		Dim table As New DataTable()
		Try
			adapter.Fill(table)
			If table.Rows.Count > 0 Then
				'TxtId.Text = table(0)(1)
				TxtAdmno.Text = table(0)(1)
				TxtName.Text = table(0)(2)
				TxtDescription.Text = table(0)(3)
				TxtPhoneNo.Text = table(0)(4)
				TxtEmailAddress.Text = table(0)(5)
			Else
				TxtId.Text = ""
				TxtAdmno.Text = ""
				TxtName.Text = ""
				TxtDescription.Text = ""
				TxtPhoneNo.Text = ""
				TxtEmailAddress.Text = ""
				MessageBox.Show("Data Not Found")
			End If
		Catch ex As Exception
			MessageBox.Show("ERROR")
		End Try
	End Sub
	Function execCommand(ByVal cmd As MySqlCommand) As Boolean
		If connection.State = ConnectionState.Closed Then
			connection.Open()
		End If
		If cmd.ExecuteNonQuery() = 1 Then
			Return True
		Else
			Return False
		End If
		If connection.State = ConnectionState.Open Then
			connection.Close()
		End If
	End Function

	Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
		Edit()
	End Sub
	Private Sub Edit()
		'connection string variabl intialized 
		MyConnection = New MySqlConnection
        'connection  made to the db
        MyConnection.ConnectionString = "server='" & My.Settings.Server & "';user='" & My.Settings.DbUser & "';password='" & My.Settings.DbPass & "';database='" & My.Settings.Db & "';SslMode=none"
        Try
			'connection to db openned
			MyConnection.Open()
			'sql query variable created
			Dim query As String
			'sql variable initialized to the sql update statement
			query = "UPDATE pg SET admno='" & TxtAdmno.Text & "', pgname= '" & TxtName.Text & "',pgrelationship='" & TxtDescription.Text & "',pgphone='" & TxtPhoneNo.Text & "',pgemail='" & TxtEmailAddress.Text & "' WHERE id= '" & TxtId.Text & "'"
			'command object created
			Command = New MySqlCommand(query, MyConnection)
			'sql query executed using command object
			Command.ExecuteNonQuery()
			'connection closed
			MessageBox.Show("Update Successful")
			MyConnection.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		Finally
			MyConnection.Dispose()
		End Try
	End Sub
	Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
		Dim result As Integer
		result = MessageBox.Show("CONFIRM DELETE", "Delete", MessageBoxButtons.OKCancel)
		If result = DialogResult.OK Then
			Delete()
		Else
			Me.Show()
		End If
	End Sub
	Private Sub clear()
		TxtId.Text = ""
		TxtAdmno.Text = ""
		TxtName.Text = ""
		TxtDescription.Text = ""
		TxtPhoneNo.Text = ""
		TxtEmailAddress.Text = ""
	End Sub
	Private Sub Delete()

		'connection string variabl intialized 
		MyConnection = New MySqlConnection
        'connection  made to the db
        MyConnection.ConnectionString = "server='" & My.Settings.Server & "';user='" & My.Settings.DbUser & "';password='" & My.Settings.DbPass & "';database='" & My.Settings.Db & "';SslMode=none"
        Try
			'connection to db openned
			MyConnection.Open()
			'sql query variable created
			Dim query As String
			'sql variable initialized to the sql update statement
			query = "Delete from pg WHERE id= '" & TxtId.Text & "'"
			'command object created
			Command = New MySqlCommand(query, MyConnection)
			'sql query executed using command object
			Command.ExecuteNonQuery()
			'connection closed
			MessageBox.Show("Delete Successful")
			MyConnection.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		Finally
			MyConnection.Dispose()
		End Try
		clear()
	End Sub
End Class