Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class RadniNalogPrint
    Private brojRadnogNaloga As ReportParameter
    Private nazivKomitenta As ReportParameter
    Private datumRn As ReportParameter
    Private mjestoRada As ReportParameter
    Private serviser As ReportParameter
    Private dijagnostika As ReportParameter
    Private izvrseniRadovi As ReportParameter
    Private opisKvara As ReportParameter
    Private Sub RadniNalogPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setRadniNalogParameter()
        Me.radniNalogPrintPrikaz.RefreshReport()
    End Sub

    Private Sub setRadniNalogParameter()

        Dim radniNalog As RadniNalog = getRadniNalog(radniNalogIdPretraga)

        Dim nazivKom As String = getNazivKomitenta(radniNalog.komitentId)

        brojRadnogNaloga = New ReportParameter("brojRadnogNaloga", radniNalog.brojRn)
        nazivKomitenta = New ReportParameter("nazivKomitenta", nazivKom)
        datumRn = New ReportParameter("datumRn", radniNalog.datumRn)
        mjestoRada = New ReportParameter("mjestoRada", radniNalog.mjestoRada)
        serviser = New ReportParameter("serviser", radniNalog.Serviser)
        dijagnostika = New ReportParameter("dijagnostika", radniNalog.dijagnostika)
        izvrseniRadovi = New ReportParameter("izvrseniRadovi", radniNalog.izvrseniRadovi)
        opisKvara = New ReportParameter("opisKvara", radniNalog.opisKvara)

        radniNalogPrintPrikaz.LocalReport.SetParameters(brojRadnogNaloga)
        radniNalogPrintPrikaz.LocalReport.SetParameters(nazivKomitenta)
        radniNalogPrintPrikaz.LocalReport.SetParameters(datumRn)
        radniNalogPrintPrikaz.LocalReport.SetParameters(mjestoRada)
        radniNalogPrintPrikaz.LocalReport.SetParameters(serviser)
        radniNalogPrintPrikaz.LocalReport.SetParameters(dijagnostika)
        radniNalogPrintPrikaz.LocalReport.SetParameters(izvrseniRadovi)
        radniNalogPrintPrikaz.LocalReport.SetParameters(opisKvara)

    End Sub
End Class