Public Class PregledKomitenta

    Private Sub PregledKomitenta_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub PregledKomitenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If komitentIdPretraga <> 0 Then
            fillKasePregled()
        End If

    End Sub

    Private Sub fillKasePregled()
        query = "SELECT kasa.id, kasa.brojKase AS Kasa, kasa.brojModula AS Modul, kasa.adresaInstaliranja AS Adresa, " +
                "kasa.telefon AS Telefon, kasa.simKartica AS Sim, kasa.pin AS Pin, model.nazivModela AS Model FROM kasa " +
                "INNER JOIN model ON kasa.modelId = model.id  WHERE kasa.komitentId ='" & komitentIdPretraga & "';"

        getDataFromDatabase(query)
        Me.KasePregled.DataSource = getDataFromDatabase(query)
        Me.KasePregled.Columns(0).Width = 40
        Me.KasePregled.Columns(3).Width = 200
        Me.KasePregled.Columns(5).Width = 170


        Dim komitent As Komitent = getKomitent(komitentIdPretraga)
        Me.id.Text = komitent.id
        Me.nazivKomitenta.Text = komitent.nazivKomitenta
        Me.adresa.Text = komitent.adresa
        Me.telefon.Text = komitent.telefon
        Me.jib.Text = komitent.jib
        Me.pib.Text = komitent.pib
        Me.napomena.Text = komitent.napomena

    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        komitentIdPretraga = Me.id.Text
        KomitentForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        komitentIdPretraga = Me.id.Text
        KasaForm.Show()
        Close()
    End Sub

    Private Sub Pregled_Click(sender As Object, e As EventArgs) Handles Pregled.Click
        Try
            kasaIdPretraga = KasePregled.Item(0, KasePregled.CurrentRow.Index).Value
            ServisForm.Show()
            Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub KasePregled_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles KasePregled.CellContentClick

    End Sub

    Private Sub KasePregled_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles KasePregled.CellDoubleClick
        kasaIdPretraga = KasePregled.Item(0, KasePregled.CurrentRow.Index).Value
        KasaForm.Show()
        Close()
    End Sub
End Class