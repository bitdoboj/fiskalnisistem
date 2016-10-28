Imports MySql.Data.MySqlClient
Imports MySql.Data

Module Alati
    Public DatabaseName As String = "fiskalnisistem"
    Public server As String = "localhost"
    Public userName As String = "root"
    Public password As String = "S26059"
    Public connString As String = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
    Public sqlcon As New MySqlConnection(connectionString:=connString)
    Public query As String
    Public mySqlCommand As MySqlCommand = New MySqlCommand
    Public dataSet As DataSet
    Public mySqlDataAdapter As MySqlDataAdapter
    Public komitentIdPretraga As Integer
    Public kasaIdPretraga As Integer

    Public Sub openConnection()
        Try
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub closeConnection()
        Try
            If sqlcon.State = ConnectionState.Open Then
                sqlcon.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub saveKomitent(nazivKomitenta As String, telefon As String, Adresa As String, brojUgovora As String, jib As String, pib As String, napomena As String)

        query = "INSERT INTO Komitent (nazivKomitenta, telefon, adresa, brojUgovora, jib, pib, napomena) " +
                "VALUES ('" & nazivKomitenta & "', '" & telefon & "', '" & Adresa & "', '" & brojUgovora & "', '" & jib & "', '" & pib & "','" & napomena & "')"

        runSQLCommand()

    End Sub

    Public Sub updateKomitent(id As Integer, nazivKomitenta As String, telefon As String, adresa As String, brojUgovora As String, jib As String, pib As String, napomena As String)

        query = "UPDATE Komitent SET nazivKomitenta='" & nazivKomitenta & "', telefon='" & telefon & "',  adresa='" & adresa & "',  brojUgovora='" & brojUgovora & "',  jib='" & jib & "',  pib='" & pib & "',  napomena='" & napomena & "' WHERE id='" & id & "'"

        runSQLCommand()

    End Sub

    Public Sub saveModel(nazivModela As String, opis As String)

        query = "INSERT INTO model (nazivModela, opis) VALUES ('" & nazivModela & "', '" & opis & "')"

        runSQLCommand()

    End Sub

    Public Sub updateModel(id As Integer, nazivModela As String, opis As String)

        query = "UPDATE model SET nazivModela='" & nazivModela & "', opis='" & opis & "' WHERE id='" & id & "'"

        runSQLCommand()

    End Sub

    Public Sub saveKasa(kasa As Kasa)

        If (kasa.id <> 0) Then
            updateKasa(kasa)
            Exit Sub
        End If
        query = "INSERT INTO Kasa (brojKase, komitentId, brojModula, brojTerminala, simKartica, pin, telefon, adresaInstaliranja, modelId, defiskalicacija, datumDefiskalizacije, datumFiskalizacije, napomena) " +
                "VALUES ('" & kasa.brojKase & "', '" & kasa.komitentId & "', '" & kasa.brojModula & "', '" & kasa.brojTerminala & "', '" & kasa.simKartica & "', '" & kasa.pin & "', '" & kasa.telefon & "', '" & kasa.adresaInstaliranja & "', '" & kasa.modelId & "', '" & kasa.defiskalicacija & "', '" & kasa.datumDefiskalizacije & "', '" & kasa.datumFiskalizacije & "','" & kasa.napomena & "')"

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
                    "defiskalicacija='" & kasa.defiskalicacija & "', " +
                    "datumDefiskalizacije='" & kasa.datumDefiskalizacije & "', " +
                    "napomena='" & kasa.napomena & "' " +
                "WHERE id='" & kasa.id & "'"

        runSQLCommand()

    End Sub

    Public Sub deleteRecord(id As Integer, tabela As String)

        query = "DELETE FROM " & tabela & " WHERE id='" & id & "';"

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
            kasa.defiskalicacija = sqlKasa("defiskalicacija")
            kasa.datumDefiskalizacije = If(IsDBNull(sqlKasa("datumDefiskalizacije")), "", sqlKasa("datumDefiskalizacije"))
            kasa.datumFiskalizacije = If(IsDBNull(sqlKasa("datumFiskalizacije")), "", sqlKasa("datumFiskalizacije"))
            kasa.napomena = If(IsDBNull(sqlKasa("napomena")), "", sqlKasa("napomena"))

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        closeConnection()

        Return kasa
    End Function

    Public Sub saveServis(servis As Servis)

        openConnection()
        If (servis.id <> 0) Then
            query = "UPDATE servis SET kasaId='" & servis.kasaId & "', datumServisa='" & servis.datumServisa & "', opis='" & servis.opis & "' WHERE id='" & servis.id & "'"
        Else
            query = "INSERT INTO servis (kasaId, datumServisa, opis) VALUES ('" & servis.kasaId & "', '" & servis.datumServisa & "', '" & servis.opis & "')"
        End If

        runSQLCommand()

    End Sub
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

    Public Function getDataFromDatabase(query As String)
        'Veoma vazna funkcija, pozeljne razne dorade jer program koristi
        'Funkcija koja vraca podatke iz baze na osnovu querya

        openConnection()
        Try
            dataSet = New DataSet
            mySqlDataAdapter = New MySqlDataAdapter(query, sqlcon)
            mySqlDataAdapter.Fill(dataSet)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        closeConnection()

        Return dataSet.Tables(0)
    End Function

    Public Sub runSQLCommand()
        'Izvrsavanje sql komande
        openConnection()
        Try
            mySqlCommand.Connection = sqlcon
            mySqlCommand.CommandText = query
            mySqlCommand.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        closeConnection()
    End Sub


End Module
