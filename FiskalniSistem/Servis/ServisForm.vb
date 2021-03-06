﻿Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports Microsoft.Reporting.WinForms


Public Class ServisForm
    

    Private Sub ServisForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        kasaIdPretraga = 0
        PregledKomitenta.Show()
    End Sub

    Private Sub ServisForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub Servis_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim kasa As Kasa = getKasa(kasaIdPretraga)
        Me.kasaId.Text = kasaIdPretraga

        Me.brojModula.Text = kasa.brojModula
        Me.brojKase.Text = kasa.brojKase
        Me.brojTerminala.Text = kasa.brojTerminala
        Me.pin.Text = kasa.pin
        Me.telefon.Text = kasa.telefon
        Me.adresaInstaliranja.Text = kasa.adresaInstaliranja
        Me.fLink.Text = kasa.fLink
        Me.ibsa.Text = kasa.ibsa

        Me.Text = getNazivKomitentaByKasaId(kasaIdPretraga)

        komitentIdPretraga = kasa.komitentId
        fillServise()
    End Sub

    Private Sub fillServise()

        query = "SELECT servis.id, servis.datumServisa AS Datum, servis.opis FROM servis WHERE kasaId=" & kasaIdPretraga & ";"

        Me.servisiLista.DataSource = getDataFromDatabase(query)

        servisiLista.Columns(0).Width = 40
        servisiLista.Columns(2).Width = 775

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

    Private Sub StampajServis_Click(sender As Object, e As EventArgs) Handles StampajServis.Click

        Dim nazivKomitenta As String = getNazivKomitentaByKasaId(Me.kasaId.Text)
        Dim brojKase As String = getBrojKase(Me.kasaId.Text)
        Dim datumServisa As String = servisiLista.Item(1, servisiLista.CurrentRow.Index).Value
        Dim opisServisa As String = servisiLista.Item(2, servisiLista.CurrentRow.Index).Value

        komitentParameter = New ReportParameter("KomitentParameter", nazivKomitenta)
        brojKaseParameter = New ReportParameter("BrojKaseParameter", brojKase)
        datumServisaParameter = New ReportParameter("DatumPreuzimanjaParameter", datumServisa)
        opisServisaParameter = New ReportParameter("OpisServisaParameter", opisServisa)

        ServisPrint.Show()
    End Sub

    
End Class