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

    Public Function getRadniNalog(id As Integer)

        Dim radniNalog As New RadniNalog
        openConnection()
        Try

            query = "SELECT * FROM radniNalog WHERE radninalog.id=" & id & ";"
            mySqlDataAdapter = New MySqlDataAdapter(query, sqlcon)
            Dim sqlcmd As New MySqlCommand(query, sqlcon)
            Dim sqlRadniNalog As MySqlClient.MySqlDataReader = sqlcmd.ExecuteReader

            sqlRadniNalog.Read()
            radniNalog.id = sqlRadniNalog("id")
            radniNalog.brojRn = sqlRadniNalog("brojRn")
            radniNalog.komitentId = sqlRadniNalog("komitentId")
            radniNalog.datumRn = sqlRadniNalog("datumRn")
            radniNalog.mjestoRada = sqlRadniNalog("mjestoRada")
            radniNalog.Serviser = sqlRadniNalog("Serviser")
            radniNalog.dijagnostika = sqlRadniNalog("opisKvara")
            radniNalog.izvrseniRadovi = sqlRadniNalog("dijagnostika")
            radniNalog.opisKvara = If(IsDBNull(sqlRadniNalog("izvrseniRadovi")), "", sqlRadniNalog("izvrseniRadovi"))

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        closeConnection()
        Return radniNalog
    End Function
End Module
