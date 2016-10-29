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
        Me.servisiLista = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.datumServisa = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.opis = New System.Windows.Forms.TextBox()
        Me.Snimi = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.Label()
        Me.kasaId = New System.Windows.Forms.Label()
        Me.brojKase = New System.Windows.Forms.Label()
        Me.nazivKomitenta = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.servisiLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'servisiLista
        '
        Me.servisiLista.AllowUserToAddRows = False
        Me.servisiLista.AllowUserToDeleteRows = False
        Me.servisiLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.servisiLista.Location = New System.Drawing.Point(12, 153)
        Me.servisiLista.Name = "servisiLista"
        Me.servisiLista.ReadOnly = True
        Me.servisiLista.Size = New System.Drawing.Size(773, 242)
        Me.servisiLista.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 15)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Datum servisa:"
        '
        'datumServisa
        '
        Me.datumServisa.CustomFormat = "dd/mm/yy"
        Me.datumServisa.Location = New System.Drawing.Point(108, 121)
        Me.datumServisa.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.datumServisa.MinDate = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.datumServisa.Name = "datumServisa"
        Me.datumServisa.Size = New System.Drawing.Size(147, 20)
        Me.datumServisa.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(267, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 15)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Opis:"
        '
        'opis
        '
        Me.opis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.opis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opis.Location = New System.Drawing.Point(307, 122)
        Me.opis.Name = "opis"
        Me.opis.Size = New System.Drawing.Size(435, 21)
        Me.opis.TabIndex = 50
        '
        'Snimi
        '
        Me.Snimi.Location = New System.Drawing.Point(744, 121)
        Me.Snimi.Name = "Snimi"
        Me.Snimi.Size = New System.Drawing.Size(41, 23)
        Me.Snimi.TabIndex = 51
        Me.Snimi.Text = "Snimi"
        Me.Snimi.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(16, 108)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(13, 13)
        Me.id.TabIndex = 52
        Me.id.Text = "0"
        Me.id.Visible = False
        '
        'kasaId
        '
        Me.kasaId.AutoSize = True
        Me.kasaId.Location = New System.Drawing.Point(47, 41)
        Me.kasaId.Name = "kasaId"
        Me.kasaId.Size = New System.Drawing.Size(13, 13)
        Me.kasaId.TabIndex = 53
        Me.kasaId.Text = "0"
        Me.kasaId.Visible = False
        '
        'brojKase
        '
        Me.brojKase.AutoSize = True
        Me.brojKase.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brojKase.Location = New System.Drawing.Point(62, 34)
        Me.brojKase.Name = "brojKase"
        Me.brojKase.Size = New System.Drawing.Size(62, 25)
        Me.brojKase.TabIndex = 54
        Me.brojKase.Text = "Kasa"
        '
        'nazivKomitenta
        '
        Me.nazivKomitenta.AutoSize = True
        Me.nazivKomitenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nazivKomitenta.Location = New System.Drawing.Point(307, 34)
        Me.nazivKomitenta.Name = "nazivKomitenta"
        Me.nazivKomitenta.Size = New System.Drawing.Size(97, 25)
        Me.nazivKomitenta.TabIndex = 55
        Me.nazivKomitenta.Text = "Komitent"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Location = New System.Drawing.Point(-7, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(813, 1)
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(311, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Komitent"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Broj kase"
        '
        'ServisForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 433)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.nazivKomitenta)
        Me.Controls.Add(Me.brojKase)
        Me.Controls.Add(Me.kasaId)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Snimi)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.opis)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.datumServisa)
        Me.Controls.Add(Me.servisiLista)
        Me.Name = "ServisForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Servis"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.servisiLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents nazivKomitenta As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
