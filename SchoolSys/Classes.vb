Imports MySql.Data.MySqlClient
Public Class Classes
	Dim result As Integer
	Dim myConnection As MySqlConnection
	Dim myCommand As MySqlCommand
	Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
		Authenticate()
	End Sub
	Private Sub Authenticate()
		If TxtName.Text = "" Then
			result = MessageBox.Show("Enter Name", "Error", MessageBoxButtons.OKCancel)
			If result = DialogResult.OK Then
				Me.Show()
				TxtName.Focus()
			Else
				Me.Close()
			End If
		ElseIf TxtSymbol.Text = "" Then
			result = MessageBox.Show("Enter Symbol", "Error", MessageBoxButtons.OKCancel)
			If result = DialogResult.OK Then
				Me.Show()
				TxtSymbol.Focus()
			Else
				Me.Close()
			End If
		Else
			Save()
		End If
	End Sub
	Private Sub Save()
		Dim query As String = String.Empty
		query &= "INSERT INTO classes (name, symbol, stream)"
		query &= " VALUES (@name, @symbol, @stream)"
        Using MyConnection As New MySqlConnection("server='" & My.Settings.Server & "';user='" & My.Settings.DbUser & "';password='" & My.Settings.DbPass & "';database='" & My.Settings.Db & "';SslMode=none")
            Using MyCommand As New MySqlCommand()
                With MyCommand
                    .Connection = MyConnection
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@name", TxtName.Text)
                    .Parameters.AddWithValue("@symbol", TxtSymbol.Text)
                    .Parameters.AddWithValue("@stream", TxtSymbol.SelectedText)
                End With
                Try
                    MyConnection.Open()
                    MyCommand.ExecuteNonQuery()
                    MessageBox.Show("Entry Successful", "Success")
                    ClearFields()
                Catch e As MySqlException
                    MessageBox.Show(e.Message.ToString(), "Error")
                Finally

                End Try
            End Using
        End Using
    End Sub
	Private Sub ClearFields()
		TxtName.Clear()
	End Sub

	Private Sub Classes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CboStream.DataSource = GetstreamItem()
		CboStream.DisplayMember = "name"
		CboStream.ValueMember = "id"
	End Sub
	Function GetstreamItem() As List(Of StreamItem)
		Dim streamItems = New List(Of StreamItem)
		Dim reader As MySqlDataReader
		myConnection = New MySqlConnection
        myConnection.ConnectionString = "server='" & My.Settings.Server & "';user='" & My.Settings.DbUser & "';password='" & My.Settings.DbPass & "';database='" & My.Settings.Db & "';SslMode=none"
        Dim sql As String = "Select id, name from stream"
		myConnection.Open()
		Dim Command As New MySqlCommand(sql, myConnection)
		Command.CommandTimeout = 30
		reader = Command.ExecuteReader
		If reader.HasRows = True Then
			While reader.Read()
				streamItems.Add(New StreamItem(reader("id"), reader("name")))
			End While
		End If
		Return streamItems
	End Function

End Class
