<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServisPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServisPrint))
        Me.ServisReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'ServisReportViewer
        '
        Me.ServisReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ServisReportViewer.LocalReport.ReportEmbeddedResource = "FiskalniSistem.ServisKaseReport.rdlc"
        Me.ServisReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.ServisReportViewer.Name = "ServisReportViewer"
        Me.ServisReportViewer.Size = New System.Drawing.Size(984, 462)
        Me.ServisReportViewer.TabIndex = 0
        '
        'ServisPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(984, 462)
        Me.Controls.Add(Me.ServisReportViewer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ServisPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Štampanje servisa"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ServisReportViewer As Microsoft.Reporting.WinForms.ReportViewer
End Class
