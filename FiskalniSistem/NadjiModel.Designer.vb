<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NadjiModel
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
        Me.ModelGridView = New System.Windows.Forms.DataGridView()
        CType(Me.ModelGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ModelGridView
        '
        Me.ModelGridView.AllowUserToAddRows = False
        Me.ModelGridView.AllowUserToDeleteRows = False
        Me.ModelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ModelGridView.Location = New System.Drawing.Point(12, 12)
        Me.ModelGridView.Name = "ModelGridView"
        Me.ModelGridView.ReadOnly = True
        Me.ModelGridView.Size = New System.Drawing.Size(340, 163)
        Me.ModelGridView.TabIndex = 2
        '
        'NadjiModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 190)
        Me.Controls.Add(Me.ModelGridView)
        Me.Name = "NadjiModel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pretraga"
        CType(Me.ModelGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ModelGridView As System.Windows.Forms.DataGridView
End Class
