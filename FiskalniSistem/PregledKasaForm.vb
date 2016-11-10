Imports MySql.Data.MySqlClient

Public Class PregledKasaForm

    Private Sub PregledKasaForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub PregledKasaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillKomitentiSaKasama()
    End Sub
    Private Sub fillKomitentiSaKasama()

        query = "SELECT kasa.id, komitent.nazivKomitenta AS Komitent, kasa.brojKase AS Kasa, " +
                    "kasa.brojModula AS Modul, kasa.adresaInstaliranja AS Adresa, kasa.telefon AS Telefon, " +
                    "kasa.simKartica AS Sim, kasa.pin AS Pin, model.nazivModela AS Model FROM kasa " +
                    "INNER JOIN model ON kasa.modelId = model.id " +
                    "LEFT JOIN komitent ON kasa.komitentId = komitent.id " +
                    "WHERE (kasa.brojKase LIKE '%" & Me.searchBox.Text & "%');"

        Me.pregledKasa.DataSource = getDataFromDatabase(query)

        pregledKasa.Columns(0).Width = 40
        pregledKasa.Columns(1).Width = 163
        pregledKasa.Columns(2).Width = 80
        pregledKasa.Columns(3).Width = 80
        pregledKasa.Columns(4).Width = 150
        pregledKasa.Columns(6).Width = 131
        pregledKasa.Columns(7).Width = 52

    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        fillKomitentiSaKasama()
    End Sub

    Private Sub izmjene_Click(sender As Object, e As EventArgs) Handles izmjene.Click

        kasaIdPretraga = pregledKasa.Item(0, pregledKasa.CurrentRow.Index).Value
        KasaForm.Show()
        Close()
    End Sub
    Private Sub servis_Click(sender As Object, e As EventArgs) Handles servis.Click
        kasaIdPretraga = pregledKasa.Item(0, pregledKasa.CurrentRow.Index).Value
        ServisForm.Show()
        Close()
    End Sub
End Class