Public Class RadniNalogLista

    Private Sub RadniNalogLista_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub RadniNalogLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillRadneNaloge()
    End Sub
    Private Sub fillRadneNaloge()

        query = "SELECT radniNalog.id, komitent.nazivKomitenta, radniNalog.brojRn, radniNalog.datumRn, radniNalog.mjestoRada,  radniNalog.serviser FROM radniNalog LEFT JOIN komitent ON radniNalog.komitentId=komitent.id ORDER BY radniNalog.id DESC"

        Me.pregledRadniNaloga.DataSource = getDataFromDatabase(query)
    End Sub
End Class