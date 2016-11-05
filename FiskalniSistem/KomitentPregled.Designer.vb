<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KomitentPregled
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KomitentPregled))
        Me.komitentiLista = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.izmjene = New System.Windows.Forms.Button()
        Me.Pregled = New System.Windows.Forms.Button()
        CType(Me.komitentiLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'komitentiLista
        '
        Me.komitentiLista.AllowUserToAddRows = False
        Me.komitentiLista.AllowUserToDeleteRows = False
        Me.komitentiLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.komitentiLista.Location = New System.Drawing.Point(11, 75)
        Me.komitentiLista.Name = "komitentiLista"
        Me.komitentiLista.ReadOnly = True
        Me.komitentiLista.Size = New System.Drawing.Size(961, 375)
        Me.komitentiLista.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Pretraga"
        '
        'searchBox
        '
        Me.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.searchBox.Location = New System.Drawing.Point(65, 49)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(184, 20)
        Me.searchBox.TabIndex = 3
        '
        'izmjene
        '
        Me.izmjene.Location = New System.Drawing.Point(897, 48)
        Me.izmjene.Name = "izmjene"
        Me.izmjene.Size = New System.Drawing.Size(75, 23)
        Me.izmjene.TabIndex = 6
        Me.izmjene.Text = "Izmjene"
        Me.izmjene.UseVisualStyleBackColor = True
        '
        'Pregled
        '
        Me.Pregled.Location = New System.Drawing.Point(816, 48)
        Me.Pregled.Name = "Pregled"
        Me.Pregled.Size = New System.Drawing.Size(75, 23)
        Me.Pregled.TabIndex = 7
        Me.Pregled.Text = "Pregled"
        Me.Pregled.UseVisualStyleBackColor = True
        '
        'KomitentiPregled
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 462)
        Me.Controls.Add(Me.Pregled)
        Me.Controls.Add(Me.izmjene)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.komitentiLista)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "KomitentiPregled"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KomitentiPregled"
        CType(Me.komitentiLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents komitentiLista As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents searchBox As System.Windows.Forms.TextBox
    Friend WithEvents izmjene As System.Windows.Forms.Button
    Friend WithEvents Pregled As System.Windows.Forms.Button
End Class
