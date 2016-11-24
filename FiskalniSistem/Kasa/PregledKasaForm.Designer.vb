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
        Me.pregledKasa.Location = New System.Drawing.Point(12, 107)
        Me.pregledKasa.Name = "pregledKasa"
        Me.pregledKasa.ReadOnly = True
        Me.pregledKasa.Size = New System.Drawing.Size(960, 343)
        Me.pregledKasa.TabIndex = 0
        '
        'searchBox
        '
        Me.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.searchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBox.Location = New System.Drawing.Point(61, 72)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(184, 29)
        Me.searchBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pretraga"
        '
        'izmjene
        '
        Me.izmjene.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.izmjene.Image = CType(resources.GetObject("izmjene.Image"), System.Drawing.Image)
        Me.izmjene.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.izmjene.Location = New System.Drawing.Point(841, 48)
        Me.izmjene.Name = "izmjene"
        Me.izmjene.Padding = New System.Windows.Forms.Padding(10)
        Me.izmjene.Size = New System.Drawing.Size(131, 53)
        Me.izmjene.TabIndex = 3
        Me.izmjene.Text = "Izmjene"
        Me.izmjene.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.izmjene.UseVisualStyleBackColor = True
        '
        'Pregled
        '
        Me.Pregled.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pregled.Image = CType(resources.GetObject("Pregled.Image"), System.Drawing.Image)
        Me.Pregled.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Pregled.Location = New System.Drawing.Point(704, 48)
        Me.Pregled.Name = "Pregled"
        Me.Pregled.Padding = New System.Windows.Forms.Padding(10)
        Me.Pregled.Size = New System.Drawing.Size(131, 53)
        Me.Pregled.TabIndex = 4
        Me.Pregled.Text = "Pregled"
        Me.Pregled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Pregled.UseVisualStyleBackColor = True
        '
        'servis
        '
        Me.servis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.servis.Image = CType(resources.GetObject("servis.Image"), System.Drawing.Image)
        Me.servis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.servis.Location = New System.Drawing.Point(567, 48)
        Me.servis.Name = "servis"
        Me.servis.Padding = New System.Windows.Forms.Padding(10)
        Me.servis.Size = New System.Drawing.Size(131, 53)
        Me.servis.TabIndex = 5
        Me.servis.Text = "Servis"
        Me.servis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.servis.UseVisualStyleBackColor = True
        '
        'PregledKasaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
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
