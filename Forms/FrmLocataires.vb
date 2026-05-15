Imports System.Drawing
Imports System.Windows.Forms
Imports Newtonsoft.Json.Linq

Public Class FrmLocataires

    ' Couleurs
    Private ReadOnly C_ACCENT As Color = Color.FromArgb(46, 160, 67)
    Private ReadOnly C_TEXT As Color = Color.FromArgb(230, 237, 243)
    Private ReadOnly C_MUTED As Color = Color.FromArgb(139, 148, 158)
    Private ReadOnly C_DANGER As Color = Color.FromArgb(220, 38, 38)
    Private ReadOnly C_WARNING As Color = Color.FromArgb(234, 179, 8)
    Private ReadOnly C_DGV_BG As Color = Color.FromArgb(22, 27, 34)
    Private ReadOnly C_DGV_HDR As Color = Color.FromArgb(13, 17, 23)
    Private ReadOnly C_DGV_ALT As Color = Color.FromArgb(28, 33, 40)

    ' Données complètes chargées depuis l'API
    Private _tousLesLocataires As JArray = New JArray()
    ' Locataire sélectionné
    Private _locataireSelectionne As JToken = Nothing

    '  CHARGEMENT
    Private Sub FrmLocataires_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StylerInterface()
        StylerDataGridView()
        InitialiserFiltres()
        ChargerLocataires()
    End Sub

    '  STYLE GÉNÉRAL
    Private Sub StylerInterface()
        ' Bouton Nouveau
        btnNouveauLoc.BackColor = C_ACCENT
        btnNouveauLoc.ForeColor = Color.White
        btnNouveauLoc.FlatStyle = FlatStyle.Flat
        btnNouveauLoc.FlatAppearance.BorderSize = 0
        btnNouveauLoc.Cursor = Cursors.Hand

        ' Bouton Exporter
        btnExporter.FlatStyle = FlatStyle.Flat
        btnExporter.FlatAppearance.BorderSize = 0
        btnExporter.Cursor = Cursors.Hand

        ' Bouton Modifier
        btnModifier.BackColor = Color.FromArgb(40, 40, 40)
        btnModifier.ForeColor = C_TEXT
        btnModifier.FlatStyle = FlatStyle.Flat
        btnModifier.FlatAppearance.BorderSize = 0
        btnModifier.Cursor = Cursors.Hand
        btnModifier.Enabled = False

        ' Bouton Voir contrat
        btnVoirContrat.FlatStyle = FlatStyle.Flat
        btnVoirContrat.FlatAppearance.BorderSize = 0
        btnVoirContrat.Cursor = Cursors.Hand
        btnVoirContrat.Enabled = False

        ' Bouton Supprimer
        btnSupprimer.BackColor = C_DANGER
        btnSupprimer.ForeColor = Color.White
        btnSupprimer.FlatStyle = FlatStyle.Flat
        btnSupprimer.FlatAppearance.BorderSize = 0
        btnSupprimer.Cursor = Cursors.Hand
        btnSupprimer.Enabled = False

        ' Panel info — vider au départ
        ViderPanneauDetail()
    End Sub

    '  STYLE DATAGRIDVIEW
    Private Sub StylerDataGridView()
        dgvloc.BackgroundColor = C_DGV_BG
        dgvloc.GridColor = Color.FromArgb(48, 54, 61)
        dgvloc.BorderStyle = BorderStyle.None
        dgvloc.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvloc.RowHeadersVisible = False
        dgvloc.AllowUserToAddRows = False
        dgvloc.AllowUserToDeleteRows = False
        dgvloc.ReadOnly = True
        dgvloc.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvloc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvloc.MultiSelect = False
        dgvloc.EnableHeadersVisualStyles = False
        dgvloc.ColumnHeadersHeight = 36
        dgvloc.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvloc.RowTemplate.Height = 34

        ' En-têtes
        dgvloc.ColumnHeadersDefaultCellStyle.BackColor = C_DGV_HDR
        dgvloc.ColumnHeadersDefaultCellStyle.ForeColor = C_TEXT
        dgvloc.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        ' Lignes
        dgvloc.DefaultCellStyle.BackColor = C_DGV_BG
        dgvloc.DefaultCellStyle.ForeColor = C_TEXT
        dgvloc.DefaultCellStyle.SelectionBackColor = C_ACCENT
        dgvloc.DefaultCellStyle.SelectionForeColor = Color.White
        dgvloc.DefaultCellStyle.Font = New Font("Segoe UI", 9)
        dgvloc.DefaultCellStyle.Padding = New Padding(4, 0, 4, 0)

        ' Lignes alternées
        dgvloc.AlternatingRowsDefaultCellStyle.BackColor = C_DGV_ALT
        dgvloc.AlternatingRowsDefaultCellStyle.ForeColor = C_TEXT
    End Sub

    '  INITIALISER LES FILTRES
    Private Sub InitialiserFiltres()
        cmbFilitres1.Items.Clear()
        cmbFilitres1.Items.Add("Tous les statuts")
        cmbFilitres1.Items.Add("Avec contrat actif")
        cmbFilitres1.Items.Add("Sans contrat")
        cmbFilitres1.SelectedIndex = 0

        cmbFilitres2.Items.Clear()
        cmbFilitres2.Items.Add("Tous les types")
        cmbFilitres2.Items.Add("Appartement")
        cmbFilitres2.Items.Add("Maison")
        cmbFilitres2.Items.Add("Villa")
        cmbFilitres2.Items.Add("Studio")
        cmbFilitres2.Items.Add("Bureau")
        cmbFilitres2.Items.Add("Boutique")
        cmbFilitres2.SelectedIndex = 0
    End Sub

    '  CHARGER LES LOCATAIRES DEPUIS L'API
    Private Sub ChargerLocataires()
        Dim worker As New System.ComponentModel.BackgroundWorker()

        AddHandler worker.DoWork, Sub(s, ev)
                                      ev.Result = ApiService.GetLocataires()
                                  End Sub

        AddHandler worker.RunWorkerCompleted, Sub(s, ev)
                                                  If ev.Error IsNot Nothing Then
                                                      MessageBox.Show("Erreur chargement : " & ev.Error.Message,
                                                                      "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                      Return
                                                  End If

                                                  Dim result As JObject = DirectCast(ev.Result, JObject)
                                                  If result Is Nothing OrElse result("success")?.Value(Of Boolean)() <> True Then
                                                      MessageBox.Show("Impossible de charger les locataires.",
                                                                      "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                                      Return
                                                  End If

                                                  _tousLesLocataires = DirectCast(result("data"), JArray)
                                                  AppliquerFiltres()
                                              End Sub

        worker.RunWorkerAsync()
    End Sub

    '  REMPLIR LE DATAGRIDVIEW
    Private Sub RemplirDGV(locataires As IEnumerable(Of JToken))
        dgvloc.Rows.Clear()

        Dim total As Integer = 0
        Dim actifs As Integer = 0
        Dim inactifs As Integer = 0

        ' CORRECTION ICI : Remplacement de "Loc" (mot-clé réservé) par "unLocataire"
        For Each unLocataire In locataires
            Dim nom = unLocataire("nom")?.ToString() & " " & unLocataire("prenom")?.ToString()
            Dim tel = unLocataire("telephone")?.ToString()
            Dim cni = unLocataire("cni")?.ToString()
            Dim prof = unLocataire("profession")?.ToString()
            Dim garant = unLocataire("garant_nom")?.ToString()

            ' CORRECTION ICI : Les types JToken se comparent avec .Type et des opérateurs classiques ou JTokenType.Null
            Dim hasContrat = unLocataire("contrat_actif") IsNot Nothing AndAlso
                             unLocataire("contrat_actif").Type <> JTokenType.Null

            Dim statut = If(hasContrat, "Actif", "Inactif")

            Dim i = dgvloc.Rows.Add(nom, tel, cni, prof, garant, statut)

            ' CORRECTION ICI : Passage de l'objet de la boucle à la propriété Tag sans parenthèses vides
            dgvloc.Rows(i).Tag = unLocataire

            ' Colorier statut
            If hasContrat Then
                dgvloc.Rows(i).Cells("colStatut").Style.ForeColor = C_ACCENT
                actifs += 1
            Else
                dgvloc.Rows(i).Cells("colStatut").Style.ForeColor = C_MUTED
                inactifs += 1
            End If

            total += 1
        Next

        ' Stats barre du bas
        lblTotalLoc1.Text = "Total : " & total
        lblTotalLoc2.Text = "Total : " & total
        lblLocActif.Text = "Actifs : " & actifs
        lblLocInactif.Text = "Inactifs : " & inactifs
    End Sub

    '  APPLIQUER FILTRES (recherche + combobox)
    Private Sub AppliquerFiltres()
        If _tousLesLocataires Is Nothing Then Return

        Dim recherche As String = txtrech.Text.Trim().ToLower()
        Dim filtreStatut As String = cmbFilitres1.SelectedItem?.ToString()

        Dim resultats = _tousLesLocataires.Where(Function(loc)
                                                     ' Filtre recherche
                                                     Dim nom = (loc("nom")?.ToString() & " " & loc("prenom")?.ToString()).ToLower()
                                                     Dim tel = loc("telephone")?.ToString().ToLower()
                                                     Dim cni = loc("cni")?.ToString().ToLower()
                                                     Dim matchRech = String.IsNullOrEmpty(recherche) OrElse
                                                                     nom.Contains(recherche) OrElse
                                                                     tel.Contains(recherche) OrElse
                                                                     cni.Contains(recherche)

                                                     ' Filtre statut
                                                     ' CORRECTION ICI : "loc" en minuscule évite le conflit avec le mot réservé "Loc"
                                                     Dim hasContrat = loc("contrat_actif") IsNot Nothing AndAlso
                                                                      loc("contrat_actif").Type <> JTokenType.Null
                                                     Dim matchStatut = True
                                                     Select Case filtreStatut
                                                         Case "Avec contrat actif" : matchStatut = hasContrat
                                                         Case "Sans contrat" : matchStatut = Not hasContrat
                                                     End Select

                                                     Return matchRech AndAlso matchStatut
                                                 End Function)

        RemplirDGV(resultats)
    End Sub

    '  SÉLECTION D'UNE LIGNE → Panneau détail
    Private Sub dgloc_SelectionChanged(sender As Object, e As EventArgs) Handles dgvloc.SelectionChanged
        If dgvloc.SelectedRows.Count = 0 Then
            ViderPanneauDetail()
            Return
        End If

        Dim loc As JToken = DirectCast(dgvloc.SelectedRows(0).Tag, JToken)
        If loc Is Nothing Then Return

        _locataireSelectionne = loc
        AfficherDetail(loc)

        ' Activer les boutons
        btnModifier.Enabled = True
        btnVoirContrat.Enabled = True
        btnSupprimer.Enabled = True
    End Sub

    '  AFFICHER LE DÉTAIL D'UN LOCATAIRE
    Private Sub AfficherDetail(loc As JToken)
        Dim prenom = loc("prenom")?.ToString()
        Dim nom = loc("nom")?.ToString()
        Dim initiales = ""
        If Not String.IsNullOrEmpty(prenom) Then initiales &= prenom(0).ToString().ToUpper()
        If Not String.IsNullOrEmpty(nom) Then initiales &= nom(0).ToString().ToUpper()

        lblinfodiminutif.Text = initiales
        lblloc.Text = prenom & " " & nom
        lblprofession.Text = loc("profession")?.ToString()
        lblTel1.Text = loc("telephone")?.ToString()
        lblMail1.Text = If(String.IsNullOrEmpty(loc("email")?.ToString()), "—", loc("email").ToString())
        lblCNI1.Text = If(String.IsNullOrEmpty(loc("cni")?.ToString()), "—", loc("cni").ToString())

        ' Garant
        Dim garantNom = loc("garant_nom")?.ToString()
        Dim garantTel = loc("garant_telephone")?.ToString()
        lblGerant1.Text = If(String.IsNullOrEmpty(garantNom), "—",
                            garantNom & If(String.IsNullOrEmpty(garantTel), "", " | " & garantTel))

        ' Contrat actif
        Dim contrat = loc("contrat_actif")
        If contrat IsNot Nothing AndAlso contrat.Type <> JTokenType.Null Then
            lblContratactif1.Text = "Oui — " & contrat("adresse")?.ToString()
            lblContratactif1.ForeColor = C_ACCENT
        Else
            lblContratactif1.Text = "Aucun contrat actif"
            lblContratactif1.ForeColor = C_MUTED
        End If

        ' Date inscription
        Dim dateStr = loc("created_at")?.ToString()
        If Not String.IsNullOrEmpty(dateStr) Then
            Try
                Dim d = DateTime.Parse(dateStr)
                lblinscrit1.Text = d.ToString("dd/MM/yyyy")
            Catch
                lblinscrit1.Text = dateStr
            End Try
        Else
            lblinscrit1.Text = "—"
        End If
    End Sub

    '  VIDER LE PANNEAU DÉTAIL
    Private Sub ViderPanneauDetail()
        _locataireSelectionne = Nothing
        lblinfodiminutif.Text = "?"
        lblloc.Text = "Sélectionner un locataire"
        lblprofession.Text = ""
        lblTel1.Text = "—"
        lblMail1.Text = "—"
        lblCNI1.Text = "—"
        lblGerant1.Text = "—"
        lblContratactif1.Text = "—"
        lblinscrit1.Text = "—"
        btnModifier.Enabled = False
        btnVoirContrat.Enabled = False
        btnSupprimer.Enabled = False
    End Sub

    '  ÉVÉNEMENTS FILTRES
    Private Sub txtrech_TextChanged(sender As Object, e As EventArgs) Handles txtrech.TextChanged
        AppliquerFiltres()
    End Sub

    Private Sub cmbFilitres1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilitres1.SelectedIndexChanged
        AppliquerFiltres()
    End Sub

    Private Sub cmbFilitres2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilitres2.SelectedIndexChanged
        AppliquerFiltres()
    End Sub

    '  BOUTON NOUVEAU LOCATAIRE
    Private Sub btnNouveauLoc_Click(sender As Object, e As EventArgs) Handles btnNouveauLoc.Click
        Dim frm As New FrmLocataireForm(Nothing)
        If frm.ShowDialog() = DialogResult.OK Then
            ChargerLocataires()
        End If
    End Sub

    '  BOUTON MODIFIER
    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        If _locataireSelectionne Is Nothing Then Return
        Dim frm As New FrmLocataireForm(_locataireSelectionne)
        If frm.ShowDialog() = DialogResult.OK Then
            ChargerLocataires()
        End If
    End Sub

    '  BOUTON VOIR CONTRAT
    Private Sub btnVoirContrat_Click(sender As Object, e As EventArgs) Handles btnVoirContrat.Click
        If _locataireSelectionne Is Nothing Then Return
        Dim contrat = _locataireSelectionne("contrat_actif")
        If contrat Is Nothing OrElse contrat.Type = JTokenType.Null Then
            MessageBox.Show("Ce locataire n'a pas de contrat actif.",
                            "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        ' TODO : ouvrir FrmContrats avec ce contrat
        MessageBox.Show("Contrat : " & contrat("adresse")?.ToString(),
                        "Contrat actif", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    '  BOUTON SUPPRIMER
    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        If _locataireSelectionne Is Nothing Then Return

        Dim nom = _locataireSelectionne("prenom")?.ToString() & " " &
                  _locataireSelectionne("nom")?.ToString()
        Dim confirm = MessageBox.Show(
            "Supprimer le locataire " & nom & " ?",
            "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If confirm <> DialogResult.Yes Then Return

        Dim id = _locataireSelectionne("id")?.Value(Of Integer)()

        Dim worker As New System.ComponentModel.BackgroundWorker()
        AddHandler worker.DoWork, Sub(s, ev)
                                      ev.Result = ApiService.SupprimerLocataire(id)
                                  End Sub
        AddHandler worker.RunWorkerCompleted, Sub(s, ev)
                                                  If ev.Error IsNot Nothing Then
                                                      MessageBox.Show("Erreur : " & ev.Error.Message, "Erreur",
                                                                      MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                      Return
                                                  End If
                                                  Dim result As JObject = DirectCast(ev.Result, JObject)
                                                  If result("success")?.Value(Of Boolean)() = True Then
                                                      MessageBox.Show("Locataire supprimé avec succès.",
                                                                      "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                      ViderPanneauDetail()
                                                      ChargerLocataires()
                                                  Else
                                                      MessageBox.Show(result("message")?.ToString(),
                                                                      "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                  End If
                                              End Sub
        worker.RunWorkerAsync()
    End Sub

    '  BOUTON EXPORTER (CSV simple)
    Private Sub btnExporter_Click(sender As Object, e As EventArgs) Handles btnExporter.Click
        If _tousLesLocataires Is Nothing OrElse _tousLesLocataires.Count = 0 Then
            MessageBox.Show("Aucune donnée à exporter.", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim dlg As New SaveFileDialog() With {
            .Filter = "Fichier CSV (*.csv)|*.csv",
            .FileName = "locataires_" & DateTime.Now.ToString("yyyyMMdd")
        }

        If dlg.ShowDialog() <> DialogResult.OK Then Return

        Dim lignes As New System.Text.StringBuilder()
        lignes.AppendLine("Nom;Prenom;Telephone;Email;CNI;Profession;Garant;Garant Tel")

        For Each unLocataire In _tousLesLocataires
            lignes.AppendLine(String.Join(";", {
                unLocataire("nom")?.ToString(),
                unLocataire("prenom")?.ToString(),
                unLocataire("telephone")?.ToString(),
                unLocataire("email")?.ToString(),
                unLocataire("cni")?.ToString(),
                unLocataire("profession")?.ToString(),
                unLocataire("garant_nom")?.ToString(),
                unLocataire("garant_telephone")?.ToString()
            }))
        Next

        System.IO.File.WriteAllText(dlg.FileName, lignes.ToString(),
                                    System.Text.Encoding.UTF8)
        MessageBox.Show("Export réussi : " & dlg.FileName, "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class