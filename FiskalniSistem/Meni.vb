Public Class Meni

    Private Sub NoviKomitentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoviKomitentToolStripMenuItem.Click

        KomitentForm.Show()
        'KomitentForm.MdiParent = Me
    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click
        komitentIdPretraga = 5
        KomitentForm.Show()
        KomitentForm.MdiParent = Me
    End Sub

    Private Sub NoviModelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoviModelToolStripMenuItem.Click
        modelForm.Show()
        modelForm.MdiParent = Me
    End Sub

    Private Sub KasaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    

    Private Sub NovaKasaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovaKasaToolStripMenuItem.Click
        KasaForm.Show()
        KasaForm.MdiParent = Me
    End Sub

    Private Sub PregledKasaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PregledKasaToolStripMenuItem1.Click
        PregledKasaForm.Show()
        PregledKasaForm.MdiParent = Me
    End Sub

    Private Sub ServisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServisToolStripMenuItem.Click
        kasaIdPretraga = 3
        ServisForm.Show()
        ServisForm.MdiParent = Me
    End Sub

    Private Sub KomitentiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KomitentiToolStripMenuItem.Click
        KomitentiPregled.Show()
        KomitentiPregled.MdiParent = Me
    End Sub

    Private Sub Meni_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F3 Then
            ServisForm.Show()
        End If
    End Sub

    Private Sub Meni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        SettingsForm.Show()
    End Sub
End Class