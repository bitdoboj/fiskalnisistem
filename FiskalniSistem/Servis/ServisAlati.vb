Module ServisAlati
    Public Sub saveServis(servis As Servis)

        openConnection()
        If (servis.id <> 0) Then
            query = "UPDATE servis SET kasaId='" & servis.kasaId & "', datumServisa='" & servis.datumServisa & "', opis='" & servis.opis & "' WHERE id='" & servis.id & "'"
        Else
            query = "INSERT INTO servis (kasaId, datumServisa, opis) VALUES ('" & servis.kasaId & "', '" & servis.datumServisa & "', '" & servis.opis & "')"
        End If

        runSQLCommand()

    End Sub
End Module
