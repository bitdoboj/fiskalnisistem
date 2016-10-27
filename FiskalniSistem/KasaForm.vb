

Public Class KasaForm
    Private Sub Komitent_MouseClick(sender As Object, e As MouseEventArgs) Handles Komitent.MouseClick
        NadjiKomitenta.Show()
    End Sub

    Private Sub Model_MouseClick(sender As Object, e As MouseEventArgs) Handles Model.MouseClick
        NadjiModel.Show()
    End Sub

    Private Sub KasaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            Me.defiskalizacija.CheckState = If(kasa.defiskalicacija = -1, 1, 0)
            Me.datumDefiskalizacije.Text = kasa.datumDefiskalizacije
            Me.datumFiskalizacije.Text = kasa.datumFiskalizacije
            Me.napomena.Text = kasa.napomena
        End If

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
        If Me.defiskalizacija.CheckState = 1 Then
            kasa.datumDefiskalizacije = FormatDateTime(Me.datumDefiskalizacije.Value, DateFormat.ShortDate)
        Else
            kasa.datumDefiskalizacije = ""
        End If
        kasa.datumFiskalizacije = FormatDateTime(Me.datumFiskalizacije.Value, DateFormat.ShortDate)
        kasa.napomena = Me.napomena.Text

        saveKasa(kasa)

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
        Me.napomena.Text = ""
    End Sub
End Class