Imports System.Drawing
Imports System.Windows.Forms
Imports Newtonsoft.Json.Linq

Public Class FrmDashboard

    ' Couleurs Thème 
    Private ReadOnly C_ACCENT As Color = Color.FromArgb(46, 160, 67)
    Private ReadOnly C_BG_BTN As Color = Color.FromArgb(22, 27, 34)
    Private ReadOnly C_HOVER As Color = Color.FromArgb(48, 54, 61)
    Private ReadOnly C_TEXT As Color = Color.FromArgb(230, 237, 243)
    Private ReadOnly C_MUTED As Color = Color.FromArgb(139, 148, 158)
    Private ReadOnly C_DANGER As Color = Color.FromArgb(220, 38, 38)

    Private _btnActif As Button = Nothing

    '  CHARGEMENT
    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Infos utilisateur & Initiales
        lblinfodimunitif.Text = GenererInitiales(AppConfig.UserPrenom, AppConfig.UserNom)

        Dim nomComplet As String = $"{AppConfig.NomComplet} — {AppConfig.LabelRole}"
        lblinfopconnect.AutoEllipsis = True
        lblinfopconnect.Text = nomComplet

        ' Configuration UI
        StylerBoutonsSidebar()
        AppliquerVisibiliteRole()
        StylerDataGridView(dgvStat1)
        StylerDataGridView(dgvStat2)

        ' État initial
        SetBtnActif(btnDashboard)
        ChargerDashboard()
    End Sub

    Private Function GenererInitiales(prenom As String, nom As String) As String
        Dim p = If(String.IsNullOrEmpty(prenom), "", prenom(0).ToString().ToUpper())
        Dim n = If(String.IsNullOrEmpty(nom), "", nom(0).ToString().ToUpper())
        Return p & n
    End Function

    '  STYLE SIDEBAR (CORRECTIF TRANSPARENT INCLUS)
    Private Sub StylerBoutonsSidebar()
        Dim boutons As Button() = {
            btnDashboard, btnBien, btnLocataires, btnContrats,
            btnPaiements, btnNotification, btnBailleurs,
            btnDécaissements, btnEtatdesLieux, btnResiliation,
            btnPersonnel
        }

        For Each btn In boutons
            btn.FlatStyle = FlatStyle.Flat
            ' CORRECTIF : On met BorderSize à 0 au lieu de mettre BorderColor à Transparent
            btn.FlatAppearance.BorderSize = 0

            btn.BackColor = C_BG_BTN
            btn.ForeColor = C_MUTED
            btn.TextAlign = ContentAlignment.MiddleLeft
            btn.Cursor = Cursors.Hand
            btn.Padding = New Padding(12, 0, 0, 0)

            AddHandler btn.MouseEnter, AddressOf Btn_MouseEnter
            AddHandler btn.MouseLeave, AddressOf Btn_MouseLeave
        Next

        ' Bouton Déconnexion
        btnDeconnexion.FlatStyle = FlatStyle.Flat
        btnDeconnexion.FlatAppearance.BorderSize = 0
        btnDeconnexion.BackColor = C_DANGER
        btnDeconnexion.ForeColor = Color.White
    End Sub

    Private Sub SetBtnActif(btn As Button)
        If _btnActif IsNot Nothing Then
            _btnActif.BackColor = C_BG_BTN
            _btnActif.ForeColor = C_MUTED
        End If
        _btnActif = btn
        _btnActif.BackColor = C_HOVER
        _btnActif.ForeColor = C_TEXT
    End Sub

    Private Sub Btn_MouseEnter(sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        If btn IsNot _btnActif Then btn.BackColor = C_HOVER
    End Sub

    Private Sub Btn_MouseLeave(sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        If btn IsNot _btnActif Then btn.BackColor = C_BG_BTN
    End Sub

    '  HABILITATIONS
    Private Sub AppliquerVisibiliteRole()
        btnBailleurs.Visible = AppConfig.ARole(AppConfig.ROLE_DG, AppConfig.ROLE_GERANT)
        btnDécaissements.Visible = AppConfig.ARole(AppConfig.ROLE_DG, AppConfig.ROLE_GERANT, AppConfig.ROLE_SECRETAIRE)
        btnEtatdesLieux.Visible = AppConfig.ARole(AppConfig.ROLE_DG, AppConfig.ROLE_GERANT, AppConfig.ROLE_AGENT)
        btnResiliation.Visible = AppConfig.ARole(AppConfig.ROLE_DG, AppConfig.ROLE_GERANT)
        btnPersonnel.Visible = AppConfig.ARole(AppConfig.ROLE_DG)
        btnContrats.Visible = AppConfig.ARole(AppConfig.ROLE_DG, AppConfig.ROLE_GERANT, AppConfig.ROLE_AGENT)
    End Sub

    '  DONNÉES API
    Private Sub ChargerDashboard()
        Dim worker As New System.ComponentModel.BackgroundWorker()
        AddHandler worker.DoWork, Sub(s, ev) ev.Result = ApiService.GetDashboard()

        AddHandler worker.RunWorkerCompleted, Sub(s, ev)
                                                  If ev.Error IsNot Nothing OrElse ev.Result Is Nothing Then Return
                                                  Dim result As JObject = TryCast(ev.Result, JObject)
                                                  If result IsNot Nothing AndAlso result("success")?.Value(Of Boolean)() = True Then
                                                      Dim data = result("data")
                                                      MajCartesStat(data)
                                                      MajDgvPaiements(data("paiements_recents"))
                                                      MajDgvBiens(data("biens_disponibles"))
                                                  End If
                                              End Sub
        worker.RunWorkerAsync()
    End Sub

    Private Sub MajCartesStat(data As JToken)
        Try
            lblstat1.Text = data("nb_locataires")?.ToString()
            lblstat2.Text = data("nb_biens_libres")?.ToString()
            lblstat3.Text = data("nb_contrats")?.ToString()
            Dim montant = CDec(If(data("total_paiements_mois")?.ToString(), "0"))
            lblstat4.Text = $"{FormatNumber(montant, 0)} FCFA"
        Catch
        End Try
    End Sub


    '  STYLE & REMPLISSAGE GRILLES
    Private Sub StylerDataGridView(dgv As DataGridView)
        dgv.BackgroundColor = Color.FromArgb(22, 27, 34)
        dgv.GridColor = Color.FromArgb(48, 54, 61)
        dgv.BorderStyle = BorderStyle.None
        dgv.RowHeadersVisible = False
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.EnableHeadersVisualStyles = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(13, 17, 23)
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = C_TEXT
        dgv.ColumnHeadersHeight = 36

        dgv.DefaultCellStyle.BackColor = Color.FromArgb(22, 27, 34)
        dgv.DefaultCellStyle.ForeColor = C_TEXT
        dgv.DefaultCellStyle.SelectionBackColor = C_ACCENT
    End Sub

    Private Sub MajDgvPaiements(items As JToken)
        dgvStat1.Rows.Clear()
        dgvStat1.Columns.Clear()
        dgvStat1.Columns.Add("locataire", "Locataire")
        dgvStat1.Columns.Add("montant", "Montant")
        dgvStat1.Columns.Add("mode", "Mode")
        dgvStat1.Columns.Add("date", "Date")
        dgvStat1.Columns.Add("statut", "Statut")

        If items Is Nothing Then Return
        For Each item In items
            Dim i = dgvStat1.Rows.Add(
                item("locataire")?.ToString(),
                $"{FormatNumber(CDec(If(item("montant")?.ToString(), "0")), 0)} FCFA",
                item("mode")?.ToString(),
                item("date_paiement")?.ToString(),
                item("statut")?.ToString()
            )

            ' Coloration Statut
            Dim val = item("statut")?.ToString().ToLower()
            If val = "valide" Then dgvStat1.Rows(i).Cells(4).Style.ForeColor = Color.FromArgb(46, 160, 67)
            If val = "en_attente" Then dgvStat1.Rows(i).Cells(4).Style.ForeColor = Color.FromArgb(210, 153, 34)
            If val = "echec" Then dgvStat1.Rows(i).Cells(4).Style.ForeColor = Color.FromArgb(248, 81, 73)
        Next
    End Sub

    Private Sub MajDgvBiens(items As JToken)
        dgvStat2.Rows.Clear()
        dgvStat2.Columns.Clear()
        dgvStat2.Columns.Add("adresse", "Adresse")
        dgvStat2.Columns.Add("type", "Type")
        dgvStat2.Columns.Add("loyer", "Loyer")
        dgvStat2.Columns.Add("quartier", "Quartier")

        If items Is Nothing Then Return
        For Each item In items
            dgvStat2.Rows.Add(
                item("adresse")?.ToString(),
                item("type")?.ToString(),
                $"{FormatNumber(CDec(If(item("loyer_mensuel")?.ToString(), "0")), 0)} FCFA",
                item("quartier")?.ToString()
            )
        Next
    End Sub

    '  ACTIONS & NAVIGATION
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        SetBtnActif(btnDashboard)
        ChargerDashboard()
    End Sub

    Private Sub btnBien_Click(sender As Object, e As EventArgs) Handles btnBien.Click
        SetBtnActif(btnBien)
    End Sub

    Private Sub btnLocataires_Click(sender As Object, e As EventArgs) Handles btnLocataires.Click
        SetBtnActif(btnLocataires)
    End Sub

    Private Sub btnContrats_Click(sender As Object, e As EventArgs) Handles btnContrats.Click
        SetBtnActif(btnContrats)
    End Sub

    Private Sub btnPaiements_Click(sender As Object, e As EventArgs) Handles btnPaiements.Click
        SetBtnActif(btnPaiements)
    End Sub

    Private Sub btnNotification_Click(sender As Object, e As EventArgs) Handles btnNotification.Click
        SetBtnActif(btnNotification)
    End Sub

    Private Sub btnBailleurs_Click(sender As Object, e As EventArgs) Handles btnBailleurs.Click
        SetBtnActif(btnBailleurs)
    End Sub

    Private Sub btnDecaissements_Click(sender As Object, e As EventArgs) Handles btnDécaissements.Click
        SetBtnActif(btnDécaissements)
    End Sub

    Private Sub btnEtatsdesLieux_Click(sender As Object, e As EventArgs) Handles btnEtatdesLieux.Click
        SetBtnActif(btnEtatdesLieux)
    End Sub

    Private Sub btnResiliations_Click(sender As Object, e As EventArgs) Handles btnResiliation.Click
        SetBtnActif(btnResiliation)
    End Sub

    Private Sub btnPersonnel_Click(sender As Object, e As EventArgs) Handles btnPersonnel.Click
        SetBtnActif(btnPersonnel)
    End Sub

    Private Sub btnDeconnexion_Click(sender As Object, e As EventArgs) Handles btnDeconnexion.Click
        If MessageBox.Show("Voulez-vous vous déconnecter ?", "Lokatoo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            RemoveHandler Me.FormClosed, AddressOf FrmDashboard_FormClosed
            AppConfig.ResetSession()
            Dim login As New FrmLogin()
            login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub FrmDashboard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

End Class