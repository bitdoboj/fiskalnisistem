Public Class SettingsForm

    Private Sub SettingsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getSettings()

    End Sub
    Private Sub getSettings()
        Me.Server.Text = My.Settings.ServerName
        Me.UserName.Text = My.Settings.User
        Me.Password.Text = My.Settings.Password
    End Sub

    Private Sub Snimi_Click(sender As Object, e As EventArgs) Handles Snimi.Click
        My.Settings.ServerName = Me.Server.Text
        My.Settings.User = Me.UserName.Text
        My.Settings.Password = Me.Password.Text
    End Sub
End Class