

Public Class KasaForm
    Private Sub Komitent_MouseClick(sender As Object, e As MouseEventArgs) Handles Komitent.MouseClick
        NadjiKomitenta.Show()
    End Sub

    Private Sub Model_MouseClick(sender As Object, e As MouseEventArgs) Handles Model.MouseClick
        NadjiModel.Show()
    End Sub

    Private Sub KasaForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        komitentIdPretraga = 0
        kasaIdPretraga = 0
    End Sub

    Private Sub KasaForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub KasaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If komitentIdPretraga <> 0 Then
            Me.komitentid.Text = komitentIdPretraga
            Me.nazivKomitenta.Text = getNazivKomitenta(komitentIdPretraga)
        End If

        If kasaIdPretraga <> 0 Then

            Dim kasa As Kasa = getKasa(kasaIdPretraga)

            Me.id.Text = kasa.id
            Me.brojKase.Text = kasa.brojKase
            Me.komitentid.Text = kasa.komitentId
            Me.nazivKomitenta.Text = getNazivKomitenta(kasa.komitentId)
            Me.brojModula.Text = kasa.brojModula
            Me.brojTerminala.Text = kasa.brojTerminala
            Me.simKartica.Text = kasa.simKartica
            Me.pin.Text = kasa.pin
            Me.telefon.Text = kasa.telefon
            Me.adresaInstaliranja.Text = kasa.adresaInstaliranja
            Me.modelId.Text = kasa.modelId
            Me.nazivModela.Text = getNazivModela(kasa.modelId)
            Me.defiskalizacija.CheckState = If(kasa.defiskalizacija = -1, 1, 0)
            Me.datumDefiskalizacije.Text = kasa.datumDefiskalizacije
            Me.datumFiskalizacije.Text = kasa.datumFiskalizacije
            Me.brojUgovora.Text = kasa.brojUgovora
            Me.fLink.Text = kasa.fLink
            Me.ibsa.Text = kasa.ibsa
            Me.napomena.Text = kasa.napomena
        End If
        dokumentacijaPoslataCheck()
        defiskalizacijaCheck()
    End Sub
    Private Sub defiskalizacijaCheck()

        If Me.defiskalizacija.Checked Then
            datumDefiskalizacije.Visible = True
            datumDefiskalizacijeLabel.Visible = True
        Else
            datumDefiskalizacije.Visible = False
            datumDefiskalizacijeLabel.Visible = False
        End If
    End Sub
    Private Sub dokumentacijaPoslataCheck()
        If Me.dokumentacijaPoslata.Checked Then
            datumSlanjaLabel.Visible = True
            datumSlanjaDokumentacije.Visible = True
        Else
            datumSlanjaLabel.Visible = False
            datumSlanjaDokumentacije.Visible = False
        End If
    End Sub

    Private Sub defiskalizacija_CheckedChanged(sender As Object, e As EventArgs) Handles defiskalizacija.CheckedChanged
        defiskalizacijaCheck()
    End Sub

    Private Sub Snimi_Click(sender As Object, e As EventArgs) Handles Snimi.Click

        addKasa()

    End Sub
    Private Sub addKasa()

        If Me.komitentid.Text = "0" Then
            MsgBox("Morate izabrati komitenta", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If Me.modelId.Text = "0" Then
            MsgBox("Morate izabrati model kase", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If Me.brojKase.Text = "" Then
            MsgBox("Morate upisati broj kase", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        Dim kasa As New Kasa

        kasa.id = Me.id.Text
        kasa.brojKase = Me.brojKase.Text
        kasa.komitentId = Me.komitentid.Text
        kasa.brojModula = Me.brojModula.Text
        kasa.brojTerminala = Me.brojTerminala.Text
        kasa.simKartica = Me.simKartica.Text
        kasa.pin = Me.pin.Text
        kasa.telefon = Me.telefon.Text
        kasa.adresaInstaliranja = Me.adresaInstaliranja.Text
        kasa.modelId = Me.modelId.Text

        kasa.defiskalizacija = Me.defiskalizacija.CheckState
        If Me.defiskalizacija.CheckState = 1 Then
            kasa.datumDefiskalizacije = FormatDateTime(Me.datumDefiskalizacije.Value, DateFormat.ShortDate)
        Else
            kasa.datumDefiskalizacije = ""
        End If

        kasa.dokumentacijaPoslata = Me.dokumentacijaPoslata.CheckState
        If dokumentacijaPoslata.CheckState = 1 Then
            kasa.datumSlanjaDokumentacije = FormatDateTime(Me.datumSlanjaDokumentacije.Value, DateFormat.ShortDate)
        Else
            kasa.datumSlanjaDokumentacije = ""
        End If

        kasa.fiskalnaPlomba = Me.fiskalnaPlomba.Text
        kasa.programskaPlomba = Me.programskaPlomba.Text
        kasa.datumFiskalizacije = FormatDateTime(Me.datumFiskalizacije.Value, DateFormat.ShortDate)
        kasa.brojUgovora = Me.brojUgovora.Text
        kasa.fLink = Me.fLink.Text
        kasa.ibsa = Me.ibsa.Text
        kasa.napomena = Me.napomena.Text

        saveKasa(kasa)
        If (Me.komitentid.Text <> 0) Then
            komitentIdPretraga = Me.komitentid.Text
            PregledKomitenta.Show()
            Close()
        End If
        clearKasaForm()
    End Sub
    Private Sub clearKasaForm()

        Me.brojKase.Text = ""
        Me.komitentid.Text = ""
        Me.nazivKomitenta.Text = "Komitent"
        Me.brojModula.Text = ""
        Me.brojTerminala.Text = ""
        Me.simKartica.Text = ""
        Me.pin.Text = "0"
        Me.telefon.Text = ""
        Me.adresaInstaliranja.Text = ""
        Me.modelId.Text = ""
        Me.nazivModela.Text = "Model"
        Me.defiskalizacija.CheckState = False
        Me.brojUgovora.Text = ""
        Me.fLink.Text = ""
        Me.ibsa.Text = ""
        Me.napomena.Text = ""
    End Sub

    Private Sub dokumentacijaPoslata_CheckedChanged(sender As Object, e As EventArgs) Handles dokumentacijaPoslata.CheckedChanged
        dokumentacijaPoslataCheck()
    End Sub
End Class