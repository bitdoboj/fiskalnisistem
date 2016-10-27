Imports MySql.Data.MySqlClient

Public Class PregledKasaForm

    Private Sub PregledKasaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillKomitentiSaKasama()
    End Sub
    Private Sub fillKomitentiSaKasama()

       

        openConnection()
       
        query = "SELECT  kasa.id, komitent.nazivKomitenta AS Komitent, kasa.brojKase AS Kasa, " +
                    "kasa.brojModula AS Modul, kasa.adresaInstaliranja AS Adresa, kasa.telefon AS Telefon, " +
                    "model.nazivModela AS Model FROM kasa " +
                "INNER JOIN model ON kasa.modelId = model.id " +
                "LEFT JOIN komitent ON kasa.komitentId = komitent.id " +
                "WHERE (kasa.brojKase LIKE '%" & Me.searchBox.Text & "%');"

        dataSet = New DataSet
        mySqlDataAdapter = New MySqlDataAdapter(query, sqlcon)
        mySqlDataAdapter.Fill(dataSet)

        Me.pregledKasa.DataSource = dataSet.Tables(0)

        pregledKasa.Columns(0).Width = 40
        pregledKasa.Columns(1).Width = 160
        pregledKasa.Columns(2).Width = 80
        pregledKasa.Columns(3).Width = 80
        pregledKasa.Columns(4).Width = 150

        closeConnection()
    End Sub

    Private Sub pregledKasa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles pregledKasa.CellContentClick

    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        fillKomitentiSaKasama()
    End Sub

    Private Sub izmjene_Click(sender As Object, e As EventArgs) Handles izmjene.Click

        kasaIdPretraga = pregledKasa.Item(0, pregledKasa.CurrentRow.Index).Value
        KasaForm.Show()
        KasaForm.MdiParent = Meni

    End Sub

    Private Sub Pregled_Click(sender As Object, e As EventArgs) Handles Pregled.Click
        

    End Sub
End Class