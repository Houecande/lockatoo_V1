Imports System.Drawing
Imports System.Windows.Forms
Imports Newtonsoft.Json.Linq

Public Class FrmDashboard

    ' Couleurs thème 
    Private ReadOnly C_ACCENT As Color = Color.FromArgb(46, 160, 67)
    Private ReadOnly C_BG_BTN As Color = Color.FromArgb(22, 27, 34)
    Private ReadOnly C_HOVER As Color = Color.FromArgb(48, 54, 61)
    Private ReadOnly C_TEXT As Color = Color.FromArgb(230, 237, 243)
    Private ReadOnly C_MUTED As Color = Color.FromArgb(139, 148, 158)
    Private ReadOnly C_DANGER As Color = Color.FromArgb(220, 38, 38)

    ' Bouton actif en cours
    Private _btnActif As Button = Nothing

    '  CHARGEMENT
    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Infos utilisateur connecté
        lblinfodimunitif.Text = GenererInitiales(AppConfig.UserPrenom, AppConfig.UserNom)
        lblinfopconnect.Text = $"{AppConfig.NomComplet} — {AppConfig.LabelRole}"

        ' Configuration UI
        StylerBoutonsSidebar()
        AppliquerVisibiliteRole()
        StylerDataGridView(dgvStat1)
        StylerDataGridView(dgvStat2)

        ' État par défaut
        SetBtnActif(btnDashboard)
        ChargerDashboard()
    End Sub

    '  FONCTIONS UTILITAIRES
    Private Function GenererInitiales(prenom As String, nom As String) As String
        Dim p = If(String.IsNullOrEmpty(prenom), "", prenom(0).ToString().ToUpper())
        Dim n = If(String.IsNullOrEmpty(nom), "", nom(0).ToString().ToUpper())
        Return p & n
    End Function

    '  STYLE & NAVIGATION SIDEBAR
    Private Sub StylerBoutonsSidebar()
        Dim boutons As Button() = {
            btnDashboard, btnBien, btnLacataires, btnContrats,
            btnPaiements, btnNotification, btnBailleurs,
            btnDécaissements, btnEtatdesLieux, btnResiliation,
            btnPersonnel
        }
        For Each btn In boutons
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.BackColor = C_BG_BTN
            btn.ForeColor = C_MUTED
            btn.TextAlign = ContentAlignment.MiddleLeft
            btn.Cursor = Cursors.Hand
            btn.Padding = New Padding(12, 0, 0, 0)

            AddHandler btn.MouseEnter, AddressOf Btn_MouseEnter
            AddHandler btn.MouseLeave, AddressOf Btn_MouseLeave
        Next

        ' Bouton déconnexion
        btnDeconnexion.FlatStyle = FlatStyle.Flat
        btnDeconnexion.FlatAppearance.BorderSize = 0
        btnDeconnexion.BackColor = C_DANGER
        btnDeconnexion.ForeColor = Color.White
        btnDeconnexion.Cursor = Cursors.Hand
    End Sub

    Private Sub Btn_MouseEnter(sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        If btn IsNot _btnActif Then btn.BackColor = C_HOVER
    End Sub

    Private Sub Btn_MouseLeave(sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        If btn IsNot _btnActif Then btn.BackColor = C_BG_BTN
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

    '  VISIBILITÉ PAR RÔLE (Habilitations)
    Private Sub AppliquerVisibiliteRole()
        btnBailleurs.Visible = AppConfig.ARole(AppConfig.ROLE_DG, AppConfig.ROLE_GERANT)

        btnDécaissements.Visible = AppConfig.ARole(
            AppConfig.ROLE_DG, AppConfig.ROLE_GERANT, AppConfig.ROLE_SECRETAIRE)

        btnEtatdesLieux.Visible = AppConfig.ARole(
            AppConfig.ROLE_DG, AppConfig.ROLE_GERANT, AppConfig.ROLE_AGENT)

        btnResiliation.Visible = AppConfig.ARole(AppConfig.ROLE_DG, AppConfig.ROLE_GERANT)
        btnPersonnel.Visible = AppConfig.ARole(AppConfig.ROLE_DG)

        btnContrats.Visible = AppConfig.ARole(
            AppConfig.ROLE_DG, AppConfig.ROLE_GERANT, AppConfig.ROLE_AGENT)
    End Sub

    '  GESTION DES DONNÉES (API)
    Private Sub ChargerDashboard()
        Dim worker As New System.ComponentModel.BackgroundWorker()

        AddHandler worker.DoWork, Sub(s, ev)
                                      ev.Result = ApiService.GetDashboard()
                                  End Sub

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
            lblstat1.Text = $"{data("nb_locataires")} Locataires"
            lblstat2.Text = $"{data("nb_biens_libres")} Biens libres"
            lblstat3.Text = $"{data("nb_contrats")} Contrats actifs"

            Dim montant As Decimal = 0
            Decimal.TryParse(data("total_paiements_mois")?.ToString(), montant)
            lblstat4.Text = $"{FormatNumber(montant, 0)} FCFA"

            ' Invalidate est plus fluide que Refresh pour éviter le flickering(scintillement ou papillotement)
            pnlstat1.Invalidate()
        Catch
        End Try
    End Sub

    '  STYLE DATAGRIDVIEW
    Private Sub StylerDataGridView(dgv As DataGridView)
        dgv.BackgroundColor = Color.FromArgb(22, 27, 34)
        dgv.GridColor = Color.FromArgb(48, 54, 61)
        dgv.BorderStyle = BorderStyle.None
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv.RowHeadersVisible = False
        dgv.AllowUserToAddRows = False
        dgv.ReadOnly = True
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.EnableHeadersVisualStyles = False

        ' Headers
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(13, 17, 23)
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = C_TEXT
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        dgv.ColumnHeadersHeight = 36

        ' Rows
        dgv.DefaultCellStyle.BackColor = Color.FromArgb(22, 27, 34)
        dgv.DefaultCellStyle.ForeColor = C_TEXT
        dgv.DefaultCellStyle.SelectionBackColor = C_ACCENT
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(28, 33, 40)
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
            dgvStat1.Rows.Add(
                item("locataire"),
                $"{FormatNumber(item("montant"), 0)} FCFA",
                item("mode"),
                item("date_paiement"),
                item("statut")
            )
        Next
        ColorierStatut(dgvStat1, 4)
    End Sub

    Private Sub MajDgvBiens(items As JToken)
        dgvStat2.Rows.Clear()
        dgvStat2.Columns.Clear()
        dgvStat2.Columns.Add("adresse", "Adresse")
        dgvStat2.Columns.Add("type", "Type")
        dgvStat2.Columns.Add("quartier", "Quartier")
        dgvStat2.Columns.Add("loyer", "Loyer")

        If items Is Nothing Then Return
        For Each item In items
            dgvStat2.Rows.Add(
                item("adresse"),
                item("type"),
                item("quartier"),
                $"{FormatNumber(item("loyer_mensuel"), 0)} FCFA"
            )
        Next
    End Sub

    Private Sub ColorierStatut(dgv As DataGridView, colIndex As Integer)
        For Each row As DataGridViewRow In dgv.Rows
            Dim val = row.Cells(colIndex).Value?.ToString().ToLower()
            Select Case val
                Case "valide", "payé"
                    row.Cells(colIndex).Style.ForeColor = Color.FromArgb(46, 160, 67)
                Case "en_attente"
                    row.Cells(colIndex).Style.ForeColor = Color.FromArgb(210, 153, 34)
                Case "echec", "impayé"
                    row.Cells(colIndex).Style.ForeColor = Color.FromArgb(248, 81, 73)
            End Select
        Next
    End Sub

    '  ÉVÉNEMENTS CLICS SIDEBAR
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        SetBtnActif(btnDashboard)
        ChargerDashboard()
    End Sub

    ' ... (Autres événements boutons : btnBien, btnLocataires, etc.)

    '  DÉCONNEXION
    Private Sub btnDeconnexion_Click(sender As Object, e As EventArgs) Handles btnDeconnexion.Click
        If MessageBox.Show("Voulez-vous vraiment vous déconnecter ?", "Lokatoo",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            ' TRÈS IMPORTANT : On retire le handler pour éviter Application.Exit()
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