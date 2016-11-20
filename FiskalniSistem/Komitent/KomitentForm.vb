Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class KomitentForm
    Public Sub clearKomitent()
        Me.nazivKomitenta.Text = ""
        Me.Telefon.Text = ""
        Me.adresa.Text = ""
        Me.jib.Text = ""
        Me.pib.Text = ""
        Me.napomena.Text = ""
    End Sub

    Private Sub KomitentForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        komitentIdPretraga = 0
    End Sub

    Private Sub KomitentForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub

    Private Sub KomitentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If (komitentIdPretraga > 0) Then
            Me.Text = "Izmjena podataka"
            openConnection()
            query = "SELECT * FROM Komitent WHERE komitent.id=" & komitentIdPretraga & ";"
            mySqlDataAdapter = New MySqlDataAdapter(query, sqlcon)
            Dim sqlcmd As New MySqlCommand(query, sqlcon)
            Dim komitent As MySqlClient.MySqlDataReader = sqlcmd.ExecuteReader

            komitent.Read()
            Me.id.Text = komitent("id")
            Me.nazivKomitenta.Text = If(IsDBNull(komitent("nazivKomitenta")), "", komitent("nazivKomitenta"))
            Me.Telefon.Text = If(IsDBNull(komitent("telefon")), "", komitent("telefon"))
            Me.adresa.Text = If(IsDBNull(komitent("adresa")), "", komitent("adresa"))
            Me.jib.Text = If(IsDBNull(komitent("jib")), "", komitent("jib"))
            Me.pib.Text = If(IsDBNull(komitent("pib")), "", komitent("pib"))
            Me.napomena.Text = If(IsDBNull(komitent("napomena")), "", komitent("napomena"))
            closeConnection()
        End If
    End Sub

    Private Sub Snimi_Click(sender As Object, e As EventArgs) Handles Snimi.Click
        If (Me.nazivKomitenta.Text = "") Then
            MsgBox("Morate unijeti naziv komitenta")
        Else
            If komitentIdPretraga > 0 Then
                updateKomitent(Me.id.Text, Me.nazivKomitenta.Text, Me.Telefon.Text, Me.adresa.Text, Me.jib.Text, Me.pib.Text, Me.napomena.Text)
            Else
                saveKomitent(Me.nazivKomitenta.Text, Me.Telefon.Text, Me.adresa.Text, Me.jib.Text, Me.pib.Text, Me.napomena.Text)
            End If

            clearKomitent()

        End If
    End Sub
End Class