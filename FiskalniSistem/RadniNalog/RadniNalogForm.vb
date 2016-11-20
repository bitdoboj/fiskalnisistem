Public Class RadniNalogForm

    Private Sub Komitent_Click(sender As Object, e As EventArgs) Handles Komitent.Click
        NadjiKomitenta.Show()
    End Sub


    Private Sub Snimi_Click(sender As Object, e As EventArgs) Handles Snimi.Click

        If Me.komitentid.Text = 0 Then
            MsgBox("Morate da izaberete komitenta", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Greška")
            Exit Sub
        End If
        Dim radniNalog As New RadniNalog
        radniNalog.komitentId = Me.komitentid.Text
        radniNalog.brojRn = getBrojRadnogNaloga()
        radniNalog.datumRn = Me.datumRn.Text
        radniNalog.mjestoRada = Me.mjestoRada.Text
        radniNalog.Serviser = Me.serviser.Text
        radniNalog.opisKvara = Me.opisKvara.Text
        radniNalog.dijagnostika = Me.dijagnostika.Text
        radniNalog.izvrseniRadovi = Me.izvrseniRadovi.Text

        saveRadniNalog(radniNalog)
        clearForm()
        RadniNalogLista.Show()
        Close()
    End Sub
    Private Sub clearForm()

        Me.komitentid.Text = 0
        Me.nazivKomitenta.Text = "Komitent"
        Me.datumRn.Text = Date.Today
        Me.mjestoRada.Text = ""
        Me.serviser.Text = ""
        Me.opisKvara.Text = ""
        Me.dijagnostika.Text = ""
        Me.izvrseniRadovi.Text = ""
    End Sub

    Private Sub RadniNalogForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        RadniNalogLista.Show()
    End Sub

    Private Sub RadniNalogForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub RadniNalogForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class