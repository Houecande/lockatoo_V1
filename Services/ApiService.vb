' ============================================================
'  Services/ApiService.vb
'  Appels HTTP vers l'API PHP — .NET Framework 4.x
'  NuGet requis : Newtonsoft.Json
' ============================================================
Imports System.Net
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Module ApiService

    ' ── Construire URL complète ─────────────────────────────
    Private Function Url(endpoint As String) As String
        Return AppConfig.API_BASE_URL & "/" & endpoint
    End Function

    ' ── Requête HTTP générique ──────────────────────────────
    Private Function Requete(methode As String, endpoint As String,
                              Optional data As Object = Nothing) As JObject
        Try
            Dim req As HttpWebRequest = DirectCast(WebRequest.Create(Url(endpoint)), HttpWebRequest)
            req.Method = methode
            req.ContentType = "application/json"
            req.Timeout = 15000

            ' Ajouter token JWT si disponible
            If Not String.IsNullOrEmpty(AppConfig.TokenJWT) Then
                req.Headers.Add("Authorization", "Bearer " & AppConfig.TokenJWT)
            End If

            ' Envoyer le body JSON si nécessaire
            If data IsNot Nothing Then
                Dim json As String = JsonConvert.SerializeObject(data)
                Dim bytes As Byte() = Encoding.UTF8.GetBytes(json)
                req.ContentLength = bytes.Length
                Using stream = req.GetRequestStream()
                    stream.Write(bytes, 0, bytes.Length)
                End Using
            Else
                req.ContentLength = 0
            End If

            ' Lire la réponse
            Using resp As HttpWebResponse = DirectCast(req.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(resp.GetResponseStream(), Encoding.UTF8)
                    Return JObject.Parse(reader.ReadToEnd())
                End Using
            End Using

        Catch ex As WebException
            ' Lire le corps de l'erreur HTTP (400, 401, etc.)
            If ex.Response IsNot Nothing Then
                Using reader As New StreamReader(ex.Response.GetResponseStream(), Encoding.UTF8)
                    Try
                        Return JObject.Parse(reader.ReadToEnd())
                    Catch
                        Return ErreurJson("Erreur HTTP : " & ex.Message)
                    End Try
                End Using
            End If
            Return ErreurJson("Erreur réseau : " & ex.Message)
        Catch ex As Exception
            Return ErreurJson("Erreur : " & ex.Message)
        End Try
    End Function

    ' ── Réponse d'erreur standard ───────────────────────────
    Private Function ErreurJson(message As String) As JObject
        Return JObject.Parse("{""success"":false,""message"":""" & message & """,""data"":null}")
    End Function

    ' ============================================================
    '  ENDPOINTS
    ' ============================================================

    ' AUTH
    Public Function Login(email As String, motDePasse As String) As JObject
        Return Requete("POST", "auth.php", New With {
            .email = email,
            .mot_de_passe = motDePasse
        })
    End Function

    ' DASHBOARD
    Public Function GetDashboard() As JObject
        Return Requete("GET", "dashboard.php")
    End Function

    ' LOCATAIRES
    Public Function GetLocataires() As JObject
        Return Requete("GET", "locataires.php")
    End Function

    Public Function CreerLocataire(data As Object) As JObject
        Return Requete("POST", "locataires.php", data)
    End Function

    Public Function ModifierLocataire(id As Integer, data As Object) As JObject
        Return Requete("PUT", "locataires.php?id=" & id, data)
    End Function

    Public Function SupprimerLocataire(id As Integer) As JObject
        Return Requete("DELETE", "locataires.php?id=" & id)
    End Function

    ' BIENS
    Public Function GetBiens() As JObject
        Return Requete("GET", "biens.php")
    End Function

    Public Function CreerBien(data As Object) As JObject
        Return Requete("POST", "biens.php", data)
    End Function

    Public Function ModifierBien(id As Integer, data As Object) As JObject
        Return Requete("PUT", "biens.php?id=" & id, data)
    End Function

    ' CONTRATS
    Public Function GetContrats() As JObject
        Return Requete("GET", "contrats.php")
    End Function

    Public Function CreerContrat(data As Object) As JObject
        Return Requete("POST", "contrats.php", data)
    End Function

    ' PAIEMENTS
    Public Function GetPaiements(Optional contratId As Integer = 0) As JObject
        Dim ep = If(contratId > 0, "paiements.php?contrat_id=" & contratId, "paiements.php")
        Return Requete("GET", ep)
    End Function

    Public Function EnregistrerPaiement(data As Object) As JObject
        Return Requete("POST", "paiements.php", data)
    End Function

    ' BAILLEURS
    Public Function GetBailleurs() As JObject
        Return Requete("GET", "bailleurs.php")
    End Function

    Public Function CreerBailleur(data As Object) As JObject
        Return Requete("POST", "bailleurs.php", data)
    End Function

    ' DÉCAISSEMENTS
    Public Function GetDecaissements() As JObject
        Return Requete("GET", "decaissement.php")
    End Function

    Public Function ValiderDecaissement(id As Integer) As JObject
        Return Requete("POST", "decaissement.php?action=valider&id=" & id,
                       New With {.id = id})
    End Function

    ' IMPAYÉS
    Public Function GetImpayes() As JObject
        Return Requete("GET", "impayes.php")
    End Function

End Module