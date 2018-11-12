Public Class Form1
    Dim result As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblVersion.Text = "Version " & My.Application.Info.Version.ToString()
        LblDevelopper.Text = "All rights Reserved " & My.Application.Info.Copyright
        PrbProgres.Increment(5)
        If PrbProgres.Value = 100 Then
            'check if trial period field is blank
            If My.Settings.Expiry = "" Then
                'set it to today's date + 60 days
                Dim ExpiryDate As Date
                ExpiryDate = Today.AddDays(120)
                My.Settings.Expiry = ExpiryDate
                My.Settings.Save()
                MessageBox.Show("Your trial will expire on" & ExpiryDate, "System Expiry")
                My.Settings.Reload()
                'check if the expiry period has elapsed
            ElseIf My.Settings.Expiry < Today Then
                'if true then show message and quit
                result = MessageBox.Show("Your trial period has expired please purchase the system", "Trial", MessageBoxButtons.OK)
                If result = DialogResult.OK Then
                    'My.Settings.Reset()
                    Me.Close()
                    Application.Exit()
                End If
            ElseIf My.Settings.Server = "" And My.Settings.DbUser = "" And My.Settings.DbPass = "" And My.Settings.Db = "" Then
                Settings.Show()
                Me.Close()
            Else
                'show the main form
                Login.Show()
                'close the splash screen
                Me.Close()
            End If
        End If

    End Sub

End Class
