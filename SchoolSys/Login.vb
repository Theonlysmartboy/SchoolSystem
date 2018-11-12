Imports MySQL.Data.MySQLClient
Public Class Login
	Dim result As Integer
	Dim MyConnection As MySQLConnection
	Dim Command As MySQLCommand
	Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
		Authenticate()
	End Sub
	Private Sub Authenticate()
		If TxtName.Text = "" And TxtPassword.Text = "" Then
			result = MessageBox.Show("All Fields are Empty. Fill Them and try again", "Error:Empty Text Box", MessageBoxButtons.OKCancel)
			If result = DialogResult.OK Then
				Me.Show()
				TxtName.Focus()
			Else
				Me.Close()
			End If
		ElseIf TxtName.Text = "" Then
			result = MessageBox.Show("Please Enter Your Login Name", "Empty Name", MessageBoxButtons.OKCancel)
			If result = DialogResult.OK Then
				Me.Show()
				TxtName.Focus()
			Else
				Me.Close()
			End If
		ElseIf TxtPassword.Text = "" Then
			result = MessageBox.Show("Please Enter Your Password", "Empty Password", MessageBoxButtons.OKCancel)
			If result = DialogResult.OK Then
				Me.Show()
				TxtPassword.Focus()
			Else
				Me.Close()
			End If
		Else
			Login()
		End If
	End Sub
	Private Sub Login()
		MyConnection = New MySqlConnection
        MyConnection.ConnectionString = "server='" & My.Settings.Server & "';user='" & My.Settings.DbUser & "';password='" & My.Settings.DbPass & "';database='" & My.Settings.Db & "';SslMode=none"
        Dim reader As MySqlDataReader
		Try
			MyConnection.Open()
			Dim query As String
			query = "select * from users where uname='" & TxtName.Text & "' and password='" & TxtPassword.Text & "'"
			Command = New MySqlCommand(query, MyConnection)
			reader = Command.ExecuteReader
			Dim found As Boolean = False
			While reader.Read
				found = True
			End While
			If found = True Then
				Dashboard.Show()
				Me.Close()
			Else
				result = MessageBox.Show("Wrong username Or Password", "Error:", MessageBoxButtons.OKCancel)
				If result = DialogResult.OK Then
					Me.Show()
					TxtName.Focus()
				Else
					Me.Close()
				End If
			End If
			MyConnection.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		Finally
			MyConnection.Dispose()
		End Try
	End Sub

	Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class