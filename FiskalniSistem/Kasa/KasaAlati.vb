Imports MySql.Data.MySqlClient
Imports MySql.Data

Module KasaAlati
    Public Sub saveKasa(kasa As Kasa)

        If (kasa.id <> 0) Then
            updateKasa(kasa)
            Exit Sub
        End If
        query = "INSERT INTO Kasa (" +
                "brojKase, komitentId, brojModula, " +
                "brojTerminala, simKartica, pin, telefon, adresaInstaliranja, " +
                "modelId, defiskalizacija, datumDefiskalizacije, dokumentacijaPoslata, datumSlanjaDokumentacije, datumFiskalizacije, fiskalnaPlomba, programskaPlomba, brojUgovora, fLink, ibsa, napomena) " +
                "VALUES ('" & kasa.brojKase & "', '" & kasa.komitentId & "', '" & kasa.brojModula & "', '" & kasa.brojTerminala & "', '" & kasa.simKartica & "', '" & kasa.pin & "', '" & kasa.telefon & "', '" & kasa.adresaInstaliranja & "', '" & kasa.modelId & "', '" & kasa.defiskalizacija & "', '" & kasa.datumDefiskalizacije & "', '" & kasa.dokumentacijaPoslata & "', '" & kasa.datumSlanjaDokumentacije & "', '" & kasa.datumFiskalizacije & "', '" & kasa.fiskalnaPlomba & "', '" & kasa.programskaPlomba & "', '" & kasa.brojUgovora & "', '" & kasa.fLink & "', '" & kasa.ibsa & "','" & kasa.napomena & "')"

        runSQLCommand()

    End Sub
    Public Sub updateKasa(kasa As Kasa)

        query = "UPDATE kasa SET " +
                    "brojKase='" & kasa.brojKase & "', " +
                    "komitentId='" & kasa.komitentId & "', " +
                    "brojModula='" & kasa.brojModula & "', " +
                    "brojTerminala='" & kasa.brojTerminala & "', " +
                    "simKartica='" & kasa.simKartica & "', " +
                    "pin='" & kasa.pin & "', " +
                    "telefon='" & kasa.telefon & "', " +
                    "adresaInstaliranja='" & kasa.adresaInstaliranja & "', " +
                    "modelId='" & kasa.modelId & "', " +
                    "datumFiskalizacije='" & kasa.datumFiskalizacije & "', " +
                    "dokumentacijaPoslata='" & kasa.dokumentacijaPoslata & "', " +
                    "datumSlanjaDokumentacije='" & kasa.datumSlanjaDokumentacije & "', " +
                    "defiskalizacija='" & kasa.defiskalizacija & "', " +
                    "datumDefiskalizacije='" & kasa.datumDefiskalizacije & "', " +
                    "fiskalnaPlomba='" & kasa.fiskalnaPlomba & "', " +
                    "programskaPlomba='" & kasa.programskaPlomba & "', " +
                    "brojUgovora='" & kasa.brojUgovora & "', " +
                    "fLink='" & kasa.fLink & "', " +
                    "ibsa='" & kasa.ibsa & "', " +
                    "napomena='" & kasa.napomena & "' " +
                "WHERE id='" & kasa.id & "'"

        runSQLCommand()

    End Sub
    Public Function getKasa(id As Integer)

        Dim kasa As New Kasa

        openConnection()

        Try

            query = "SELECT * FROM kasa WHERE kasa.id=" & id & ";"
            mySqlDataAdapter = New MySqlDataAdapter(query, sqlcon)
            Dim sqlcmd As New MySqlCommand(query, sqlcon)
            Dim sqlKasa As MySqlClient.MySqlDataReader = sqlcmd.ExecuteReader

            sqlKasa.Read()
            kasa.id = sqlKasa("id")
            kasa.brojKase = sqlKasa("brojKase")
            kasa.komitentId = sqlKasa("komitentId")
            kasa.brojModula = sqlKasa("brojModula")
            kasa.brojTerminala = sqlKasa("brojTerminala")
            kasa.simKartica = sqlKasa("simKartica")
            kasa.pin = sqlKasa("pin")
            kasa.telefon = sqlKasa("telefon")
            kasa.adresaInstaliranja = sqlKasa("adresaInstaliranja")
            kasa.modelId = sqlKasa("modelId")
            kasa.defiskalizacija = sqlKasa("defiskalizacija")
            kasa.datumDefiskalizacije = If(IsDBNull(sqlKasa("datumDefiskalizacije")), "", sqlKasa("datumDefiskalizacije"))
            kasa.datumFiskalizacije = If(IsDBNull(sqlKasa("datumFiskalizacije")), "", sqlKasa("datumFiskalizacije"))
            kasa.dokumentacijaPoslata = sqlKasa("dokumentacijaPoslata")
            kasa.datumSlanjaDokumentacije = If(IsDBNull(sqlKasa("datumSlanjaDokumentacije")), "", sqlKasa("datumSlanjaDokumentacije"))
            kasa.programskaPlomba = sqlKasa("programskaPlomba")
            kasa.fiskalnaPlomba = sqlKasa("fiskalnaPlomba")
            kasa.fLink = sqlKasa("fLink")
            kasa.ibsa = sqlKasa("ibsa")
            kasa.napomena = If(IsDBNull(sqlKasa("napomena")), "", sqlKasa("napomena"))

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        closeConnection()

        Return kasa
    End Function
    Public Function getBrojKase(id As Integer)

        Dim naziv As String

        openConnection()

        query = "SELECT kasa.brojKase FROM kasa WHERE kasa.id=" & id & ";"
        mySqlDataAdapter = New MySqlDataAdapter(query, sqlcon)
        Dim sqlcmd As New MySqlCommand(query, sqlcon)
        Dim brojKase As MySqlClient.MySqlDataReader = sqlcmd.ExecuteReader



        brojKase.Read()

        naziv = brojKase("brojKase")

        closeConnection()
        Return naziv
    End Function
End Module
