Imports MySql.Data.MySqlClient
Imports MySql.Data

Module ModelKaseAlati
    Public Sub saveModel(nazivModela As String, opis As String)

        query = "INSERT INTO model (nazivModela, opis) VALUES ('" & nazivModela & "', '" & opis & "')"

        runSQLCommand()

    End Sub

    Public Sub updateModel(id As Integer, nazivModela As String, opis As String)

        query = "UPDATE model SET nazivModela='" & nazivModela & "', opis='" & opis & "' WHERE id='" & id & "'"

        runSQLCommand()

    End Sub
    Public Function getNazivModela(id As Integer)

        Dim naziv As String
        openConnection()

        query = "SELECT model.nazivModela FROM model WHERE model.id=" & id & ";"
        mySqlDataAdapter = New MySqlDataAdapter(query, sqlcon)
        Dim sqlcmd As New MySqlCommand(query, sqlcon)
        Dim nazivModela As MySqlClient.MySqlDataReader = sqlcmd.ExecuteReader

        nazivModela.Read()
        naziv = nazivModela("nazivModela")

        closeConnection()

        Return naziv
    End Function
End Module
