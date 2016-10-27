<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Meni
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoviKomitentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NoviModelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KasaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovaKasaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PregledKasaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.KasaToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(797, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoviKomitentToolStripMenuItem, Me.ToolStripSeparator1, Me.NoviModelToolStripMenuItem, Me.ToolStripSeparator2, Me.TestToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NoviKomitentToolStripMenuItem
        '
        Me.NoviKomitentToolStripMenuItem.Name = "NoviKomitentToolStripMenuItem"
        Me.NoviKomitentToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.NoviKomitentToolStripMenuItem.Text = "Novi komitent"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(147, 6)
        '
        'NoviModelToolStripMenuItem
        '
        Me.NoviModelToolStripMenuItem.Name = "NoviModelToolStripMenuItem"
        Me.NoviModelToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.NoviModelToolStripMenuItem.Text = "Modeli"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(147, 6)
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.TestToolStripMenuItem.Text = "Test"
        '
        'KasaToolStripMenuItem1
        '
        Me.KasaToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovaKasaToolStripMenuItem, Me.PregledKasaToolStripMenuItem1, Me.ServisToolStripMenuItem})
        Me.KasaToolStripMenuItem1.Name = "KasaToolStripMenuItem1"
        Me.KasaToolStripMenuItem1.Size = New System.Drawing.Size(43, 20)
        Me.KasaToolStripMenuItem1.Text = "Kasa"
        '
        'NovaKasaToolStripMenuItem
        '
        Me.NovaKasaToolStripMenuItem.Name = "NovaKasaToolStripMenuItem"
        Me.NovaKasaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NovaKasaToolStripMenuItem.Text = "Nova kasa"
        '
        'PregledKasaToolStripMenuItem1
        '
        Me.PregledKasaToolStripMenuItem1.Name = "PregledKasaToolStripMenuItem1"
        Me.PregledKasaToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.PregledKasaToolStripMenuItem1.Text = "Pregled kasa"
        '
        'ServisToolStripMenuItem
        '
        Me.ServisToolStripMenuItem.Name = "ServisToolStripMenuItem"
        Me.ServisToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ServisToolStripMenuItem.Text = "Servis"
        '
        'Meni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 433)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Meni"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Meni"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoviKomitentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoviModelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KasaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovaKasaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PregledKasaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
