Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class ServisForm

    Private Sub Servis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.kasaId.Text = kasaIdPretraga
        fillServise()
        Me.brojKase.Text = getBrojKase(kasaIdPretraga)
        Me.nazivKomitenta.text = getNazivKomitentaByKasaId(kasaIdPretraga)
    End Sub

    Private Sub fillServise()

        query = "SELECT servis.id, servis.datumServisa AS Datum, servis.opis FROM servis WHERE kasaId=" & kasaIdPretraga & ";"

        Me.servisiLista.DataSource = getDataFromDatabase(query)

        servisiLista.Columns(0).Width = 40
        servisiLista.Columns(2).Width = 590

    End Sub

    Private Sub Snimi_Click(sender As Object, e As EventArgs) Handles Snimi.Click

        Dim servis As New Servis
        servis.id = Me.id.Text
        servis.kasaId = Me.kasaId.Text
        servis.datumServisa = FormatDateTime(Me.datumServisa.Value, DateFormat.ShortDate)
        servis.opis = Me.opis.Text

        saveServis(servis)
        fillServise()
        clearServis()
    End Sub

    Private Sub servisiLista_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles servisiLista.CellMouseClick
        Try

            Dim servisId As Integer = servisiLista.Item(0, servisiLista.CurrentRow.Index).Value
            openConnection()

            query = "SELECT servis.id, servis.datumServisa, servis.opis FROM servis WHERE id=" & servisId & ";"
            mySqlDataAdapter = New MySqlDataAdapter(query, sqlcon)
            Dim sqlcmd As New MySqlCommand(query, sqlcon)
            Dim servis As MySqlClient.MySqlDataReader = sqlcmd.ExecuteReader

            servis.Read()
            Me.id.Text = servis("id")
            Me.datumServisa.Text = servis("datumServisa")
            Me.opis.Text = servis("opis")

            closeConnection()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub clearServis()
        Me.id.Text = 0
        Me.opis.Text = ""
    End Sub
End Class