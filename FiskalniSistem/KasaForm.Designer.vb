<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KasaForm
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Snimi = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.napomena = New System.Windows.Forms.TextBox()
        Me.simKartica = New System.Windows.Forms.TextBox()
        Me.brojTerminala = New System.Windows.Forms.TextBox()
        Me.brojModula = New System.Windows.Forms.TextBox()
        Me.telefon = New System.Windows.Forms.TextBox()
        Me.pin = New System.Windows.Forms.TextBox()
        Me.brojKase = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.adresaInstaliranja = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nazivKomitenta = New System.Windows.Forms.Label()
        Me.komitentid = New System.Windows.Forms.Label()
        Me.Komitent = New System.Windows.Forms.GroupBox()
        Me.defiskalizacija = New System.Windows.Forms.CheckBox()
        Me.Model = New System.Windows.Forms.GroupBox()
        Me.modelId = New System.Windows.Forms.Label()
        Me.nazivModela = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.datumFiskalizacije = New System.Windows.Forms.DateTimePicker()
        Me.datumDefiskalizacije = New System.Windows.Forms.DateTimePicker()
        Me.datumDefiskalizacijeLabel = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.Label()
        Me.Komitent.SuspendLayout()
        Me.Model.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(294, 356)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 37
        '
        'Snimi
        '
        Me.Snimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Snimi.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Snimi.Location = New System.Drawing.Point(519, 341)
        Me.Snimi.Name = "Snimi"
        Me.Snimi.Size = New System.Drawing.Size(158, 42)
        Me.Snimi.TabIndex = 30
        Me.Snimi.Text = "Snimi"
        Me.Snimi.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(364, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 15)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "PIN"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(67, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 15)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Telefon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 15)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Broj modula"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Broj terminala"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 15)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "SIM:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Broj kase:"
        '
        'napomena
        '
        Me.napomena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.napomena.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.napomena.Location = New System.Drawing.Point(116, 283)
        Me.napomena.Multiline = True
        Me.napomena.Name = "napomena"
        Me.napomena.Size = New System.Drawing.Size(349, 100)
        Me.napomena.TabIndex = 29
        '
        'simKartica
        '
        Me.simKartica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.simKartica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.simKartica.Location = New System.Drawing.Point(117, 209)
        Me.simKartica.Name = "simKartica"
        Me.simKartica.Size = New System.Drawing.Size(224, 21)
        Me.simKartica.TabIndex = 4
        '
        'brojTerminala
        '
        Me.brojTerminala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.brojTerminala.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brojTerminala.Location = New System.Drawing.Point(117, 135)
        Me.brojTerminala.Name = "brojTerminala"
        Me.brojTerminala.Size = New System.Drawing.Size(148, 21)
        Me.brojTerminala.TabIndex = 2
        '
        'brojModula
        '
        Me.brojModula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.brojModula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brojModula.Location = New System.Drawing.Point(117, 101)
        Me.brojModula.Name = "brojModula"
        Me.brojModula.Size = New System.Drawing.Size(148, 21)
        Me.brojModula.TabIndex = 1
        '
        'telefon
        '
        Me.telefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.telefon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefon.Location = New System.Drawing.Point(117, 171)
        Me.telefon.Name = "telefon"
        Me.telefon.Size = New System.Drawing.Size(148, 21)
        Me.telefon.TabIndex = 3
        '
        'pin
        '
        Me.pin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pin.Location = New System.Drawing.Point(399, 209)
        Me.pin.Name = "pin"
        Me.pin.Size = New System.Drawing.Size(66, 21)
        Me.pin.TabIndex = 5
        Me.pin.Text = "0"
        '
        'brojKase
        '
        Me.brojKase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.brojKase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brojKase.Location = New System.Drawing.Point(117, 39)
        Me.brojKase.Name = "brojKase"
        Me.brojKase.Size = New System.Drawing.Size(268, 26)
        Me.brojKase.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 283)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Napomena:"
        '
        'adresaInstaliranja
        '
        Me.adresaInstaliranja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.adresaInstaliranja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adresaInstaliranja.Location = New System.Drawing.Point(117, 246)
        Me.adresaInstaliranja.Name = "adresaInstaliranja"
        Me.adresaInstaliranja.Size = New System.Drawing.Size(348, 21)
        Me.adresaInstaliranja.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 15)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Adresa instaliranja:"
        '
        'nazivKomitenta
        '
        Me.nazivKomitenta.AutoSize = True
        Me.nazivKomitenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nazivKomitenta.Location = New System.Drawing.Point(34, 19)
        Me.nazivKomitenta.Name = "nazivKomitenta"
        Me.nazivKomitenta.Size = New System.Drawing.Size(71, 17)
        Me.nazivKomitenta.TabIndex = 41
        Me.nazivKomitenta.Text = "Komitent"
        '
        'komitentid
        '
        Me.komitentid.AutoSize = True
        Me.komitentid.Location = New System.Drawing.Point(6, 21)
        Me.komitentid.Name = "komitentid"
        Me.komitentid.Size = New System.Drawing.Size(13, 13)
        Me.komitentid.TabIndex = 42
        Me.komitentid.Text = "0"
        '
        'Komitent
        '
        Me.Komitent.Controls.Add(Me.komitentid)
        Me.Komitent.Controls.Add(Me.nazivKomitenta)
        Me.Komitent.Location = New System.Drawing.Point(523, 42)
        Me.Komitent.Name = "Komitent"
        Me.Komitent.Size = New System.Drawing.Size(235, 58)
        Me.Komitent.TabIndex = 43
        Me.Komitent.TabStop = False
        Me.Komitent.Text = "Komitent"
        '
        'defiskalizacija
        '
        Me.defiskalizacija.AutoSize = True
        Me.defiskalizacija.Location = New System.Drawing.Point(523, 246)
        Me.defiskalizacija.Name = "defiskalizacija"
        Me.defiskalizacija.Size = New System.Drawing.Size(126, 17)
        Me.defiskalizacija.TabIndex = 44
        Me.defiskalizacija.Text = "Kasa defiskalizovana"
        Me.defiskalizacija.UseVisualStyleBackColor = True
        '
        'Model
        '
        Me.Model.Controls.Add(Me.modelId)
        Me.Model.Controls.Add(Me.nazivModela)
        Me.Model.Location = New System.Drawing.Point(522, 120)
        Me.Model.Name = "Model"
        Me.Model.Size = New System.Drawing.Size(235, 58)
        Me.Model.TabIndex = 45
        Me.Model.TabStop = False
        Me.Model.Text = "Model"
        '
        'modelId
        '
        Me.modelId.AutoSize = True
        Me.modelId.Location = New System.Drawing.Point(6, 21)
        Me.modelId.Name = "modelId"
        Me.modelId.Size = New System.Drawing.Size(13, 13)
        Me.modelId.TabIndex = 42
        Me.modelId.Text = "0"
        '
        'nazivModela
        '
        Me.nazivModela.AutoSize = True
        Me.nazivModela.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nazivModela.Location = New System.Drawing.Point(34, 19)
        Me.nazivModela.Name = "nazivModela"
        Me.nazivModela.Size = New System.Drawing.Size(51, 17)
        Me.nazivModela.TabIndex = 41
        Me.nazivModela.Text = "Model"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(520, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 15)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Datum fiskalizacije"
        '
        'datumFiskalizacije
        '
        Me.datumFiskalizacije.CustomFormat = "dd/mm/yy"
        Me.datumFiskalizacije.Location = New System.Drawing.Point(523, 209)
        Me.datumFiskalizacije.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.datumFiskalizacije.MinDate = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.datumFiskalizacije.Name = "datumFiskalizacije"
        Me.datumFiskalizacije.Size = New System.Drawing.Size(147, 20)
        Me.datumFiskalizacije.TabIndex = 40
        '
        'datumDefiskalizacije
        '
        Me.datumDefiskalizacije.CustomFormat = "dd/mm/yy"
        Me.datumDefiskalizacije.Location = New System.Drawing.Point(522, 292)
        Me.datumDefiskalizacije.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.datumDefiskalizacije.MinDate = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.datumDefiskalizacije.Name = "datumDefiskalizacije"
        Me.datumDefiskalizacije.Size = New System.Drawing.Size(147, 20)
        Me.datumDefiskalizacije.TabIndex = 47
        Me.datumDefiskalizacije.Visible = False
        '
        'datumDefiskalizacijeLabel
        '
        Me.datumDefiskalizacijeLabel.AutoSize = True
        Me.datumDefiskalizacijeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datumDefiskalizacijeLabel.Location = New System.Drawing.Point(522, 269)
        Me.datumDefiskalizacijeLabel.Name = "datumDefiskalizacijeLabel"
        Me.datumDefiskalizacijeLabel.Size = New System.Drawing.Size(124, 15)
        Me.datumDefiskalizacijeLabel.TabIndex = 48
        Me.datumDefiskalizacijeLabel.Text = "Datum defiskalizacije"
        Me.datumDefiskalizacijeLabel.Visible = False
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(31, 400)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(13, 13)
        Me.id.TabIndex = 49
        Me.id.Text = "0"
        Me.id.Visible = False
        '
        'KasaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 433)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.datumDefiskalizacijeLabel)
        Me.Controls.Add(Me.datumDefiskalizacije)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Model)
        Me.Controls.Add(Me.defiskalizacija)
        Me.Controls.Add(Me.datumFiskalizacije)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.adresaInstaliranja)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Snimi)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.napomena)
        Me.Controls.Add(Me.simKartica)
        Me.Controls.Add(Me.brojTerminala)
        Me.Controls.Add(Me.brojModula)
        Me.Controls.Add(Me.telefon)
        Me.Controls.Add(Me.pin)
        Me.Controls.Add(Me.brojKase)
        Me.Controls.Add(Me.Komitent)
        Me.Name = "KasaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Kasa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Komitent.ResumeLayout(False)
        Me.Komitent.PerformLayout()
        Me.Model.ResumeLayout(False)
        Me.Model.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Snimi As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents napomena As System.Windows.Forms.TextBox
    Friend WithEvents simKartica As System.Windows.Forms.TextBox
    Friend WithEvents brojTerminala As System.Windows.Forms.TextBox
    Friend WithEvents brojModula As System.Windows.Forms.TextBox
    Friend WithEvents telefon As System.Windows.Forms.TextBox
    Friend WithEvents pin As System.Windows.Forms.TextBox
    Friend WithEvents brojKase As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents adresaInstaliranja As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nazivKomitenta As System.Windows.Forms.Label
    Friend WithEvents komitentid As System.Windows.Forms.Label
    Friend WithEvents Komitent As System.Windows.Forms.GroupBox
    Friend WithEvents defiskalizacija As System.Windows.Forms.CheckBox
    Friend WithEvents Model As System.Windows.Forms.GroupBox
    Friend WithEvents modelId As System.Windows.Forms.Label
    Friend WithEvents nazivModela As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents datumFiskalizacije As System.Windows.Forms.DateTimePicker
    Friend WithEvents datumDefiskalizacije As System.Windows.Forms.DateTimePicker
    Friend WithEvents datumDefiskalizacijeLabel As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.Label
End Class
