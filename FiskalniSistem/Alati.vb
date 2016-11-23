Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports Microsoft.Reporting.WinForms

Module Alati
    Public DatabaseName As String = "fiskalnisistem"
    Public server As String = My.Settings.ServerName
    Public userName As String = My.Settings.User
    Public password As String = My.Settings.Password
    Public connString As String = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
    Public sqlcon As New MySqlConnection(connectionString:=connString)
    Public query As String
    Public mySqlCommand As MySqlCommand = New MySqlCommand
    Public dataSet As DataSet
    Public mySqlDataAdapter As MySqlDataAdapter
    Public komitentIdPretraga As Integer
    Public kasaIdPretraga As Integer
    Public radniNalogIdPretraga As Integer
    Public komitentParameter As ReportParameter
    Public brojKaseParameter As ReportParameter
    Public opisServisaParameter As ReportParameter
    Public datumServisaParameter As ReportParameter
    

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

    Public Sub deleteRecord(id As Integer, tabela As String)

        query = "DELETE FROM " & tabela & " WHERE id='" & id & "';"

        runSQLCommand()

    End Sub

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
