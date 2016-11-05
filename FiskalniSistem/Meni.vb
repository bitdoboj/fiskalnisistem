Public Class Meni

    Private Sub NoviKomitentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoviKomitentToolStripMenuItem.Click

        KomitentForm.Show()
    End Sub
    Private Sub NoviModelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoviModelToolStripMenuItem.Click
        modelForm.Show()
    End Sub
    Private Sub NovaKasaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovaKasaToolStripMenuItem.Click
        KasaForm.Show()
    End Sub

    Private Sub PregledKasaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PregledKasaToolStripMenuItem1.Click
        PregledKasaForm.Show()
    End Sub

    Private Sub ServisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServisToolStripMenuItem.Click
        kasaIdPretraga = 3
        ServisForm.Show()
    End Sub

    Private Sub KomitentiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KomitentiToolStripMenuItem.Click
        KomitentPregled.Show()
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

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Kase_Click(sender As Object, e As EventArgs) Handles Kase.Click
        PregledKasaForm.Show()
    End Sub

    Private Sub Komitenti_Click(sender As Object, e As EventArgs) Handles Komitenti.Click
        KomitentPregled.Show()
    End Sub
End Class