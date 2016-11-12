<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PregledKomitenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PregledKomitenta))
        Me.nazivKomitenta = New System.Windows.Forms.Label()
        Me.KasePregled = New System.Windows.Forms.DataGridView()
        Me.adresa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.jib = New System.Windows.Forms.TextBox()
        Me.brojUgovora = New System.Windows.Forms.TextBox()
        Me.telefon = New System.Windows.Forms.TextBox()
        Me.pib = New System.Windows.Forms.TextBox()
        Me.napomena = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.id = New System.Windows.Forms.Label()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Pregled = New System.Windows.Forms.Button()
        CType(Me.KasePregled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nazivKomitenta
        '
        Me.nazivKomitenta.AutoSize = True
        Me.nazivKomitenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nazivKomitenta.Location = New System.Drawing.Point(111, 33)
        Me.nazivKomitenta.Name = "nazivKomitenta"
        Me.nazivKomitenta.Size = New System.Drawing.Size(97, 25)
        Me.nazivKomitenta.TabIndex = 57
        Me.nazivKomitenta.Text = "Komitent"
        '
        'KasePregled
        '
        Me.KasePregled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KasePregled.Location = New System.Drawing.Point(12, 235)
        Me.KasePregled.Name = "KasePregled"
        Me.KasePregled.Size = New System.Drawing.Size(960, 212)
        Me.KasePregled.TabIndex = 59
        '
        'adresa
        '
        Me.adresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.adresa.Enabled = False
        Me.adresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adresa.ForeColor = System.Drawing.SystemColors.WindowText
        Me.adresa.Location = New System.Drawing.Point(115, 76)
        Me.adresa.Name = "adresa"
        Me.adresa.Size = New System.Drawing.Size(296, 23)
        Me.adresa.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Adresa:"
        '
        'jib
        '
        Me.jib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.jib.Enabled = False
        Me.jib.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jib.ForeColor = System.Drawing.SystemColors.WindowText
        Me.jib.Location = New System.Drawing.Point(293, 105)
        Me.jib.Name = "jib"
        Me.jib.Size = New System.Drawing.Size(118, 23)
        Me.jib.TabIndex = 62
        '
        'brojUgovora
        '
        Me.brojUgovora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.brojUgovora.Enabled = False
        Me.brojUgovora.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brojUgovora.ForeColor = System.Drawing.SystemColors.WindowText
        Me.brojUgovora.Location = New System.Drawing.Point(115, 134)
        Me.brojUgovora.Name = "brojUgovora"
        Me.brojUgovora.Size = New System.Drawing.Size(138, 23)
        Me.brojUgovora.TabIndex = 63
        '
        'telefon
        '
        Me.telefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.telefon.Enabled = False
        Me.telefon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefon.ForeColor = System.Drawing.SystemColors.WindowText
        Me.telefon.Location = New System.Drawing.Point(115, 105)
        Me.telefon.Name = "telefon"
        Me.telefon.Size = New System.Drawing.Size(138, 23)
        Me.telefon.TabIndex = 64
        '
        'pib
        '
        Me.pib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pib.Enabled = False
        Me.pib.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pib.ForeColor = System.Drawing.SystemColors.WindowText
        Me.pib.Location = New System.Drawing.Point(293, 134)
        Me.pib.Name = "pib"
        Me.pib.Size = New System.Drawing.Size(118, 23)
        Me.pib.TabIndex = 65
        '
        'napomena
        '
        Me.napomena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.napomena.Enabled = False
        Me.napomena.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.napomena.ForeColor = System.Drawing.SystemColors.WindowText
        Me.napomena.Location = New System.Drawing.Point(481, 76)
        Me.napomena.Multiline = True
        Me.napomena.Name = "napomena"
        Me.napomena.Size = New System.Drawing.Size(252, 81)
        Me.napomena.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Telefon:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Broj ugovora:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(266, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "JIB:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(264, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "PIB:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(416, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Napomena:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Location = New System.Drawing.Point(115, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(620, 1)
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(696, 39)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(39, 13)
        Me.id.TabIndex = 72
        Me.id.Text = "Label7"
        Me.id.Visible = False
        '
        'Edit
        '
        Me.Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit.Image = CType(resources.GetObject("Edit.Image"), System.Drawing.Image)
        Me.Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Edit.Location = New System.Drawing.Point(841, 176)
        Me.Edit.Name = "Edit"
        Me.Edit.Padding = New System.Windows.Forms.Padding(10)
        Me.Edit.Size = New System.Drawing.Size(131, 53)
        Me.Edit.TabIndex = 73
        Me.Edit.Text = "Edit"
        Me.Edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Edit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(704, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(6)
        Me.Button1.Size = New System.Drawing.Size(131, 53)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "Nova kasa"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Pregled
        '
        Me.Pregled.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pregled.Image = CType(resources.GetObject("Pregled.Image"), System.Drawing.Image)
        Me.Pregled.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Pregled.Location = New System.Drawing.Point(567, 176)
        Me.Pregled.Name = "Pregled"
        Me.Pregled.Padding = New System.Windows.Forms.Padding(10)
        Me.Pregled.Size = New System.Drawing.Size(131, 53)
        Me.Pregled.TabIndex = 75
        Me.Pregled.Text = "Pregled"
        Me.Pregled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Pregled.UseVisualStyleBackColor = True
        '
        'PregledKomitenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(984, 462)
        Me.Controls.Add(Me.Pregled)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.napomena)
        Me.Controls.Add(Me.pib)
        Me.Controls.Add(Me.telefon)
        Me.Controls.Add(Me.brojUgovora)
        Me.Controls.Add(Me.jib)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.adresa)
        Me.Controls.Add(Me.KasePregled)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.nazivKomitenta)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "PregledKomitenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pregled komitenta"
        CType(Me.KasePregled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents nazivKomitenta As System.Windows.Forms.Label
    Friend WithEvents KasePregled As System.Windows.Forms.DataGridView
    Friend WithEvents adresa As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents jib As System.Windows.Forms.TextBox
    Friend WithEvents brojUgovora As System.Windows.Forms.TextBox
    Friend WithEvents telefon As System.Windows.Forms.TextBox
    Friend WithEvents pib As System.Windows.Forms.TextBox
    Friend WithEvents napomena As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.Label
    Friend WithEvents Edit As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Pregled As System.Windows.Forms.Button
End Class
