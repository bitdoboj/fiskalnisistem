<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServisForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServisForm))
        Me.servisiLista = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.datumServisa = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.opis = New System.Windows.Forms.TextBox()
        Me.Snimi = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.Label()
        Me.kasaId = New System.Windows.Forms.Label()
        Me.brojKase = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.brojModula = New System.Windows.Forms.Label()
        Me.pin = New System.Windows.Forms.Label()
        Me.simKartica = New System.Windows.Forms.Label()
        Me.brojTerminala = New System.Windows.Forms.Label()
        Me.telefon = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.adresaInstaliranja = New System.Windows.Forms.Label()
        Me.fLink = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ibsa = New System.Windows.Forms.Label()
        CType(Me.servisiLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'servisiLista
        '
        Me.servisiLista.AllowUserToAddRows = False
        Me.servisiLista.AllowUserToDeleteRows = False
        Me.servisiLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.servisiLista.Location = New System.Drawing.Point(12, 197)
        Me.servisiLista.Name = "servisiLista"
        Me.servisiLista.ReadOnly = True
        Me.servisiLista.Size = New System.Drawing.Size(960, 253)
        Me.servisiLista.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(604, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 15)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Datum servisa:"
        '
        'datumServisa
        '
        Me.datumServisa.CustomFormat = "dd/mm/yy"
        Me.datumServisa.Location = New System.Drawing.Point(609, 46)
        Me.datumServisa.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.datumServisa.MinDate = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.datumServisa.Name = "datumServisa"
        Me.datumServisa.Size = New System.Drawing.Size(226, 20)
        Me.datumServisa.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(604, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 15)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Opis:"
        '
        'opis
        '
        Me.opis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.opis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opis.Location = New System.Drawing.Point(607, 94)
        Me.opis.Multiline = True
        Me.opis.Name = "opis"
        Me.opis.Size = New System.Drawing.Size(228, 53)
        Me.opis.TabIndex = 50
        '
        'Snimi
        '
        Me.Snimi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Snimi.Image = CType(resources.GetObject("Snimi.Image"), System.Drawing.Image)
        Me.Snimi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Snimi.Location = New System.Drawing.Point(841, 94)
        Me.Snimi.Name = "Snimi"
        Me.Snimi.Padding = New System.Windows.Forms.Padding(10)
        Me.Snimi.Size = New System.Drawing.Size(131, 53)
        Me.Snimi.TabIndex = 51
        Me.Snimi.Text = "Snimi"
        Me.Snimi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Snimi.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(940, 65)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(13, 13)
        Me.id.TabIndex = 52
        Me.id.Text = "0"
        Me.id.Visible = False
        '
        'kasaId
        '
        Me.kasaId.AutoSize = True
        Me.kasaId.Location = New System.Drawing.Point(959, 65)
        Me.kasaId.Name = "kasaId"
        Me.kasaId.Size = New System.Drawing.Size(13, 13)
        Me.kasaId.TabIndex = 53
        Me.kasaId.Text = "0"
        Me.kasaId.Visible = False
        '
        'brojKase
        '
        Me.brojKase.AutoSize = True
        Me.brojKase.Font = New System.Drawing.Font("Arial Black", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brojKase.Location = New System.Drawing.Point(112, 33)
        Me.brojKase.Name = "brojKase"
        Me.brojKase.Size = New System.Drawing.Size(67, 28)
        Me.brojKase.TabIndex = 54
        Me.brojKase.Text = "Kasa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Modul:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Terminal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(364, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Telefon:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(387, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 15)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Pin:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(344, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 15)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Sim kartica:"
        '
        'brojModula
        '
        Me.brojModula.AutoSize = True
        Me.brojModula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brojModula.Location = New System.Drawing.Point(125, 75)
        Me.brojModula.Name = "brojModula"
        Me.brojModula.Size = New System.Drawing.Size(0, 15)
        Me.brojModula.TabIndex = 60
        '
        'pin
        '
        Me.pin.AutoSize = True
        Me.pin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pin.Location = New System.Drawing.Point(420, 75)
        Me.pin.Name = "pin"
        Me.pin.Size = New System.Drawing.Size(0, 15)
        Me.pin.TabIndex = 61
        '
        'simKartica
        '
        Me.simKartica.AutoSize = True
        Me.simKartica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.simKartica.Location = New System.Drawing.Point(420, 131)
        Me.simKartica.Name = "simKartica"
        Me.simKartica.Size = New System.Drawing.Size(0, 15)
        Me.simKartica.TabIndex = 62
        '
        'brojTerminala
        '
        Me.brojTerminala.AutoSize = True
        Me.brojTerminala.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brojTerminala.Location = New System.Drawing.Point(125, 103)
        Me.brojTerminala.Name = "brojTerminala"
        Me.brojTerminala.Size = New System.Drawing.Size(0, 15)
        Me.brojTerminala.TabIndex = 63
        '
        'telefon
        '
        Me.telefon.AutoSize = True
        Me.telefon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefon.Location = New System.Drawing.Point(420, 103)
        Me.telefon.Name = "telefon"
        Me.telefon.Size = New System.Drawing.Size(0, 15)
        Me.telefon.TabIndex = 64
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 15)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Adresa instaliranja:"
        '
        'adresaInstaliranja
        '
        Me.adresaInstaliranja.AutoSize = True
        Me.adresaInstaliranja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adresaInstaliranja.Location = New System.Drawing.Point(125, 131)
        Me.adresaInstaliranja.Name = "adresaInstaliranja"
        Me.adresaInstaliranja.Size = New System.Drawing.Size(0, 15)
        Me.adresaInstaliranja.TabIndex = 66
        '
        'fLink
        '
        Me.fLink.AutoSize = True
        Me.fLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fLink.Location = New System.Drawing.Point(125, 156)
        Me.fLink.Name = "fLink"
        Me.fLink.Size = New System.Drawing.Size(0, 15)
        Me.fLink.TabIndex = 69
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(74, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 15)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "F-Link:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(377, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 15)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "IBSA:"
        '
        'ibsa
        '
        Me.ibsa.AutoSize = True
        Me.ibsa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ibsa.Location = New System.Drawing.Point(417, 156)
        Me.ibsa.Name = "ibsa"
        Me.ibsa.Size = New System.Drawing.Size(0, 15)
        Me.ibsa.TabIndex = 70
        '
        'ServisForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(984, 462)
        Me.Controls.Add(Me.ibsa)
        Me.Controls.Add(Me.fLink)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.adresaInstaliranja)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.telefon)
        Me.Controls.Add(Me.brojTerminala)
        Me.Controls.Add(Me.simKartica)
        Me.Controls.Add(Me.pin)
        Me.Controls.Add(Me.brojModula)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.brojKase)
        Me.Controls.Add(Me.kasaId)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Snimi)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.opis)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.datumServisa)
        Me.Controls.Add(Me.servisiLista)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "ServisForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servis"
        CType(Me.servisiLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents servisiLista As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents datumServisa As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents opis As System.Windows.Forms.TextBox
    Friend WithEvents Snimi As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.Label
    Friend WithEvents kasaId As System.Windows.Forms.Label
    Friend WithEvents brojKase As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents brojModula As System.Windows.Forms.Label
    Friend WithEvents pin As System.Windows.Forms.Label
    Friend WithEvents simKartica As System.Windows.Forms.Label
    Friend WithEvents brojTerminala As System.Windows.Forms.Label
    Friend WithEvents telefon As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents adresaInstaliranja As System.Windows.Forms.Label
    Friend WithEvents fLink As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ibsa As System.Windows.Forms.Label
End Class
