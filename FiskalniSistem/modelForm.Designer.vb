<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modelForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modelForm))
        Me.nazivModela = New System.Windows.Forms.TextBox()
        Me.opis = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Snimi = New System.Windows.Forms.Button()
        Me.ModeliDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Add = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.Label()
        CType(Me.ModeliDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'nazivModela
        '
        Me.nazivModela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nazivModela.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nazivModela.Location = New System.Drawing.Point(13, 51)
        Me.nazivModela.Name = "nazivModela"
        Me.nazivModela.Size = New System.Drawing.Size(269, 21)
        Me.nazivModela.TabIndex = 0
        '
        'opis
        '
        Me.opis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.opis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opis.Location = New System.Drawing.Point(13, 106)
        Me.opis.Multiline = True
        Me.opis.Name = "opis"
        Me.opis.Size = New System.Drawing.Size(269, 91)
        Me.opis.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Naziv modela"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Opis"
        '
        'Snimi
        '
        Me.Snimi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Snimi.Image = CType(resources.GetObject("Snimi.Image"), System.Drawing.Image)
        Me.Snimi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Snimi.Location = New System.Drawing.Point(151, 219)
        Me.Snimi.Name = "Snimi"
        Me.Snimi.Padding = New System.Windows.Forms.Padding(10)
        Me.Snimi.Size = New System.Drawing.Size(131, 53)
        Me.Snimi.TabIndex = 8
        Me.Snimi.Text = "Snimi"
        Me.Snimi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Snimi.UseVisualStyleBackColor = True
        '
        'ModeliDataGridView
        '
        Me.ModeliDataGridView.AllowUserToAddRows = False
        Me.ModeliDataGridView.AllowUserToDeleteRows = False
        Me.ModeliDataGridView.AllowUserToOrderColumns = True
        Me.ModeliDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ModeliDataGridView.Location = New System.Drawing.Point(345, 54)
        Me.ModeliDataGridView.Name = "ModeliDataGridView"
        Me.ModeliDataGridView.ReadOnly = True
        Me.ModeliDataGridView.Size = New System.Drawing.Size(503, 279)
        Me.ModeliDataGridView.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(342, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Lista svih modela fiskalnih kasa"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Add)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Snimi)
        Me.GroupBox1.Controls.Add(Me.nazivModela)
        Me.GroupBox1.Controls.Add(Me.opis)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 289)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opsti podaci"
        '
        'Add
        '
        Me.Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add.Image = CType(resources.GetObject("Add.Image"), System.Drawing.Image)
        Me.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Add.Location = New System.Drawing.Point(13, 219)
        Me.Add.Name = "Add"
        Me.Add.Padding = New System.Windows.Forms.Padding(6)
        Me.Add.Size = New System.Drawing.Size(131, 53)
        Me.Add.TabIndex = 9
        Me.Add.Text = "Novi model"
        Me.Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Add.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(285, 336)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(0, 13)
        Me.id.TabIndex = 22
        Me.id.Visible = False
        '
        'modelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(882, 365)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ModeliDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "modelForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Model"
        CType(Me.ModeliDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nazivModela As System.Windows.Forms.TextBox
    Friend WithEvents opis As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Snimi As System.Windows.Forms.Button
    Friend WithEvents ModeliDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.Label
End Class
