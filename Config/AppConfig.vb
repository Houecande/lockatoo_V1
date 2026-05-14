
'  Config/AppConfig.vb
'  Configuration globale — .NET Framework 4.x
Public Module AppConfig

    ' URL de base de l'API PHP (WAMP local)
    Public Const API_BASE_URL As String = "http://localhost/lokatoo/api"

    ' Token JWT stocké après connexion
    Public TokenJWT As String = ""

    ' Infos utilisateur connecté
    Public UserID As Integer = 0
    Public UserNom As String = ""
    Public UserPrenom As String = ""
    Public UserEmail As String = ""
    Public UserRole As String = ""

    ' Constantes des rôles
    Public Const ROLE_DG As String = "directeur_general"
    Public Const ROLE_GERANT As String = "gerant"
    Public Const ROLE_SECRETAIRE As String = "secretaire"
    Public Const ROLE_AGENT As String = "agent_immobilier"

    ' Vérifier le rôle
    Public Function ARole(ParamArray roles() As String) As Boolean
        Return Array.IndexOf(roles, UserRole) >= 0
    End Function

    ' Réinitialiser la session
    Public Sub ResetSession()
        TokenJWT = ""
        UserID = 0
        UserNom = ""
        UserPrenom = ""
        UserEmail = ""
        UserRole = ""
    End Sub

    ' Nom complet
    Public ReadOnly Property NomComplet As String
        Get
            Return (UserPrenom & " " & UserNom).Trim()
        End Get
    End Property

    ' Label lisible du rôle
    Public ReadOnly Property LabelRole As String
        Get
            Select Case UserRole
                Case ROLE_DG : Return "Directeur Général"
                Case ROLE_GERANT : Return "Gérant"
                Case ROLE_SECRETAIRE : Return "Secrétaire"
                Case ROLE_AGENT : Return "Agent Immobilier"
                Case Else : Return UserRole
            End Select
        End Get
    End Property

End Module