<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NadjiKomitenta
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
        Me.KomitentiGridView = New System.Windows.Forms.DataGridView()
        Me.searchBox = New System.Windows.Forms.TextBox()
        CType(Me.KomitentiGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KomitentiGridView
        '
        Me.KomitentiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KomitentiGridView.Location = New System.Drawing.Point(12, 45)
        Me.KomitentiGridView.Name = "KomitentiGridView"
        Me.KomitentiGridView.Size = New System.Drawing.Size(340, 133)
        Me.KomitentiGridView.TabIndex = 0
        '
        'searchBox
        '
        Me.searchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBox.Location = New System.Drawing.Point(12, 19)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(340, 23)
        Me.searchBox.TabIndex = 1
        Me.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NadjiKomitenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(364, 190)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.KomitentiGridView)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NadjiKomitenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pretraga"
        CType(Me.KomitentiGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KomitentiGridView As System.Windows.Forms.DataGridView
    Friend WithEvents searchBox As System.Windows.Forms.TextBox
End Class
