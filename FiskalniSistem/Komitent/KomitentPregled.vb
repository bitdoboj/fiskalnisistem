﻿Imports MySql.Data.MySqlClient

Public Class KomitentPregled

    Private Sub KomitentiPregled_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub KomitentiPregled_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillKomitente()
    End Sub
    Private Sub fillKomitente()

        query = "SELECT komitent.id, komitent.nazivKomitenta AS Komitent, komitent.telefon AS Telefon, komitent.adresa AS Adresa, komitent.jib, komitent.pib, komitent.napomena FROM komitent WHERE (komitent.nazivKomitenta LIKE '%" & Me.searchBox.Text & "%');"

        Me.komitentiLista.DataSource = getDataFromDatabase(query)

        komitentiLista.Columns(0).Width = 40
        komitentiLista.Columns(1).Width = 165
        komitentiLista.Columns(2).Width = 80
        komitentiLista.Columns(3).Width = 165
        komitentiLista.Columns(4).Width = 80
        komitentiLista.Columns(6).Width = 288

    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        fillKomitente()
    End Sub

   


    Private Sub Pregled_Click(sender As Object, e As EventArgs) Handles Pregled.Click
        komitentIdPretraga = komitentiLista.Item(0, komitentiLista.CurrentRow.Index).Value
        PregledKomitenta.Show()
        Me.Close()
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        komitentIdPretraga = komitentiLista.Item(0, komitentiLista.CurrentRow.Index).Value
        KomitentForm.Show()

    End Sub
End Class