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
        Me.Pregled = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        CType(Me.komitentiLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'komitentiLista
        '
        Me.komitentiLista.AllowUserToAddRows = False
        Me.komitentiLista.AllowUserToDeleteRows = False
        Me.komitentiLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.komitentiLista.Location = New System.Drawing.Point(11, 91)
        Me.komitentiLista.Name = "komitentiLista"
        Me.komitentiLista.ReadOnly = True
        Me.komitentiLista.Size = New System.Drawing.Size(961, 359)
        Me.komitentiLista.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Pretraga"
        '
        'searchBox
        '
        Me.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.searchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBox.Location = New System.Drawing.Point(71, 56)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(184, 29)
        Me.searchBox.TabIndex = 3
        '
        'Pregled
        '
        Me.Pregled.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pregled.Image = CType(resources.GetObject("Pregled.Image"), System.Drawing.Image)
        Me.Pregled.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Pregled.Location = New System.Drawing.Point(704, 32)
        Me.Pregled.Name = "Pregled"
        Me.Pregled.Padding = New System.Windows.Forms.Padding(10)
        Me.Pregled.Size = New System.Drawing.Size(131, 53)
        Me.Pregled.TabIndex = 7
        Me.Pregled.Text = "Pregled"
        Me.Pregled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Pregled.UseVisualStyleBackColor = True
        '
        'Edit
        '
        Me.Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit.Image = CType(resources.GetObject("Edit.Image"), System.Drawing.Image)
        Me.Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Edit.Location = New System.Drawing.Point(841, 32)
        Me.Edit.Name = "Edit"
        Me.Edit.Padding = New System.Windows.Forms.Padding(10)
        Me.Edit.Size = New System.Drawing.Size(131, 53)
        Me.Edit.TabIndex = 74
        Me.Edit.Text = "Edit"
        Me.Edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Edit.UseVisualStyleBackColor = True
        '
        'KomitentPregled
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(984, 462)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.Pregled)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.komitentiLista)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "KomitentPregled"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pregled komitenata"
        CType(Me.komitentiLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents komitentiLista As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents searchBox As System.Windows.Forms.TextBox
    Friend WithEvents Pregled As System.Windows.Forms.Button
    Friend WithEvents Edit As System.Windows.Forms.Button
End Class
