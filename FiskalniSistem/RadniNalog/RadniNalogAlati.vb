Module RadniNalogAlati

    Public Sub saveRadniNalog(radniNalog As RadniNalog)

        query = "INSERT INTO Kasa (BrojRn, komitentId, datumRn, mjestoRada, Serviser, opisKvara, dijagnostika, izvrseniRadovi) " +
                "VALUES ('" & radniNalog.BrojRn & "', '" & radniNalog.komitentId & "', '" & radniNalog.datumRn & "', '" & radniNalog.mjestoRada & "', '" & radniNalog.Serviser & "', '" & radniNalog.opisKvara & "', '" & radniNalog.dijagnostika & "', '" & radniNalog.izvrseniRadovi & "')"


    End Sub
End Module
