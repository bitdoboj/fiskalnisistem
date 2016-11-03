<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PregledKasaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PregledKasaForm))
        Me.pregledKasa = New System.Windows.Forms.DataGridView()
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.izmjene = New System.Windows.Forms.Button()
        Me.Pregled = New System.Windows.Forms.Button()
        Me.servis = New System.Windows.Forms.Button()
        CType(Me.pregledKasa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pregledKasa
        '
        Me.pregledKasa.AllowUserToAddRows = False
        Me.pregledKasa.AllowUserToDeleteRows = False
        Me.pregledKasa.AllowUserToOrderColumns = True
        Me.pregledKasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pregledKasa.Location = New System.Drawing.Point(12, 74)
        Me.pregledKasa.Name = "pregledKasa"
        Me.pregledKasa.ReadOnly = True
        Me.pregledKasa.Size = New System.Drawing.Size(960, 376)
        Me.pregledKasa.TabIndex = 0
        '
        'searchBox
        '
        Me.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.searchBox.Location = New System.Drawing.Point(65, 48)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(192, 20)
        Me.searchBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pretraga"
        '
        'izmjene
        '
        Me.izmjene.Location = New System.Drawing.Point(896, 47)
        Me.izmjene.Name = "izmjene"
        Me.izmjene.Size = New System.Drawing.Size(75, 23)
        Me.izmjene.TabIndex = 3
        Me.izmjene.Text = "Izmjene"
        Me.izmjene.UseVisualStyleBackColor = True
        '
        'Pregled
        '
        Me.Pregled.Location = New System.Drawing.Point(818, 47)
        Me.Pregled.Name = "Pregled"
        Me.Pregled.Size = New System.Drawing.Size(75, 23)
        Me.Pregled.TabIndex = 4
        Me.Pregled.Text = "Pregled"
        Me.Pregled.UseVisualStyleBackColor = True
        '
        'servis
        '
        Me.servis.Location = New System.Drawing.Point(740, 47)
        Me.servis.Name = "servis"
        Me.servis.Size = New System.Drawing.Size(75, 23)
        Me.servis.TabIndex = 5
        Me.servis.Text = "Servis"
        Me.servis.UseVisualStyleBackColor = True
        '
        'PregledKasaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 462)
        Me.Controls.Add(Me.servis)
        Me.Controls.Add(Me.Pregled)
        Me.Controls.Add(Me.izmjene)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.pregledKasa)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "PregledKasaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pregled kasa"
        CType(Me.pregledKasa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pregledKasa As System.Windows.Forms.DataGridView
    Friend WithEvents searchBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents izmjene As System.Windows.Forms.Button
    Friend WithEvents Pregled As System.Windows.Forms.Button
    Friend WithEvents servis As System.Windows.Forms.Button
End Class
