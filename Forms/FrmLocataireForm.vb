Imports Newtonsoft.Json.Linq

Public Class FrmLocataireForm
    ' Cette variable stockera les données du locataire s'il y en a (Mode modification)
    Private _donneesLocataire As JToken

    ' Ce constructeur permet de recevoir les données
    Public Sub New(locataire As JToken)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' On enregistre les données reçues
        _donneesLocataire = locataire

        ' Si ce n'est pas Nothing, on remplit les champs (Mode Modification)
        If _donneesLocataire IsNot Nothing Then
            Me.Text = "Modifier le locataire"
            ' Exemple : txtNom.Text = _donneesLocataire("nom")?.ToString()
        Else
            Me.Text = "Nouveau locataire"
        End If
    End Sub
End Class