Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient
Public Class VoteHead
    Dim result As Integer
    Dim myConnection As MySqlConnection
    Dim myCommand As MySqlCommand
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Authenticate()
    End Sub
    Private Sub Authenticate()
        If TxtVHAmount.Text = "" Then
            result = MessageBox.Show("Please Enter The Amount", "Error", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                Me.Show()
                TxtVHAmount.Focus()
            Else
                Me.Close()
            End If
        Else
            Save()
        End If
    End Sub
    Private Sub Save()
        Dim query As String = String.Empty
        query &= "INSERT INTO voteheads (receiptno, vhname, vhamt)"
        query &= " VALUES (@receiptno, @vhname, @vhamt)"
        Using MyConnection As New MySqlConnection("server='" & My.Settings.Server & "';user='" & My.Settings.DbUser & "';password='" & My.Settings.DbPass & "';database='" & My.Settings.Db & "';SslMode=none")
            Using MyCommand As New MySqlCommand()
                With MyCommand
                    .Connection = MyConnection
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@receiptno", TxtReceiptNo.Text)
                    .Parameters.AddWithValue("@vhname", CboVHName.SelectedItem)
                    .Parameters.AddWithValue("@vhamt", TxtVHAmount.Text)
                    .Parameters.AddWithValue("@tempno", TxtReceiptNo.Text)
                End With
                Try
                    MyConnection.Open()
                    MyCommand.ExecuteNonQuery()
                    MessageBox.Show("Save Successful", "Success")
                    IncrementReceiptNo()
                    'query = "UPDATE tempreceiptno SET tempno='" & TxtReceiptNo.Text & "' WHERE id=0" '"
                Catch e As MySqlException
                    MessageBox.Show(e.Message.ToString(), "Error")
                Finally
                End Try
            End Using
        End Using
    End Sub
    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click

    End Sub
    Private Sub IncrementReceiptNo()
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
            t = Payments.receiptno + 1
            'sql variable initialized to the sql update statement
            query = "UPDATE tempreceiptno SET tempno='" & t & "' WHERE id=0"
            'command object created
            myCommand = New MySqlCommand(query, myConnection)
            'sql query executed using command object
            myCommand.ExecuteNonQuery()
            'connection closed
            'MessageBox.Show("Update Successful")
            myConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            myConnection.Dispose()
        End Try
    End Sub
    Private Sub VoteHead_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvReceipt.ColumnCount = 3
        DgvReceipt.Columns(0).Name = " "
        DgvReceipt.Columns(1).Name = "Vote Head"
        DgvReceipt.Columns(2).Name = "Amount"
    End Sub
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Dim votehead As String = CboVHName.Text
        Dim amt As String = TxtVHAmount.Text
        Dim row As String() = New String() {" ", votehead, amt}
        DgvReceipt.Rows.Add(row)
        TxtVHAmount.Clear()
        CboVHName.SelectedItem = " "
    End Sub
    Private Sub BtnSum_Click(sender As Object, e As EventArgs) Handles BtnSum.Click
        Try
            'declaring variable as integer to store the value of the total rows in the datagridview
            Dim max As Integer = DgvReceipt.Rows.Count - 1
            Dim total As String = "Total -----------"
            Dim tot As Integer = 0
            'getting the values of a specific rows

            For Each row As DataGridViewRow In DgvReceipt.Rows
                'formula for adding the values in the rows
                tot += row.Cells(2).Value
            Next
            DgvReceipt.Rows(max).Cells(2).Value += tot
            DgvReceipt.Rows(max).Cells(0).Value = total
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class