Imports System.Drawing
Imports Newtonsoft.Json.Linq

Public Class FrmLogin
    '  CHARGEMENT DU FORMULAIRE
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cacher le label erreur au depart
        lblErrorMessage.Visible = False
        lblErrorMessage.ForeColor = Color.FromArgb(248, 81, 73)
        lblErrorMessage.BackColor = Color.FromArgb(40, 248, 81, 73)

        ' Masquer le mot de passe par defaut
        txtPassword.PasswordChar = "*"c

        ' Bouton Se connecter en vert accent
        btnSeconnecter.BackColor = Color.FromArgb(46, 160, 67)
        btnSeconnecter.ForeColor = Color.White
        btnSeconnecter.FlatStyle = FlatStyle.Flat
        btnSeconnecter.FlatAppearance.BorderSize = 0
        btnSeconnecter.Cursor = Cursors.Hand

        ' Touche Entree = clic btnSeConnecter
        Me.AcceptButton = btnSeconnecter

        ' Textes des labels
        txtEmail.Text = "Adresse email"
        txtPassword.Text = "Mot de passe"
    End Sub

    '  CHECKBOX — Afficher / Masquer le mot de passe
    Private Sub cboxAffichage_CheckedChanged(sender As Object, e As EventArgs) _
        Handles cboxaffichage.CheckedChanged
        If cboxaffichage.Checked Then
            txtPassword.PasswordChar = ControlChars.NullChar
        Else
            txtPassword.PasswordChar = "*"c
        End If
        txtPassword.Focus()
    End Sub

    '  BOUTON SE CONNECTER
    Private Sub btnSeConnecter_Click(sender As Object, e As EventArgs) _
        Handles btnSeconnecter.Click

        ' Cacher erreur precedente
        lblErrorMessage.Visible = False

        Dim email As String = txtEmail.Text.Trim()
        Dim mdp As String = txtPassword.Text.Trim()

        ' Validation locale
        If String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(mdp) Then
            AfficherErreur("Veuillez remplir tous les champs.")
            Return
        End If

        ' Desactiver le bouton pendant l'appel
        btnSeconnecter.Enabled = False
        btnSeconnecter.Text = "Connexion..."
        Me.Cursor = Cursors.WaitCursor

        ' Appel API via BackgroundWorker (ne bloque pas l'UI)
        Dim worker As New System.ComponentModel.BackgroundWorker()

        AddHandler worker.DoWork, Sub(s, ev)
                                      Dim args = DirectCast(ev.Argument, String())
                                      ev.Result = ApiService.Login(args(0), args(1))
                                  End Sub

        AddHandler worker.RunWorkerCompleted, Sub(s, ev)
                                                  Me.Cursor = Cursors.Default
                                                  btnSeconnecter.Enabled = True
                                                  btnSeconnecter.Text = "Se connecter"

                                                  If ev.Error IsNot Nothing Then
                                                      AfficherErreur("Erreur : " & ev.Error.Message)
                                                      Return
                                                  End If

                                                  Dim result As JObject = DirectCast(ev.Result, JObject)

                                                  If result Is Nothing Then
                                                      AfficherErreur("Pas de reponse du serveur. Verifiez que WAMP est actif.")
                                                      Return
                                                  End If

                                                  If result("success")?.Value(Of Boolean)() = True Then
                                                      ' Stocker les infos utilisateur dans AppConfig
                                                      Dim user = result("data")("user")
                                                      AppConfig.TokenJWT = result("data")("token").ToString()
                                                      AppConfig.UserID = user("id").Value(Of Integer)()
                                                      AppConfig.UserNom = user("nom").ToString()
                                                      AppConfig.UserPrenom = user("prenom").ToString()
                                                      AppConfig.UserEmail = user("email").ToString()
                                                      AppConfig.UserRole = user("role").ToString()

                                                      ' Ouvrir le Dashboard et cacher le login
                                                      Dim dashboard As New FrmDashboard()
                                                      dashboard.Show()
                                                      Me.Hide()
                                                  Else
                                                      Dim msg As String = result("message")?.ToString()
                                                      AfficherErreur(If(String.IsNullOrEmpty(msg),
                                                                     "Email ou mot de passe incorrect.", msg))
                                                  End If
                                              End Sub

        worker.RunWorkerAsync(New String() {email, mdp})
    End Sub

    '  AFFICHER UN MESSAGE D'ERREUR
    Private Sub AfficherErreur(message As String)
        lblErrorMessage.Text = "  " & message
        lblErrorMessage.Visible = True
        txtPassword.Clear()
        txtPassword.Focus()
    End Sub

End Class