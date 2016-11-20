Public Class RadniNalogLista

    Private Sub RadniNalogLista_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub RadniNalogLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillRadneNaloge()
    End Sub
    Private Sub fillRadneNaloge()
        query = "SELECT * FROM radniNalog ORDER BY id DESC"

        Me.pregledRadniNaloga.DataSource = getDataFromDatabase(query)
    End Sub
End Class