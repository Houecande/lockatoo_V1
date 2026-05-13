' ============================================================
'  FrmLogin.vb
'  Formulaire de connexion — .NET Framework 4.x
'  Design sombre, sans PlaceholderText (non dispo sur 4.x)
' ============================================================
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Windows.Forms.Design
Imports Newtonsoft.Json.Linq

Public Class FrmLogin
    Inherits Form

    ' ── Contrôles ───────────────────────────────────────────
    Private WithEvents btnConnecter As Button
    Private WithEvents txtEmail As TextBox
    Private WithEvents txtMotDePasse As TextBox
    Private WithEvents chkVoirMdp As CheckBox
    Private lblErreur As Label
    Private lblChargement As Label
    Private pnlCard As Panel
    Private bgWorker As System.ComponentModel.BackgroundWorker

    ' ── Couleurs thème sombre ────────────────────────────────
    Private ReadOnly C_BG As Color = Color.FromArgb(13, 17, 23)
    Private ReadOnly C_CARD As Color = Color.FromArgb(22, 27, 34)
    Private ReadOnly C_INPUT As Color = Color.FromArgb(28, 33, 40)
    Private ReadOnly C_BORDER As Color = Color.FromArgb(48, 54, 61)
    Private ReadOnly C_ACCENT As Color = Color.FromArgb(46, 160, 67)
    Private ReadOnly C_TEXT As Color = Color.FromArgb(230, 237, 243)
    Private ReadOnly C_MUTED As Color = Color.FromArgb(139, 148, 158)
    Private ReadOnly C_ERROR As Color = Color.FromArgb(248, 81, 73)

    ' Données récupérées par le BackgroundWorker
    Private _resultat As JObject

    ' ============================================================
    Public Sub New()
        InitialiserComposants()
        InitialiserWorker()
    End Sub

    ' ============================================================
    '  INTERFACE
    ' ============================================================
    Private Sub InitialiserComposants()
        Me.Text = "Lokatoo — Connexion"
        Me.Size = New Size(440, 520)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.BackColor = C_BG
        Me.Font = New Font("Segoe UI", 10)

        ' Carte
        pnlCard = New Panel With {
            .Size = New Size(380, 440),
            .Location = New Point(30, 30),
            .BackColor = C_CARD
        }
        Me.Controls.Add(pnlCard)

        ' Logo
        Dim lblLogo As New Label With {
            .Text = "Lokatoo",
            .Font = New Font("Segoe UI", 18, FontStyle.Bold),
            .ForeColor = C_TEXT,
            .AutoSize = True,
            .Location = New Point(30, 28)
        }
        pnlCard.Controls.Add(lblLogo)

        Dim lblSub As New Label With {
            .Text = "Connectez-vous a votre espace de gestion",
            .Font = New Font("Segoe UI", 9),
            .ForeColor = C_MUTED,
            .Size = New Size(320, 20),
            .Location = New Point(30, 65)
        }
        pnlCard.Controls.Add(lblSub)

        ' Séparateur
        Dim sep As New Label With {
            .Size = New Size(320, 1),
            .Location = New Point(30, 92),
            .BackColor = C_BORDER
        }
        pnlCard.Controls.Add(sep)

        ' Erreur
        lblErreur = New Label With {
            .Size = New Size(320, 36),
            .Location = New Point(30, 102),
            .ForeColor = C_ERROR,
            .BackColor = Color.FromArgb(40, 248, 81, 73),
            .Font = New Font("Segoe UI", 9),
            .Visible = False,
            .TextAlign = ContentAlignment.MiddleLeft
        }
        pnlCard.Controls.Add(lblErreur)

        ' Email label
        Dim lblEmail As New Label With {
            .Text = "Adresse email",
            .ForeColor = C_MUTED,
            .Font = New Font("Segoe UI", 9),
            .AutoSize = True,
            .Location = New Point(30, 152)
        }
        pnlCard.Controls.Add(lblEmail)

        ' Email input
        txtEmail = New TextBox With {
            .Size = New Size(320, 32),
            .Location = New Point(30, 172),
            .BackColor = C_INPUT,
            .ForeColor = C_TEXT,
            .BorderStyle = BorderStyle.FixedSingle,
            .Font = New Font("Segoe UI", 10),
            .Text = "vous@agence.bj"
        }
        pnlCard.Controls.Add(txtEmail)

        ' Mot de passe label
        Dim lblMdp As New Label With {
            .Text = "Mot de passe",
            .ForeColor = C_MUTED,
            .Font = New Font("Segoe UI", 9),
            .AutoSize = True,
            .Location = New Point(30, 220)
        }
        pnlCard.Controls.Add(lblMdp)

        ' Mot de passe input
        txtMotDePasse = New TextBox With {
            .Size = New Size(320, 32),
            .Location = New Point(30, 240),
            .BackColor = C_INPUT,
            .ForeColor = C_TEXT,
            .BorderStyle = BorderStyle.FixedSingle,
            .Font = New Font("Segoe UI", 10),
            .PasswordChar = "*"c
        }
        pnlCard.Controls.Add(txtMotDePasse)

        ' Voir mot de passe
        chkVoirMdp = New CheckBox With {
            .Text = "Afficher le mot de passe",
            .ForeColor = C_MUTED,
            .Font = New Font("Segoe UI", 9),
            .AutoSize = True,
            .Location = New Point(30, 286),
            .BackColor = Color.Transparent
        }
        pnlCard.Controls.Add(chkVoirMdp)

        ' Bouton connexion
        btnConnecter = New Button With {
            .Text = "Se connecter",
            .Size = New Size(320, 44),
            .Location = New Point(30, 324),
            .BackColor = C_ACCENT,
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat,
            .Font = New Font("Segoe UI", 11, FontStyle.Bold),
            .Cursor = Cursors.Hand
        }
        btnConnecter.FlatAppearance.BorderSize = 0
        pnlCard.Controls.Add(btnConnecter)

        ' Chargement
        lblChargement = New Label With {
            .Text = "Connexion en cours...",
            .ForeColor = C_MUTED,
            .Font = New Font("Segoe UI", 9, FontStyle.Italic),
            .AutoSize = True,
            .Location = New Point(30, 382),
            .Visible = False
        }
        pnlCard.Controls.Add(lblChargement)

        ' Footer
        Dim lblFooter As New Label With {
            .Text = "© " & Date.Now.Year & " Lokatoo — Gestion Immobiliere",
            .ForeColor = C_MUTED,
            .Font = New Font("Segoe UI", 8),
            .AutoSize = True,
            .Location = New Point(30, 408)
        }
        pnlCard.Controls.Add(lblFooter)

        Me.AcceptButton = btnConnecter
    End Sub

    ' ============================================================
    '  BACKGROUNDWORKER — appel API sans bloquer l'UI
    ' ============================================================
    Private Sub InitialiserWorker()
        bgWorker = New System.ComponentModel.BackgroundWorker()
        AddHandler bgWorker.DoWork, AddressOf Worker_DoWork
        AddHandler bgWorker.RunWorkerCompleted, AddressOf Worker_Completed
    End Sub

    Private Sub Worker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)
        Dim args = DirectCast(e.Argument, String())
        _resultat = ApiService.Login(args(0), args(1))
    End Sub

    Private Sub Worker_Completed(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs)
        If e.Error IsNot Nothing Then
            AfficherErreur("Erreur inattendue : " & e.Error.Message)
            Return
        End If

        If _resultat Is Nothing Then
            AfficherErreur("Pas de réponse du serveur")
            Return
        End If

        If _resultat("success")?.Value(Of Boolean)() = True Then
            ' Stocker les infos utilisateur
            Dim user = _resultat("data")("user")
            AppConfig.TokenJWT = _resultat("data")("token").ToString()
            AppConfig.UserID = user("id").Value(Of Integer)()
            AppConfig.UserNom = user("nom").ToString()
            AppConfig.UserPrenom = user("prenom").ToString()
            AppConfig.UserEmail = user("email").ToString()
            AppConfig.UserRole = user("role").ToString()

            ' Ouvrir dashboard
            Dim dashboard As New FrmDashboard()
            dashboard.Show()
            Me.Hide()
        Else
            AfficherErreur(_resultat("message")?.ToString() & "")
        End If
    End Sub

    ' ============================================================
    '  ÉVÉNEMENTS
    ' ============================================================
    Private Sub chkVoirMdp_CheckedChanged(sender As Object, e As EventArgs) _
        Handles chkVoirMdp.CheckedChanged
        txtMotDePasse.PasswordChar = If(chkVoirMdp.Checked, ControlChars.NullChar, "*"c)
    End Sub

    Private Sub txtEmail_Enter(sender As Object, e As EventArgs) Handles txtEmail.Enter
        If txtEmail.Text = "vous@agence.bj" Then
            txtEmail.Text = ""
            txtEmail.ForeColor = Color.FromArgb(230, 237, 243)
        End If
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            txtEmail.Text = "vous@agence.bj"
            txtEmail.ForeColor = Color.FromArgb(139, 148, 158)
        End If
    End Sub

    Private Sub btnConnecter_Click(sender As Object, e As EventArgs) _
        Handles btnConnecter.Click

        lblErreur.Visible = False
        Dim email = txtEmail.Text.Trim()
        Dim mdp = txtMotDePasse.Text.Trim()

        If email = "vous@agence.bj" OrElse String.IsNullOrEmpty(email) OrElse
           String.IsNullOrEmpty(mdp) Then
            AfficherErreur("Veuillez remplir tous les champs.")
            Return
        End If

        ' Lancer l'appel API en arrière-plan
        lblChargement.Visible = True
        btnConnecter.Enabled = False
        btnConnecter.Text = "Connexion..."

        bgWorker.RunWorkerAsync(New String() {email, mdp})
    End Sub

    Private Sub AfficherErreur(message As String)
        lblErreur.Text = "  " & message
        lblErreur.Visible = True
        lblChargement.Visible = False
        btnConnecter.Enabled = True
        btnConnecter.Text = "Se connecter"
        txtMotDePasse.Clear()
        txtMotDePasse.Focus()
    End Sub

    Private Sub FrmLogin_FormClosed(sender As Object, e As FormClosedEventArgs) _
        Handles Me.FormClosed
        Application.Exit()
    End Sub

End Class