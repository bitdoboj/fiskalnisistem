Public Class RadniNalogLista

    Private Sub RadniNalogLista_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub RadniNalogLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillRadneNaloge()


        pregledRadniNaloga.Columns(0).Width = 40
        pregledRadniNaloga.Columns(1).Width = 180
        pregledRadniNaloga.Columns(2).Width = 60
        pregledRadniNaloga.Columns(6).Width = 108
        pregledRadniNaloga.Columns(7).Width = 108
        pregledRadniNaloga.Columns(8).Width = 108
    End Sub
    Private Sub fillRadneNaloge()

        query = "SELECT radniNalog.id, komitent.nazivKomitenta, radniNalog.brojRn, radniNalog.datumRn, radniNalog.mjestoRada,  radniNalog.serviser, radniNalog.opisKvara, radniNalog.dijagnostika, radniNalog.izvrseniRadovi FROM radniNalog LEFT JOIN komitent ON radniNalog.komitentId=komitent.id ORDER BY radniNalog.id DESC"

        Me.pregledRadniNaloga.DataSource = getDataFromDatabase(query)
    End Sub

    Private Sub Pregled_Click(sender As Object, e As EventArgs) Handles Pregled.Click

        radniNalogIdPretraga = pregledRadniNaloga.Item(0, pregledRadniNaloga.CurrentRow.Index).Value


        RadniNalogPrint.Show()
    End Sub
End Class