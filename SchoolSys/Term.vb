Imports MySql.Data.MySqlClient
Public Class Term
    Dim result As Integer
    Dim myConnection As MySqlConnection
    Dim myCommand As MySqlCommand
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Authenticate()
    End Sub
    Private Sub Authenticate()
        If TxtNewTerm.Text = "" Then
            result = MessageBox.Show("Enter New Term Name", "Error", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                Me.Show()
                TxtNewTerm.Focus()
            Else
                Me.Close()
            End If
        Else
            Save()
        End If
    End Sub
    Private Sub Save()
        Dim query As String = String.Empty
        query &= "INSERT INTO term (name)"
        query &= " VALUES (@name)"
        Using MyConnection As New MySqlConnection("server='" & My.Settings.Server & "';user='" & My.Settings.DbUser & "';password='" & My.Settings.DbPass & "';database='" & My.Settings.Db & "';SslMode=none")
            Using MyCommand As New MySqlCommand()
                With MyCommand
                    .Connection = MyConnection
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@name", TxtNewTerm.Text)
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
        TxtNewTerm.Clear()
    End Sub
End Class
