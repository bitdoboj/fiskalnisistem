﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Meni))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoviKomitentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NoviModelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KomitentiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KasaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovaKasaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PregledKasaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RadniNalogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoviRadniNalogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PregledToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Komitenti = New System.Windows.Forms.Button()
        Me.Kase = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radniNalog = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PregledNalogaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoviKomitentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PregledKasaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.KasaToolStripMenuItem1, Me.RadniNalogToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoviKomitentToolStripMenuItem, Me.ToolStripSeparator1, Me.NoviModelToolStripMenuItem, Me.ToolStripSeparator2, Me.SettingsToolStripMenuItem, Me.KomitentiToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NoviKomitentToolStripMenuItem
        '
        Me.NoviKomitentToolStripMenuItem.Image = CType(resources.GetObject("NoviKomitentToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NoviKomitentToolStripMenuItem.Name = "NoviKomitentToolStripMenuItem"
        Me.NoviKomitentToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Image = CType(resources.GetObject("SettingsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'KomitentiToolStripMenuItem
        '
        Me.KomitentiToolStripMenuItem.Name = "KomitentiToolStripMenuItem"
        Me.KomitentiToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.KomitentiToolStripMenuItem.Text = "Komitenti"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'KasaToolStripMenuItem1
        '
        Me.KasaToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovaKasaToolStripMenuItem, Me.PregledKasaToolStripMenuItem1})
        Me.KasaToolStripMenuItem1.Name = "KasaToolStripMenuItem1"
        Me.KasaToolStripMenuItem1.Size = New System.Drawing.Size(43, 20)
        Me.KasaToolStripMenuItem1.Text = "Kasa"
        '
        'NovaKasaToolStripMenuItem
        '
        Me.NovaKasaToolStripMenuItem.Image = CType(resources.GetObject("NovaKasaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NovaKasaToolStripMenuItem.Name = "NovaKasaToolStripMenuItem"
        Me.NovaKasaToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.NovaKasaToolStripMenuItem.Text = "Nova kasa"
        '
        'PregledKasaToolStripMenuItem1
        '
        Me.PregledKasaToolStripMenuItem1.Image = CType(resources.GetObject("PregledKasaToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.PregledKasaToolStripMenuItem1.Name = "PregledKasaToolStripMenuItem1"
        Me.PregledKasaToolStripMenuItem1.Size = New System.Drawing.Size(140, 22)
        Me.PregledKasaToolStripMenuItem1.Text = "Pregled kasa"
        '
        'RadniNalogToolStripMenuItem
        '
        Me.RadniNalogToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoviRadniNalogToolStripMenuItem, Me.PregledToolStripMenuItem})
        Me.RadniNalogToolStripMenuItem.Name = "RadniNalogToolStripMenuItem"
        Me.RadniNalogToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.RadniNalogToolStripMenuItem.Text = "Radni nalog"
        '
        'NoviRadniNalogToolStripMenuItem
        '
        Me.NoviRadniNalogToolStripMenuItem.Image = CType(resources.GetObject("NoviRadniNalogToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NoviRadniNalogToolStripMenuItem.Name = "NoviRadniNalogToolStripMenuItem"
        Me.NoviRadniNalogToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.NoviRadniNalogToolStripMenuItem.Text = "Novi radni nalog"
        '
        'PregledToolStripMenuItem
        '
        Me.PregledToolStripMenuItem.Name = "PregledToolStripMenuItem"
        Me.PregledToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.PregledToolStripMenuItem.Text = "Pregled"
        '
        'Komitenti
        '
        Me.Komitenti.BackgroundImage = Global.FiskalniSistem.My.Resources.Resources.folder_customer_icon
        Me.Komitenti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Komitenti.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Komitenti.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Komitenti.Location = New System.Drawing.Point(138, 36)
        Me.Komitenti.Name = "Komitenti"
        Me.Komitenti.Size = New System.Drawing.Size(110, 110)
        Me.Komitenti.TabIndex = 2
        Me.Komitenti.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Komitenti.UseVisualStyleBackColor = True
        '
        'Kase
        '
        Me.Kase.BackgroundImage = Global.FiskalniSistem.My.Resources.Resources.Cash_register_icon
        Me.Kase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Kase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Kase.Location = New System.Drawing.Point(12, 36)
        Me.Kase.Name = "Kase"
        Me.Kase.Size = New System.Drawing.Size(110, 110)
        Me.Kase.TabIndex = 1
        Me.Kase.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(592, 86)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(352, 299)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lao UI", 70.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lavender
        Me.Label1.Location = New System.Drawing.Point(3, 346)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(694, 125)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Fiskalni sistem"
        '
        'radniNalog
        '
        Me.radniNalog.BackgroundImage = CType(resources.GetObject("radniNalog.BackgroundImage"), System.Drawing.Image)
        Me.radniNalog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.radniNalog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radniNalog.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.radniNalog.Location = New System.Drawing.Point(266, 36)
        Me.radniNalog.Name = "radniNalog"
        Me.radniNalog.Size = New System.Drawing.Size(110, 110)
        Me.radniNalog.TabIndex = 5
        Me.radniNalog.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.radniNalog.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PregledNalogaToolStripMenuItem, Me.NoviKomitentToolStripMenuItem1, Me.PregledKasaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(154, 92)
        '
        'PregledNalogaToolStripMenuItem
        '
        Me.PregledNalogaToolStripMenuItem.Image = CType(resources.GetObject("PregledNalogaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PregledNalogaToolStripMenuItem.Name = "PregledNalogaToolStripMenuItem"
        Me.PregledNalogaToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.PregledNalogaToolStripMenuItem.Text = "Pregled naloga"
        '
        'NoviKomitentToolStripMenuItem1
        '
        Me.NoviKomitentToolStripMenuItem1.Image = CType(resources.GetObject("NoviKomitentToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.NoviKomitentToolStripMenuItem1.Name = "NoviKomitentToolStripMenuItem1"
        Me.NoviKomitentToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.NoviKomitentToolStripMenuItem1.Text = "Novi komitent"
        '
        'PregledKasaToolStripMenuItem
        '
        Me.PregledKasaToolStripMenuItem.Image = CType(resources.GetObject("PregledKasaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PregledKasaToolStripMenuItem.Name = "PregledKasaToolStripMenuItem"
        Me.PregledKasaToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.PregledKasaToolStripMenuItem.Text = "Pregled kasa"
        '
        'Meni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(984, 462)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.radniNalog)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Komitenti)
        Me.Controls.Add(Me.Kase)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Meni"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Meni"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoviKomitentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoviModelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KasaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovaKasaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PregledKasaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KomitentiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Kase As System.Windows.Forms.Button
    Friend WithEvents Komitenti As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadniNalogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoviRadniNalogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PregledToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents radniNalog As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PregledNalogaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoviKomitentToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PregledKasaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
