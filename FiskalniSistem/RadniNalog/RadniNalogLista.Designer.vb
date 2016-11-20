<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadniNalogLista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RadniNalogLista))
        Me.Pregled = New System.Windows.Forms.Button()
        Me.pregledRadniNaloga = New System.Windows.Forms.DataGridView()
        CType(Me.pregledRadniNaloga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pregled
        '
        Me.Pregled.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pregled.Image = CType(resources.GetObject("Pregled.Image"), System.Drawing.Image)
        Me.Pregled.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Pregled.Location = New System.Drawing.Point(704, 46)
        Me.Pregled.Name = "Pregled"
        Me.Pregled.Padding = New System.Windows.Forms.Padding(10)
        Me.Pregled.Size = New System.Drawing.Size(131, 53)
        Me.Pregled.TabIndex = 6
        Me.Pregled.Text = "Pregled"
        Me.Pregled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Pregled.UseVisualStyleBackColor = True
        '
        'pregledRadniNaloga
        '
        Me.pregledRadniNaloga.AllowUserToAddRows = False
        Me.pregledRadniNaloga.AllowUserToDeleteRows = False
        Me.pregledRadniNaloga.AllowUserToOrderColumns = True
        Me.pregledRadniNaloga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pregledRadniNaloga.Location = New System.Drawing.Point(12, 105)
        Me.pregledRadniNaloga.Name = "pregledRadniNaloga"
        Me.pregledRadniNaloga.ReadOnly = True
        Me.pregledRadniNaloga.Size = New System.Drawing.Size(960, 343)
        Me.pregledRadniNaloga.TabIndex = 5
        '
        'RadniNalogLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.Pregled)
        Me.Controls.Add(Me.pregledRadniNaloga)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "RadniNalogLista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pregled radnih naloga"
        CType(Me.pregledRadniNaloga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pregled As System.Windows.Forms.Button
    Friend WithEvents pregledRadniNaloga As System.Windows.Forms.DataGridView
End Class
