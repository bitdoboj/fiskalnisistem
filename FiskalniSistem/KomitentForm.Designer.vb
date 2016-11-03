<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KomitentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KomitentForm))
        Me.nazivKomitenta = New System.Windows.Forms.TextBox()
        Me.pib = New System.Windows.Forms.TextBox()
        Me.brojUgovora = New System.Windows.Forms.TextBox()
        Me.adresa = New System.Windows.Forms.TextBox()
        Me.Telefon = New System.Windows.Forms.TextBox()
        Me.jib = New System.Windows.Forms.TextBox()
        Me.napomena = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Snimi = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'nazivKomitenta
        '
        Me.nazivKomitenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nazivKomitenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nazivKomitenta.Location = New System.Drawing.Point(138, 48)
        Me.nazivKomitenta.Name = "nazivKomitenta"
        Me.nazivKomitenta.Size = New System.Drawing.Size(377, 26)
        Me.nazivKomitenta.TabIndex = 0
        '
        'pib
        '
        Me.pib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pib.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pib.Location = New System.Drawing.Point(138, 250)
        Me.pib.Name = "pib"
        Me.pib.Size = New System.Drawing.Size(377, 21)
        Me.pib.TabIndex = 4
        '
        'brojUgovora
        '
        Me.brojUgovora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.brojUgovora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brojUgovora.Location = New System.Drawing.Point(138, 290)
        Me.brojUgovora.Name = "brojUgovora"
        Me.brojUgovora.Size = New System.Drawing.Size(377, 21)
        Me.brojUgovora.TabIndex = 5
        '
        'adresa
        '
        Me.adresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.adresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adresa.Location = New System.Drawing.Point(138, 130)
        Me.adresa.Name = "adresa"
        Me.adresa.Size = New System.Drawing.Size(377, 21)
        Me.adresa.TabIndex = 1
        '
        'Telefon
        '
        Me.Telefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Telefon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telefon.Location = New System.Drawing.Point(138, 170)
        Me.Telefon.Name = "Telefon"
        Me.Telefon.Size = New System.Drawing.Size(377, 21)
        Me.Telefon.TabIndex = 2
        '
        'jib
        '
        Me.jib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.jib.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jib.Location = New System.Drawing.Point(138, 210)
        Me.jib.Name = "jib"
        Me.jib.Size = New System.Drawing.Size(377, 21)
        Me.jib.TabIndex = 3
        '
        'napomena
        '
        Me.napomena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.napomena.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.napomena.Location = New System.Drawing.Point(138, 330)
        Me.napomena.Multiline = True
        Me.napomena.Name = "napomena"
        Me.napomena.Size = New System.Drawing.Size(377, 79)
        Me.napomena.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(105, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "JIB:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(81, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Telefon:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(84, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Adresa:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(53, 292)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Broj ugovora:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Napomena:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(103, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 15)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "PIB:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Snimi
        '
        Me.Snimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Snimi.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Snimi.Location = New System.Drawing.Point(685, 368)
        Me.Snimi.Name = "Snimi"
        Me.Snimi.Size = New System.Drawing.Size(158, 42)
        Me.Snimi.TabIndex = 7
        Me.Snimi.Text = "Snimi"
        Me.Snimi.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(15, 300)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(15, 13)
        Me.id.TabIndex = 17
        Me.id.Text = "id"
        Me.id.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(315, 385)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.FiskalniSistem.My.Resources.Resources.folder_customer_icon
        Me.PictureBox1.Location = New System.Drawing.Point(637, 94)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 256)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.id)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(499, 326)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opsti podaci"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(135, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Naziv komitenta:"
        '
        'KomitentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 462)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Snimi)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.napomena)
        Me.Controls.Add(Me.jib)
        Me.Controls.Add(Me.Telefon)
        Me.Controls.Add(Me.adresa)
        Me.Controls.Add(Me.brojUgovora)
        Me.Controls.Add(Me.pib)
        Me.Controls.Add(Me.nazivKomitenta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "KomitentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Novi komitent"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nazivKomitenta As System.Windows.Forms.TextBox
    Friend WithEvents pib As System.Windows.Forms.TextBox
    Friend WithEvents brojUgovora As System.Windows.Forms.TextBox
    Friend WithEvents adresa As System.Windows.Forms.TextBox
    Friend WithEvents Telefon As System.Windows.Forms.TextBox
    Friend WithEvents jib As System.Windows.Forms.TextBox
    Friend WithEvents napomena As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Snimi As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
