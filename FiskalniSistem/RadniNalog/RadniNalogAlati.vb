Imports MySql.Data.MySqlClient
Imports MySql.Data

Module RadniNalogAlati
    Public Property Today As Date
    Public Sub saveRadniNalog(radniNalog As RadniNalog)

        query = "INSERT INTO radniNalog (brojRn, komitentId, datumRn, mjestoRada, Serviser, opisKvara, dijagnostika, izvrseniRadovi) " +
                "VALUES ('" & radniNalog.brojRn & "', '" & radniNalog.komitentId & "', '" & radniNalog.datumRn & "', '" & radniNalog.mjestoRada & "', '" & radniNalog.Serviser & "', '" & radniNalog.opisKvara & "', '" & radniNalog.dijagnostika & "', '" & radniNalog.izvrseniRadovi & "')"

        runSQLCommand()
    End Sub

    Public Function getBrojRadnogNaloga()


        Dim year As String = Date.Today.Year
        Dim id As Integer
        Dim brojRn As String

        openConnection()

        Try
            query = "SELECT MAX(id) AS id FROM radniNalog"
            mySqlDataAdapter = New MySqlDataAdapter(query, sqlcon)
            Dim sqlcmd As New MySqlCommand(query, sqlcon)
            Dim sqlBrojRN As MySqlClient.MySqlDataReader = sqlcmd.ExecuteReader

            sqlBrojRN.Read()
            id = sqlBrojRN("id")
            id = id + 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        brojRn = id.ToString + "/" + year
        closeConnection()

        Return brojRn
    End Function
End Module
