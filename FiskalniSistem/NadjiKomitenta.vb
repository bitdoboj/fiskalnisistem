Imports MySql.Data.MySqlClient


Public Class NadjiKomitenta

    Private Sub NadjiKomitenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        searchBox.Focus()
        fillKomitenti()

    End Sub
    Private Sub fillKomitenti()

        openConnection()

        query = "SELECT Komitent.id, Komitent.nazivKomitenta FROM Komitent WHERE (Komitent.nazivKomitenta LIKE '%" & Me.searchBox.Text & "%') ORDER BY Komitent.nazivKomitenta;"
        dataSet = New DataSet
        mySqlDataAdapter = New MySqlDataAdapter(query, sqlcon)
        mySqlDataAdapter.Fill(dataSet)

        Me.KomitentiGridView.DataSource = dataSet.Tables(0)

        Dim id As DataGridViewColumn = KomitentiGridView.Columns(0)
        id.Width = 60
        Dim naziv As DataGridViewColumn = KomitentiGridView.Columns(1)
        naziv.Width = 220

        closeConnection()

    End Sub

    
    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        fillKomitenti()
    End Sub

   

    Private Sub KomitentiGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles KomitentiGridView.CellMouseDoubleClick
        KasaForm.nazivKomitenta.Text = KomitentiGridView.Item(1, KomitentiGridView.CurrentRow.Index).Value
        KasaForm.komitentid.Text = KomitentiGridView.Item(0, KomitentiGridView.CurrentRow.Index).Value
        Close()
        

    End Sub
End Class