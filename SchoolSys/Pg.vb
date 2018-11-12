Imports MySql.Data.MySqlClient
Public Class Pg
    Dim result As Integer
    Dim myConnection As MySqlConnection
    Dim myCommand As MySqlCommand
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Authenticate()
    End Sub
    Private Sub Authenticate()
        If TxtAdmno.Text = "" And TxtAdmno.Text = "" And TxtDescription.Text = "" And TxtPhoneNo.Text = "" And TxtEmailAddress.Text = "" Then
            result = MessageBox.Show("All fields are Empty. Fill Them and try again", "Error", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                Me.Show()
                TxtAdmno.Focus()
            Else
                Me.Close()
            End If
        ElseIf TxtAdmno.Text = "" Then
            result = MessageBox.Show("Please Enter Admission Number", "Error", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                Me.Show()
                TxtAdmno.Focus()
            Else
                Me.Close()
            End If
        ElseIf TxtName.Text = "" Then
            result = MessageBox.Show("Please Enter Name", "Error", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                Me.Show()
                TxtName.Focus()
            Else
                Me.Close()
            End If
        ElseIf TxtDescription.Text = "" Then
            result = MessageBox.Show("Please Enter Description", "Error", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                Me.Show()
                TxtDescription.Focus()
            Else
                Me.Close()
            End If
        ElseIf TxtPhoneNo.Text = "" Then
            result = MessageBox.Show("Please Enter Phone Number", "Error", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                Me.Show()
                TxtPhoneNo.Focus()
            Else
                Me.Close()
            End If
        ElseIf TxtEmailAddress.Text = "" Then
            result = MessageBox.Show("Please Enter Email Address", "Error", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                Me.Show()
                TxtEmailAddress.Focus()
            Else
                Me.Close()
            End If
        Else
            Save()
        End If
    End Sub
    Private Sub Save()
        Dim query As String = String.Empty
        query &= "INSERT INTO pg (admno, pgname, pgrelationship, pgphone, pgemail)"
        query &= " VALUES (@admno, @pgname, @pgrelationship, @pgphone, @pgemail)"
        Using MyConnection As New MySqlConnection("server='" & My.Settings.Server & "';user='" & My.Settings.DbUser & "';password='" & My.Settings.DbPass & "';database='" & My.Settings.Db & "';SslMode=none")
            Using MyCommand As New MySqlCommand()
                With MyCommand
                    .Connection = MyConnection
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@admno", TxtAdmno.Text)
                    .Parameters.AddWithValue("@pgname", TxtName.Text)
                    .Parameters.AddWithValue("@pgrelationship", TxtDescription.Text)
                    .Parameters.AddWithValue("@pgphone", TxtPhoneNo.Text)
                    .Parameters.AddWithValue("@pgemail", TxtEmailAddress.Text)
                End With
                Try
                    MyConnection.Open()
                    MyCommand.ExecuteNonQuery()
                    MessageBox.Show("Save Successful", "Success")
                    ClearFields()
                Catch e As MySqlException
                    MessageBox.Show(e.Message.ToString(), "Error")
                Finally

                End Try
            End Using
        End Using
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Clearfields()
    End Sub
    Private Sub ClearFields()
		TxtName.Clear()
		TxtDescription.Clear()
        TxtPhoneNo.Clear()
        TxtEmailAddress.Clear()
    End Sub
End Class