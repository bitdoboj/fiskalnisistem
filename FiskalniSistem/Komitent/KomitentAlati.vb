Imports MySql.Data.MySqlClient
Imports MySql.Data

Module KomitentAlati
    Public Sub saveKomitent(nazivKomitenta As String, telefon As String, Adresa As String, jib As String, pib As String, napomena As String)

        query = "INSERT INTO Komitent (nazivKomitenta, telefon, adresa, jib, pib, napomena) " +
                "VALUES ('" & nazivKomitenta & "', '" & telefon & "', '" & Adresa & "',  '" & jib & "', '" & pib & "','" & napomena & "')"

        runSQLCommand()

    End Sub

    Public Sub updateKomitent(id As Integer, nazivKomitenta As String, telefon As String, adresa As String, jib As String, pib As String, napomena As String)

        query = "UPDATE Komitent SET nazivKomitenta='" & nazivKomitenta & "', telefon='" & telefon & "',  adresa='" & adresa & "',  jib='" & jib & "',  pib='" & pib & "',  napomena='" & napomena & "' WHERE id='" & id & "'"

        runSQLCommand()

    End Sub
    Public Function getKomitent(id As Integer)

        Dim komitent As New Komitent

        openConnection()

        Try

            query = "SELECT * FROM komitent WHERE komitent.id=" & id & ";"
            mySqlDataAdapter = New MySqlDataAdapter(query, sqlcon)
            Dim sqlcmd As New MySqlCommand(query, sqlcon)
            Dim sqlKomitent As MySqlClient.MySqlDataReader = sqlcmd.ExecuteReader

            sqlKomitent.Read()
            komitent.id = sqlKomitent("id")
            komitent.nazivKomitenta = sqlKomitent("nazivKomitenta")
            komitent.telefon = sqlKomitent("telefon")
            komitent.adresa = sqlKomitent("adresa")
            komitent.jib = sqlKomitent("jib")
            komitent.pib = sqlKomitent("pib")
            komitent.napomena = If(IsDBNull(sqlKomitent("napomena")), "", sqlKomitent("napomena"))

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        closeConnection()

        Return komitent
    End Function
    Public Function getNazivKomitenta(id As Integer)

        Dim naziv As String
        openConnection()

        query = "SELECT komitent.nazivKomitenta FROM komitent WHERE komitent.id=" & id & ";"
        mySqlDataAdapter = New MySqlDataAdapter(query, sqlcon)
        Dim sqlcmd As New MySqlCommand(query, sqlcon)
        Dim nazivKomitenta As MySqlClient.MySqlDataReader = sqlcmd.ExecuteReader

        nazivKomitenta.Read()
        naziv = nazivKomitenta("nazivKomitenta")

        closeConnection()

        Return naziv
    End Function
    Public Function getNazivKomitentaByKasaId(kasaId)

        Dim naziv As String
        openConnection()
        query = "SELECT komitent.nazivKomitenta FROM komitent " +
                "INNER JOIN kasa ON komitent.id = kasa.komitentId " +
                "WHERE kasa.id=" & kasaId & ";"

        mySqlDataAdapter = New MySqlDataAdapter(query, sqlcon)
        Dim sqlcmd As New MySqlCommand(query, sqlcon)
        Dim nazivKomitenta As MySqlClient.MySqlDataReader = sqlcmd.ExecuteReader

        nazivKomitenta.Read()

        naziv = nazivKomitenta("nazivKomitenta")

        closeConnection()

        Return naziv
    End Function
End Module
