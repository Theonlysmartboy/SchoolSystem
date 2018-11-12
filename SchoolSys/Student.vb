Imports MySql.Data.MySqlClient
Public Class Student
	Dim result As Integer
	Dim myConnection As MySqlConnection
	Dim myCommand As MySqlCommand
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        CheckForBlanks()
    End Sub
    Private Sub CheckForBlanks()
		If TxtLastName.Text = "" And TxtFirstName.Text = "" And CboGender.Text = "" And TxtDob.Text = "" And TxtKcpeSchool.Text = "" And CboClass.Text = "" Then
			result = MessageBox.Show("All Fields are Empty. Fill Them and try again", "Error", MessageBoxButtons.OKCancel)
			If result = DialogResult.OK Then
				Me.Show()
				TxtLastName.Focus()
			Else
				Me.Close()
			End If
		ElseIf TxtLastName.Text = "" Then
			result = MessageBox.Show("Please Enter Admission Number", "Error", MessageBoxButtons.OKCancel)
			If result = DialogResult.OK Then
				Me.Show()
				TxtLastName.Focus()
			Else
				Me.Close()
			End If
		ElseIf TxtFirstName.Text = "" Then
			result = MessageBox.Show("Please Enter Student Name", "Error", MessageBoxButtons.OKCancel)
			If result = DialogResult.OK Then
				Me.Show()
				TxtFirstName.Focus()
			Else
				Me.Close()
			End If
		ElseIf TxtFirstName.Text = "" Then
			result = MessageBox.Show("Please Enter Date of Birth", "Error", MessageBoxButtons.OKCancel)
			If result = DialogResult.OK Then
				Me.Show()
				TxtDob.Focus()
			Else
				Me.Close()
			End If
		ElseIf TxtKCPEMarks.Text = "" Then
			result = MessageBox.Show("Please Pick a Grade", "Error", MessageBoxButtons.OKCancel)
			If result = DialogResult.OK Then
				Me.Show()
				TxtKCPEMarks.Focus()
			Else
				Me.Close()
			End If
		ElseIf TxtKcpeSchool.Text = "" Then
			result = MessageBox.Show("Please Enter KCPE School", "Error", MessageBoxButtons.OKCancel)
			If result = DialogResult.OK Then
				Me.Show()
				TxtKcpeSchool.Focus()
			Else
				Me.Close()
			End If
		Else
			Save()
		End If
	End Sub

	Private Sub Save()
		Dim query As String = String.Empty
		query &= "INSERT INTO student (admno,lastname, firstname, othernames, gender,  dob, kcpemarks, kcpeschool, class, stream, term)"
		query &= " VALUES (@admno, @lastname, @firstname, @othernames, @gender,  @dob, @kcpemarks, @kcpeschool, @class, @stream, @term)"
        Using MyConnection As New MySqlConnection("server='" & My.Settings.Server & "';user='" & My.Settings.DbUser & "';password='" & My.Settings.DbPass & "';database='" & My.Settings.Db & "';SslMode=none")
            Using MyCommand As New MySqlCommand()
                With MyCommand
                    .Connection = MyConnection
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@admno", TxtAdmno.Text)
                    .Parameters.AddWithValue("@lastname", TxtLastName.Text)
                    .Parameters.AddWithValue("@firstname", TxtFirstName.Text)
                    .Parameters.AddWithValue("@othernames", TxtOtherNames.Text)
                    .Parameters.AddWithValue("@gender", CboGender.SelectedItem)
                    .Parameters.AddWithValue("@dob", TxtDob.Text)
                    .Parameters.AddWithValue("@kcpemarks", TxtKCPEMarks.Text)
                    .Parameters.AddWithValue("@kcpeschool", TxtKcpeSchool.Text)
                    .Parameters.AddWithValue("@class", CboClass.SelectedValue)
                    .Parameters.AddWithValue("@stream", CboStream.SelectedValue)
                    .Parameters.AddWithValue("@term", CboTerm.SelectedValue)
                End With
                Try
                    MyConnection.Open()
                    MyCommand.ExecuteNonQuery()
                    MessageBox.Show("Registration Successful", "Success")
                    Pg.Show()
                    Pg.TxtAdmno.Text = TxtAdmno.Text
                    IncrementAdmnoNo()
                    Me.Close()
                Catch e As MySqlException
                    MessageBox.Show(e.Message.ToString(), "Error")
                Finally
                End Try
            End Using
        End Using
    End Sub
	Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
		ClearFields()
	End Sub
	Private Sub ClearFields()
		TxtLastName.Clear()
		TxtFirstName.Clear()
		TxtOtherNames.Clear()
		TxtKcpeSchool.Clear()
		TxtKCPEMarks.Clear()
	End Sub
	Private Sub frmAdmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CboClass.DataSource = GetClassItem()
		CboClass.DisplayMember = "name"
		CboClass.ValueMember = "id"
		CboStream.DataSource = GetStreamItem()
		CboStream.DisplayMember = "name"
		CboStream.ValueMember = "id"
		CboTerm.DataSource = GetTermItem()
		CboTerm.DisplayMember = "name"
		CboTerm.ValueMember = "id"
		myConnection = New MySqlConnection
        myConnection.ConnectionString = "server='" & My.Settings.Server & "';user='" & My.Settings.DbUser & "';password='" & My.Settings.DbPass & "';database='" & My.Settings.Db & "';SslMode=none"
        Dim reader As MySqlDataReader
		Try
			myConnection.Open()
			Dim query As String = String.Empty
			query &= "select temp from tempadmno where id=0"
			myCommand = New MySqlCommand(query, myConnection)
			reader = myCommand.ExecuteReader
			Dim found As Boolean = False
			While reader.Read
				found = True
			End While
			If found = True Then
				Dim admno As Integer
				admno = reader("temp")
				TxtAdmno.Text = admno
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
	Function GetClassItem() As List(Of ClassItem)
		Dim classItems = New List(Of ClassItem)
		Dim reader As MySqlDataReader
		myConnection = New MySqlConnection
        myConnection.ConnectionString = "server='" & My.Settings.Server & "';user='" & My.Settings.DbUser & "';password='" & My.Settings.DbPass & "';database='" & My.Settings.Db & "';SslMode=none"
        Dim sql As String = "Select id, name from classes"
		myConnection.Open()
		Dim Command As New MySqlCommand(sql, myConnection)
		Command.CommandTimeout = 30
		reader = Command.ExecuteReader
		If reader.HasRows = True Then
			While reader.Read()
				classItems.Add(New ClassItem(reader("id"), reader("name")))
			End While
		End If
		Return classItems
	End Function
	Function GetStreamItem() As List(Of StreamItem)
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
	Function GetTermItem() As List(Of TermItem)
		Dim termItems = New List(Of TermItem)
		Dim reader As MySqlDataReader
		myConnection = New MySqlConnection
        myConnection.ConnectionString = "server='" & My.Settings.Server & "';user='" & My.Settings.DbUser & "';password='" & My.Settings.DbPass & "';database='" & My.Settings.Db & "';SslMode=none"
        Dim sql As String = "Select id, name from term"
		myConnection.Open()
		Dim Command As New MySqlCommand(sql, myConnection)
		Command.CommandTimeout = 30
		reader = Command.ExecuteReader
		If reader.HasRows = True Then
			While reader.Read()
				termItems.Add(New TermItem(reader("id"), reader("name")))
			End While
		End If
		Return termItems
	End Function
	Private Sub IncrementAdmnoNo()
		'connection string variabl intialized 
		myConnection = New MySqlConnection
        'connection  made to the db
        myConnection.ConnectionString = "server='" & My.Settings.Server & "';user='" & My.Settings.DbUser & "';password='" & My.Settings.DbPass & "';database='" & My.Settings.Db & "';SslMode=none"
        Try
			'connection to db openned
			myConnection.Open()
			'sql query variable created
			Dim query As String
			Dim t As Integer
			t = TxtAdmno.Text + 1
			'sql variable initialized to the sql update statement
			query = "UPDATE tempadmno SET temp='" & t & "' WHERE id=0"
			'command object created
			myCommand = New MySqlCommand(query, myConnection)
			'sql query executed using command object
			myCommand.ExecuteNonQuery()
			myConnection.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		Finally
			myConnection.Dispose()
		End Try
	End Sub
End Class