<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadniNalogForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RadniNalogForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Komitent = New System.Windows.Forms.GroupBox()
        Me.komitentid = New System.Windows.Forms.Label()
        Me.nazivKomitenta = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.datumRn = New System.Windows.Forms.DateTimePicker()
        Me.mjestoRada = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.serviser = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.opisKvara = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dijagnostika = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.izvrseniRadovi = New System.Windows.Forms.TextBox()
        Me.Snimi = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Komitent.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(691, 91)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 256)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Komitent
        '
        Me.Komitent.Controls.Add(Me.komitentid)
        Me.Komitent.Controls.Add(Me.nazivKomitenta)
        Me.Komitent.Location = New System.Drawing.Point(65, 62)
        Me.Komitent.Name = "Komitent"
        Me.Komitent.Size = New System.Drawing.Size(254, 58)
        Me.Komitent.TabIndex = 44
        Me.Komitent.TabStop = False
        Me.Komitent.Text = "Komitent"
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(62, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 15)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Datum Radnog naloga:"
        '
        'datumRn
        '
        Me.datumRn.CustomFormat = "dd/mm/yy"
        Me.datumRn.Location = New System.Drawing.Point(62, 167)
        Me.datumRn.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.datumRn.MinDate = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.datumRn.Name = "datumRn"
        Me.datumRn.Size = New System.Drawing.Size(257, 20)
        Me.datumRn.TabIndex = 47
        '
        'mjestoRada
        '
        Me.mjestoRada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.mjestoRada.FormattingEnabled = True
        Me.mjestoRada.Items.AddRange(New Object() {"U servisu", "Na terenu"})
        Me.mjestoRada.Location = New System.Drawing.Point(62, 224)
        Me.mjestoRada.Name = "mjestoRada"
        Me.mjestoRada.Size = New System.Drawing.Size(257, 23)
        Me.mjestoRada.TabIndex = 49
        Me.mjestoRada.Text = "U servisu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Mjesto rada:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 15)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Serviser:"
        '
        'serviser
        '
        Me.serviser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.serviser.FormattingEnabled = True
        Me.serviser.Items.AddRange(New Object() {"Sanjin", "Dragan", "Sanjin/Dragan"})
        Me.serviser.Location = New System.Drawing.Point(62, 282)
        Me.serviser.Name = "serviser"
        Me.serviser.Size = New System.Drawing.Size(257, 23)
        Me.serviser.TabIndex = 51
        Me.serviser.Text = "Sanjin"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(339, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 15)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Opis kvara:"
        '
        'opisKvara
        '
        Me.opisKvara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.opisKvara.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opisKvara.Location = New System.Drawing.Point(342, 81)
        Me.opisKvara.Multiline = True
        Me.opisKvara.Name = "opisKvara"
        Me.opisKvara.Size = New System.Drawing.Size(314, 99)
        Me.opisKvara.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(339, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Dijagnostika:"
        '
        'dijagnostika
        '
        Me.dijagnostika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dijagnostika.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dijagnostika.Location = New System.Drawing.Point(342, 210)
        Me.dijagnostika.Multiline = True
        Me.dijagnostika.Name = "dijagnostika"
        Me.dijagnostika.Size = New System.Drawing.Size(314, 99)
        Me.dijagnostika.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(339, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 15)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Izvršeni radovi:"
        '
        'izvrseniRadovi
        '
        Me.izvrseniRadovi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.izvrseniRadovi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.izvrseniRadovi.Location = New System.Drawing.Point(342, 339)
        Me.izvrseniRadovi.Multiline = True
        Me.izvrseniRadovi.Name = "izvrseniRadovi"
        Me.izvrseniRadovi.Size = New System.Drawing.Size(314, 99)
        Me.izvrseniRadovi.TabIndex = 57
        '
        'Snimi
        '
        Me.Snimi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Snimi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Snimi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Snimi.Image = CType(resources.GetObject("Snimi.Image"), System.Drawing.Image)
        Me.Snimi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Snimi.Location = New System.Drawing.Point(816, 385)
        Me.Snimi.Name = "Snimi"
        Me.Snimi.Padding = New System.Windows.Forms.Padding(10)
        Me.Snimi.Size = New System.Drawing.Size(131, 53)
        Me.Snimi.TabIndex = 59
        Me.Snimi.Text = "Snimi"
        Me.Snimi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Snimi.UseVisualStyleBackColor = True
        '
        'RadniNalogForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.Snimi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.izvrseniRadovi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dijagnostika)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.opisKvara)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.serviser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mjestoRada)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.datumRn)
        Me.Controls.Add(Me.Komitent)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "RadniNalogForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Radni nalog"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Komitent.ResumeLayout(False)
        Me.Komitent.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Komitent As System.Windows.Forms.GroupBox
    Friend WithEvents komitentid As System.Windows.Forms.Label
    Friend WithEvents nazivKomitenta As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents datumRn As System.Windows.Forms.DateTimePicker
    Friend WithEvents mjestoRada As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents serviser As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents opisKvara As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dijagnostika As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents izvrseniRadovi As System.Windows.Forms.TextBox
    Friend WithEvents Snimi As System.Windows.Forms.Button
End Class
