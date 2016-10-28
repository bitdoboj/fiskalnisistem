Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class modelForm

    Private Sub Snimi_Click(sender As Object, e As EventArgs) Handles Snimi.Click

        If (Me.nazivModela.Text = "") Then
            MsgBox("Morate upisati naziv modela")
            Exit Sub
        End If
        If (Me.id.Text = "") Then
            MsgBox("Ne mmogu se snimiti izmjene")
            Exit Sub
        End If

        updateModel(Me.id.Text, Me.nazivModela.Text, Me.opis.Text)
        clearModel()
        fillModeli()

    End Sub

    Public Sub clearModel()
        Me.id.Text = ""
        Me.opis.Text = ""
        Me.nazivModela.Text = ""
    End Sub

    Private Sub modelForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillModeli()
    End Sub

    Public Sub fillModeli()

        openConnection()

        query = "SELECT id, nazivModela AS Naziv, opis FROM model ORDER BY id"
        dataSet = New DataSet
        mySqlDataAdapter = New MySqlDataAdapter(query, sqlcon)
        mySqlDataAdapter.Fill(dataSet)

        Me.ModeliDataGridView.DataSource = dataSet.Tables(0)

        Dim id As DataGridViewColumn = ModeliDataGridView.Columns(0)
        id.Width = 60
        Dim opis As DataGridViewColumn = ModeliDataGridView.Columns(2)
        opis.Width = 300

        closeConnection()
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click

        If (Me.nazivModela.Text = "") Then
            MsgBox("Morate upisati naziv modela")
            Exit Sub
        End If

        saveModel(Me.nazivModela.Text, Me.opis.Text)
        clearModel()
        fillModeli()

    End Sub

    Private Sub ModeliDataGridView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ModeliDataGridView.CellMouseClick

        Dim modelId As Integer = ModeliDataGridView.Item(0, ModeliDataGridView.CurrentRow.Index).Value

        openConnection()

        query = "SELECT * FROM Model WHERE model.id=" & modelId & ";"
        mySqlDataAdapter = New MySqlDataAdapter(query, sqlcon)
        Dim sqlcmd As New MySqlCommand(query, sqlcon)
        Dim model As MySqlClient.MySqlDataReader = sqlcmd.ExecuteReader

        model.Read()
        Me.id.Text = model("id")
        Me.nazivModela.Text = model("nazivModela")
        Me.opis.Text = model("opis")

        closeConnection()
    End Sub

    Private Sub ModeliDataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ModeliDataGridView.CellMouseDoubleClick
        Dim modelId As Integer = ModeliDataGridView.Item(0, ModeliDataGridView.CurrentRow.Index).Value

        If MsgBox("Da li zelite izbrisati zapis", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            deleteRecord(modelId, "Model")
            fillModeli()
        End If
        
    End Sub

    
End Class