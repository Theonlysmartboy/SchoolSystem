Imports MySql.Data.MySqlClient
Public Class ManageStudent
    Dim result As Integer
    Dim myConnection As MySqlConnection
    Dim myCommand As MySqlCommand
    Dim connection As New MySqlConnection("server='" & My.Settings.Server & "';user='" & My.Settings.DbUser & "';password='" & My.Settings.DbPass & "';database='" & My.Settings.Db & "';SslMode=none")

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        CheckForBlanks()
    End Sub
    Private Sub CheckForBlanks()
        If TxtLastName.Text = "" And TxtFirstName.Text = "" And CboGender.Text = "" And TxtDoa.Text = "" And TxtKcpeSchool.Text = "" And CboClass.Text = "" Then
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
        ElseIf TxtDoa.Text = "" Then
            result = MessageBox.Show("Please Enter Date of Birth", "Error", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                Me.Show()
                TxtDoa.Focus()
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
            Edit()
        End If
    End Sub
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim search_command As New MySqlCommand("SELECT * FROM student WHERE  admno=@admno", connection)
        search_command.Parameters.Add("@admno", MySqlDbType.String).Value = TxtAdmno.Text
        Dim adapter As New MySqlDataAdapter(search_command)
        Dim table As New DataTable()
        Try
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                TxtFirstName.Text = table(0)(1)
                TxtLastName.Text = table(0)(2)
                TxtOtherNames.Text = table(0)(3)
                CboGender.Text = table(0)(4)
                TxtDoa.Text = table(0)(5)
                TxtDob.Text = table(0)(6)
                TxtKCPEMarks.Text = table(0)(7)
                TxtKcpeSchool.Text = table(0)(8)
                CboClass.Text = table(0)(9)
                CboStream.Text = table(0)(10)
                CboTerm.Text = table(0)(11)
                CboStatus.Text = table(0)(12)
            Else
                TxtLastName.Text = ""
                TxtFirstName.Text = ""
                TxtOtherNames.Text = ""
                CboGender.Text = ""
                TxtDoa.Text = ""
                TxtDob.Text = ""
                TxtKCPEMarks.Text = ""
                TxtKcpeSchool.Text = ""
                CboClass.Text = ""
                CboStream.Text = ""
                CboTerm.Text = ""
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
            query = "UPDATE student SET firstname='" & TxtFirstName.Text & "', lastname='" & TxtLastName.Text & "', othernames='" & TxtOtherNames.Text & "', gender='" & CboGender.SelectedItem & "', kcpemarks ='" & TxtKCPEMarks.Text & "',kcpeschool='" & TxtKcpeSchool.Text & "',Class='" & CboClass.SelectedItem & "',stream='" & CboStream.SelectedItem & "',term='" & CboTerm.SelectedItem & "' WHERE admno='" & TxtAdmno.Text & "'"
            'command object created
            myCommand = New MySqlCommand(query, myConnection)
            'sql query executed using command object
            myCommand.ExecuteNonQuery()
            'connection closed
            MessageBox.Show("Update Successful")
            myConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            myConnection.Dispose()
        End Try
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs)
        Dim result As Integer
        result = MessageBox.Show("CONFIRM DELETE", "Delete", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            Delete()
        Else
            Me.Show()
        End If
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
            query = "Delete from student WHERE admno= '" & TxtAdmno.Text & "'"
            'command object created
            myCommand = New MySqlCommand(query, myConnection)
            'sql query executed using command object
            myCommand.ExecuteNonQuery()
            'connection closed
            MessageBox.Show("Delete Successful")
            myConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            myConnection.Dispose()
        End Try
        'clear()
    End Sub
End Class