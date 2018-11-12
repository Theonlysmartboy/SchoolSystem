Imports MySql.Data.MySqlClient
Public Class TypeOfPyment
	Dim result As Integer
	Dim myConnection As MySqlConnection
	Dim myCommand As MySqlCommand
	Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
		Authenticate()
	End Sub
	Private Sub Authenticate()
		If TxtTypeOfPayment.Text = "" Then
			result = MessageBox.Show("Enter New Type Of Payment", "Error", MessageBoxButtons.OKCancel)
			If result = DialogResult.OK Then
				Me.Show()
				TxtTypeOfPayment.Focus()
			Else
				Me.Close()
			End If
		Else
			Save()
		End If
	End Sub
	Private Sub Save()
		Dim query As String = String.Empty
		query &= "INSERT INTO typeofpayment (typeofpayment)"
		query &= " VALUES (@typeofpayment)"
        Using MyConnection As New MySqlConnection("server='" & My.Settings.Server & "';user='" & My.Settings.DbUser & "';password='" & My.Settings.DbPass & "';database='" & My.Settings.Db & "';SslMode=none")
            Using MyCommand As New MySqlCommand()
                With MyCommand
                    .Connection = MyConnection
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@typeofpayment", TxtTypeOfPayment.Text)
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
		TxtTypeOfPayment.Clear()
	End Sub
    Private Sub TypeOfPyment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class