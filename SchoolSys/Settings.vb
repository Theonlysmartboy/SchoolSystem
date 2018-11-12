Imports MySql.Data.MySqlClient
Public Class Settings
    Dim result As Integer
    Dim MysqlConn As MySqlConnection
    Private Sub BtnTest_Click(sender As Object, e As EventArgs) Handles BtnTest.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server='" & TxtServer.Text & "';user='" & TxtDbUname.Text & "';password='" & TxtDbPwd.Text & "';database='" & TxtDb.Text & "'; SSL Mode=None"
        Try
            MysqlConn.Open()
            If MysqlConn.State = ConnectionState.Open Then
                MessageBox.Show("Connection successful", "Database settings")
            Else
                MessageBox.Show("Connection not successful", "Database settings")
            End If
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        CheckForEmpty()
    End Sub
    Private Sub CheckForEmpty()
        If TxtServer.Text = "" Then
            'Show a confirmation message
            result = MessageBox.Show("Please enter the Server ip adress or name eg localhost/127.0.0.1 and try again", "Blank Entry", MessageBoxButtons.OKCancel)
            'Check for what the user has clicked on the dialog box
            'If it is ok
            If result = DialogResult.OK Then
                Me.Show()
                TxtServer.Focus()
            Else
                Me.Close()
            End If
        ElseIf TxtDbUname.Text = "" Then
            'Show a confirmation message
            result = MessageBox.Show("Please enter the MySQl database user name and try again", "Blank Entry", MessageBoxButtons.OKCancel)
            'Check for what the user has clicked on the dialog box
            'If it is ok
            If result = DialogResult.OK Then
                Me.Show()
                TxtDbUname.Focus()
            Else
                Me.Close()
            End If
        ElseIf TxtDbPwd.Text = "" Then
            'Show a confirmation message
            result = MessageBox.Show("Please enter the MySQl database user password and try again", "Blank Entry", MessageBoxButtons.OKCancel)
            'Check for what the user has clicked on the dialog box
            'If it is ok
            If result = DialogResult.OK Then
                Me.Show()
                TxtDbPwd.Focus()
            Else
                Me.Close()
            End If
        ElseIf TxtDb.Text = "" Then
            'Show a confirmation message
            result = MessageBox.Show("Please enter the MySQl database name and try again", "Blank Entry", MessageBoxButtons.OKCancel)
            'Check for what the user has clicked on the dialog box
            'If it is ok
            If result = DialogResult.OK Then
                Me.Show()
                TxtDb.Focus()
            Else
                Me.Close()
            End If
        Else
            Save()
        End If
    End Sub
    Private Sub Save()
        My.Settings.Server = TxtServer.Text
        My.Settings.DbUser = TxtDbUname.Text
        My.Settings.DbPass = TxtDbPwd.Text
        My.Settings.Db = TxtDb.Text
        My.Settings.Save()
        MessageBox.Show("Database settings saved correctly", "Database settings")
        My.Settings.Reload()
        Application.Restart()
    End Sub
End Class