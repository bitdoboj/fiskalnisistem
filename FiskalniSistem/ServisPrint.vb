Imports Microsoft.Reporting.WinForms

Public Class ServisPrint

    Private Sub ServisPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ServisReportViewer.LocalReport.SetParameters(komitentParameter)
        ServisReportViewer.LocalReport.SetParameters(brojKaseParameter)
        ServisReportViewer.LocalReport.SetParameters(opisServisaParameter)
        ServisReportViewer.LocalReport.SetParameters(datumServisaParameter)

        Me.ServisReportViewer.RefreshReport()
    End Sub
End Class