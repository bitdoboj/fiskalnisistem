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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KasaForm))
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.programskaPlomba = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.fiskalnaPlomba = New System.Windows.Forms.TextBox()
        Me.datumSlanjaLabel = New System.Windows.Forms.Label()
        Me.datumSlanjaDokumentacije = New System.Windows.Forms.DateTimePicker()
        Me.dokumentacijaPoslata = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.brojUgovora = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ibsa = New System.Windows.Forms.TextBox()
        Me.fLink = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Komitent.SuspendLayout()
        Me.Model.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(357, 384)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 37
        '
        'Snimi
        '
        Me.Snimi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Snimi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Snimi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Snimi.Image = CType(resources.GetObject("Snimi.Image"), System.Drawing.Image)
        Me.Snimi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Snimi.Location = New System.Drawing.Point(762, 358)
        Me.Snimi.Name = "Snimi"
        Me.Snimi.Padding = New System.Windows.Forms.Padding(10)
        Me.Snimi.Size = New System.Drawing.Size(131, 53)
        Me.Snimi.TabIndex = 30
        Me.Snimi.Text = "Snimi"
        Me.Snimi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Snimi.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(427, 194)
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
        Me.Label7.Location = New System.Drawing.Point(130, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 15)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Telefon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(104, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 15)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Broj modula"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(94, 122)
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
        Me.Label3.Location = New System.Drawing.Point(147, 194)
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
        Me.Label1.Location = New System.Drawing.Point(102, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Broj kase:"
        '
        'napomena
        '
        Me.napomena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.napomena.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.napomena.Location = New System.Drawing.Point(179, 335)
        Me.napomena.Multiline = True
        Me.napomena.Name = "napomena"
        Me.napomena.Size = New System.Drawing.Size(349, 76)
        Me.napomena.TabIndex = 12
        '
        'simKartica
        '
        Me.simKartica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.simKartica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.simKartica.Location = New System.Drawing.Point(180, 192)
        Me.simKartica.Name = "simKartica"
        Me.simKartica.Size = New System.Drawing.Size(224, 21)
        Me.simKartica.TabIndex = 5
        '
        'brojTerminala
        '
        Me.brojTerminala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.brojTerminala.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brojTerminala.Location = New System.Drawing.Point(180, 120)
        Me.brojTerminala.Name = "brojTerminala"
        Me.brojTerminala.Size = New System.Drawing.Size(148, 21)
        Me.brojTerminala.TabIndex = 2
        '
        'brojModula
        '
        Me.brojModula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.brojModula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brojModula.Location = New System.Drawing.Point(180, 85)
        Me.brojModula.Name = "brojModula"
        Me.brojModula.Size = New System.Drawing.Size(148, 21)
        Me.brojModula.TabIndex = 1
        '
        'telefon
        '
        Me.telefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.telefon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefon.Location = New System.Drawing.Point(180, 156)
        Me.telefon.Name = "telefon"
        Me.telefon.Size = New System.Drawing.Size(148, 21)
        Me.telefon.TabIndex = 3
        '
        'pin
        '
        Me.pin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pin.Location = New System.Drawing.Point(462, 192)
        Me.pin.MaxLength = 4
        Me.pin.Name = "pin"
        Me.pin.Size = New System.Drawing.Size(66, 21)
        Me.pin.TabIndex = 6
        Me.pin.Text = "0"
        '
        'brojKase
        '
        Me.brojKase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.brojKase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brojKase.Location = New System.Drawing.Point(180, 39)
        Me.brojKase.Name = "brojKase"
        Me.brojKase.Size = New System.Drawing.Size(268, 26)
        Me.brojKase.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(101, 331)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Napomena:"
        '
        'adresaInstaliranja
        '
        Me.adresaInstaliranja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.adresaInstaliranja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adresaInstaliranja.Location = New System.Drawing.Point(180, 228)
        Me.adresaInstaliranja.Name = "adresaInstaliranja"
        Me.adresaInstaliranja.Size = New System.Drawing.Size(348, 21)
        Me.adresaInstaliranja.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 231)
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
        Me.Komitent.Location = New System.Drawing.Point(640, 31)
        Me.Komitent.Name = "Komitent"
        Me.Komitent.Size = New System.Drawing.Size(254, 58)
        Me.Komitent.TabIndex = 43
        Me.Komitent.TabStop = False
        Me.Komitent.Text = "Komitent"
        '
        'defiskalizacija
        '
        Me.defiskalizacija.AutoSize = True
        Me.defiskalizacija.Location = New System.Drawing.Point(639, 296)
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
        Me.Model.Location = New System.Drawing.Point(639, 115)
        Me.Model.Name = "Model"
        Me.Model.Size = New System.Drawing.Size(254, 58)
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
        Me.Label10.Location = New System.Drawing.Point(645, 205)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 15)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Datum fiskalizacije:"
        '
        'datumFiskalizacije
        '
        Me.datumFiskalizacije.CustomFormat = "dd/mm/yy"
        Me.datumFiskalizacije.Location = New System.Drawing.Point(766, 204)
        Me.datumFiskalizacije.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.datumFiskalizacije.MinDate = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.datumFiskalizacije.Name = "datumFiskalizacije"
        Me.datumFiskalizacije.Size = New System.Drawing.Size(127, 20)
        Me.datumFiskalizacije.TabIndex = 40
        '
        'datumDefiskalizacije
        '
        Me.datumDefiskalizacije.CustomFormat = "dd/mm/yy"
        Me.datumDefiskalizacije.Location = New System.Drawing.Point(765, 321)
        Me.datumDefiskalizacije.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.datumDefiskalizacije.MinDate = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.datumDefiskalizacije.Name = "datumDefiskalizacije"
        Me.datumDefiskalizacije.Size = New System.Drawing.Size(127, 20)
        Me.datumDefiskalizacije.TabIndex = 47
        Me.datumDefiskalizacije.Visible = False
        '
        'datumDefiskalizacijeLabel
        '
        Me.datumDefiskalizacijeLabel.AutoSize = True
        Me.datumDefiskalizacijeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datumDefiskalizacijeLabel.Location = New System.Drawing.Point(631, 324)
        Me.datumDefiskalizacijeLabel.Name = "datumDefiskalizacijeLabel"
        Me.datumDefiskalizacijeLabel.Size = New System.Drawing.Size(127, 15)
        Me.datumDefiskalizacijeLabel.TabIndex = 48
        Me.datumDefiskalizacijeLabel.Text = "Datum defiskalizacije:"
        Me.datumDefiskalizacijeLabel.Visible = False
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(94, 415)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(13, 13)
        Me.id.TabIndex = 49
        Me.id.Text = "0"
        Me.id.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(91, 267)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 15)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Prog. plomba:"
        '
        'programskaPlomba
        '
        Me.programskaPlomba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.programskaPlomba.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.programskaPlomba.Location = New System.Drawing.Point(180, 265)
        Me.programskaPlomba.Name = "programskaPlomba"
        Me.programskaPlomba.Size = New System.Drawing.Size(125, 21)
        Me.programskaPlomba.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(313, 267)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 15)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Fis. plomba:"
        '
        'fiskalnaPlomba
        '
        Me.fiskalnaPlomba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fiskalnaPlomba.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fiskalnaPlomba.Location = New System.Drawing.Point(391, 265)
        Me.fiskalnaPlomba.Name = "fiskalnaPlomba"
        Me.fiskalnaPlomba.Size = New System.Drawing.Size(137, 21)
        Me.fiskalnaPlomba.TabIndex = 9
        '
        'datumSlanjaLabel
        '
        Me.datumSlanjaLabel.AutoSize = True
        Me.datumSlanjaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datumSlanjaLabel.Location = New System.Drawing.Point(675, 266)
        Me.datumSlanjaLabel.Name = "datumSlanjaLabel"
        Me.datumSlanjaLabel.Size = New System.Drawing.Size(83, 15)
        Me.datumSlanjaLabel.TabIndex = 55
        Me.datumSlanjaLabel.Text = "Datum slanja:"
        '
        'datumSlanjaDokumentacije
        '
        Me.datumSlanjaDokumentacije.CustomFormat = "dd/mm/yy"
        Me.datumSlanjaDokumentacije.Location = New System.Drawing.Point(767, 265)
        Me.datumSlanjaDokumentacije.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.datumSlanjaDokumentacije.MinDate = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.datumSlanjaDokumentacije.Name = "datumSlanjaDokumentacije"
        Me.datumSlanjaDokumentacije.Size = New System.Drawing.Size(127, 20)
        Me.datumSlanjaDokumentacije.TabIndex = 54
        '
        'dokumentacijaPoslata
        '
        Me.dokumentacijaPoslata.AutoSize = True
        Me.dokumentacijaPoslata.Location = New System.Drawing.Point(639, 242)
        Me.dokumentacijaPoslata.Name = "dokumentacijaPoslata"
        Me.dokumentacijaPoslata.Size = New System.Drawing.Size(137, 17)
        Me.dokumentacijaPoslata.TabIndex = 56
        Me.dokumentacijaPoslata.Text = "Dokumentacija poslata:"
        Me.dokumentacijaPoslata.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(345, 159)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 15)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Ugovor:"
        '
        'brojUgovora
        '
        Me.brojUgovora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.brojUgovora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brojUgovora.Location = New System.Drawing.Point(400, 157)
        Me.brojUgovora.Name = "brojUgovora"
        Me.brojUgovora.Size = New System.Drawing.Size(128, 21)
        Me.brojUgovora.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(353, 302)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 15)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "IBSA:"
        '
        'ibsa
        '
        Me.ibsa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ibsa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ibsa.Location = New System.Drawing.Point(391, 300)
        Me.ibsa.Name = "ibsa"
        Me.ibsa.Size = New System.Drawing.Size(137, 21)
        Me.ibsa.TabIndex = 11
        '
        'fLink
        '
        Me.fLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fLink.Location = New System.Drawing.Point(180, 300)
        Me.fLink.Name = "fLink"
        Me.fLink.Size = New System.Drawing.Size(167, 21)
        Me.fLink.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(129, 302)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 15)
        Me.Label15.TabIndex = 61
        Me.Label15.Text = "F-Link:"
        '
        'KasaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(984, 462)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ibsa)
        Me.Controls.Add(Me.fLink)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.brojUgovora)
        Me.Controls.Add(Me.dokumentacijaPoslata)
        Me.Controls.Add(Me.datumSlanjaLabel)
        Me.Controls.Add(Me.datumSlanjaDokumentacije)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.fiskalnaPlomba)
        Me.Controls.Add(Me.programskaPlomba)
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
        Me.Controls.Add(Me.Label11)
        Me.KeyPreview = True
        Me.Name = "KasaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kasa"
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
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents programskaPlomba As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents fiskalnaPlomba As System.Windows.Forms.TextBox
    Friend WithEvents datumSlanjaLabel As System.Windows.Forms.Label
    Friend WithEvents datumSlanjaDokumentacije As System.Windows.Forms.DateTimePicker
    Friend WithEvents dokumentacijaPoslata As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents brojUgovora As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ibsa As System.Windows.Forms.TextBox
    Friend WithEvents fLink As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
