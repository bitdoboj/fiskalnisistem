<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadniNalogPrint
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RadniNalogPrint))
        Me.radniNalogPrintPrikaz = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MySqlDataReaderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.MySqlDataReaderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radniNalogPrintPrikaz
        '
        Me.radniNalogPrintPrikaz.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "radniNalogDataSet"
        ReportDataSource1.Value = Me.MySqlDataReaderBindingSource
        Me.radniNalogPrintPrikaz.LocalReport.DataSources.Add(ReportDataSource1)
        Me.radniNalogPrintPrikaz.LocalReport.ReportEmbeddedResource = "FiskalniSistem.RadniNalogReport.rdlc"
        Me.radniNalogPrintPrikaz.Location = New System.Drawing.Point(0, 0)
        Me.radniNalogPrintPrikaz.Name = "radniNalogPrintPrikaz"
        Me.radniNalogPrintPrikaz.Size = New System.Drawing.Size(984, 462)
        Me.radniNalogPrintPrikaz.TabIndex = 0
        '
        'MySqlDataReaderBindingSource
        '
        Me.MySqlDataReaderBindingSource.DataSource = GetType(MySql.Data.MySqlClient.MySqlDataReader)
        '
        'RadniNalogPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 462)
        Me.Controls.Add(Me.radniNalogPrintPrikaz)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "RadniNalogPrint"
        Me.Text = "Štampanje radnog naloga"
        CType(Me.MySqlDataReaderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents radniNalogPrintPrikaz As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MySqlDataReaderBindingSource As System.Windows.Forms.BindingSource
End Class
