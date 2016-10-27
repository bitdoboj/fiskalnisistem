Imports MySql.Data.MySqlClient

Public Class NadjiModel

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs)
        fillModel()
    End Sub
    Private Sub fillModel()
        openConnection()

        query = "SELECT model.id, model.nazivModela FROM model ORDER BY model.nazivModela;"
        dataSet = New DataSet
        mySqlDataAdapter = New MySqlDataAdapter(query, sqlcon)
        mySqlDataAdapter.Fill(dataSet)

        Me.ModelGridView.DataSource = dataSet.Tables(0)

        Dim id As DataGridViewColumn = ModelGridView.Columns(0)
        id.Width = 60
        Dim naziv As DataGridViewColumn = ModelGridView.Columns(1)
        naziv.Width = 220

        closeConnection()
    End Sub

    Private Sub NadjiModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillModel()
    End Sub
    Private Sub ModelGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ModelGridView.CellMouseDoubleClick
        KasaForm.nazivModela.Text = ModelGridView.Item(1, ModelGridView.CurrentRow.Index).Value
        KasaForm.modelId.Text = ModelGridView.Item(0, ModelGridView.CurrentRow.Index).Value
        Close()
    End Sub
End Class