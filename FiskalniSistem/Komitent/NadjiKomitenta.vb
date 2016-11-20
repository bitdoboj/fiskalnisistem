Imports MySql.Data.MySqlClient


Public Class NadjiKomitenta

    Private Sub NadjiKomitenta_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub NadjiKomitenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        searchBox.Focus()
        fillKomitenti()

    End Sub
    Private Sub fillKomitenti()

        query = "SELECT Komitent.id, Komitent.nazivKomitenta FROM Komitent WHERE (Komitent.nazivKomitenta LIKE '%" & Me.searchBox.Text & "%') ORDER BY Komitent.nazivKomitenta;"

        Me.KomitentiGridView.DataSource = getDataFromDatabase(query)

        Dim id As DataGridViewColumn = KomitentiGridView.Columns(0)
        id.Width = 60
        Dim naziv As DataGridViewColumn = KomitentiGridView.Columns(1)
        naziv.Width = 220

    End Sub


    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        fillKomitenti()
    End Sub



    Private Sub KomitentiGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles KomitentiGridView.CellMouseDoubleClick
        If Application.OpenForms().OfType(Of RadniNalogForm).Any Then
            RadniNalogForm.nazivKomitenta.Text = KomitentiGridView.Item(1, KomitentiGridView.CurrentRow.Index).Value
            RadniNalogForm.komitentid.Text = KomitentiGridView.Item(0, KomitentiGridView.CurrentRow.Index).Value
        Else
            KasaForm.nazivKomitenta.Text = KomitentiGridView.Item(1, KomitentiGridView.CurrentRow.Index).Value
            KasaForm.komitentid.Text = KomitentiGridView.Item(0, KomitentiGridView.CurrentRow.Index).Value
        End If
        
        Close()


    End Sub
End Class