<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlGauche = New System.Windows.Forms.Panel()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.pnlsep = New System.Windows.Forms.Panel()
        Me.lblsoustitre = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbltitre = New System.Windows.Forms.Label()
        Me.pnlDroit = New System.Windows.Forms.Panel()
        Me.lblErrorMessage = New System.Windows.Forms.Label()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.btnSeconnecter = New System.Windows.Forms.Button()
        Me.cboxaffichage = New System.Windows.Forms.CheckBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.pnlGauche.SuspendLayout()
        Me.pnlDroit.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlGauche
        '
        Me.pnlGauche.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlGauche.Controls.Add(Me.lbl6)
        Me.pnlGauche.Controls.Add(Me.lbl4)
        Me.pnlGauche.Controls.Add(Me.pnlsep)
        Me.pnlGauche.Controls.Add(Me.lblsoustitre)
        Me.pnlGauche.Controls.Add(Me.lbl5)
        Me.pnlGauche.Controls.Add(Me.lbl3)
        Me.pnlGauche.Controls.Add(Me.lbl2)
        Me.pnlGauche.Controls.Add(Me.lbl1)
        Me.pnlGauche.Controls.Add(Me.lbltitre)
        Me.pnlGauche.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlGauche.Location = New System.Drawing.Point(0, 0)
        Me.pnlGauche.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlGauche.Name = "pnlGauche"
        Me.pnlGauche.Size = New System.Drawing.Size(414, 467)
        Me.pnlGauche.TabIndex = 0
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.Color.White
        Me.lbl6.Location = New System.Drawing.Point(36, 305)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(160, 13)
        Me.lbl6.TabIndex = 8
        Me.lbl6.Text = "Simple, rapide et sécurisé."
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.Gray
        Me.lbl4.Location = New System.Drawing.Point(140, 229)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(194, 35)
        Me.lbl4.TabIndex = 7
        Me.lbl4.Text = "paiements."
        '
        'pnlsep
        '
        Me.pnlsep.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlsep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlsep.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.pnlsep.Location = New System.Drawing.Point(12, 97)
        Me.pnlsep.Name = "pnlsep"
        Me.pnlsep.Size = New System.Drawing.Size(395, 1)
        Me.pnlsep.TabIndex = 6
        '
        'lblsoustitre
        '
        Me.lblsoustitre.AutoSize = True
        Me.lblsoustitre.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsoustitre.ForeColor = System.Drawing.Color.White
        Me.lblsoustitre.Location = New System.Drawing.Point(36, 71)
        Me.lblsoustitre.Name = "lblsoustitre"
        Me.lblsoustitre.Size = New System.Drawing.Size(142, 13)
        Me.lblsoustitre.TabIndex = 5
        Me.lblsoustitre.Text = "GESTION IMMOBILIÈRE"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.Color.White
        Me.lbl5.Location = New System.Drawing.Point(36, 281)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(288, 13)
        Me.lbl5.TabIndex = 4
        Me.lbl5.Text = "Platforme tout-en-un pour agences immobilières."
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.White
        Me.lbl3.Location = New System.Drawing.Point(33, 229)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(123, 35)
        Me.lbl3.TabIndex = 3
        Me.lbl3.Text = "et vos "
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(33, 186)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(239, 35)
        Me.lbl2.TabIndex = 2
        Me.lbl2.Text = "vos locataires"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(33, 137)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(301, 35)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "Gérez vos biens,  "
        '
        'lbltitre
        '
        Me.lbltitre.AutoSize = True
        Me.lbltitre.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitre.ForeColor = System.Drawing.Color.White
        Me.lbltitre.Location = New System.Drawing.Point(34, 31)
        Me.lbltitre.Name = "lbltitre"
        Me.lbltitre.Size = New System.Drawing.Size(105, 25)
        Me.lbltitre.TabIndex = 0
        Me.lbltitre.Text = "Lokatoo"
        '
        'pnlDroit
        '
        Me.pnlDroit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlDroit.Controls.Add(Me.lblErrorMessage)
        Me.pnlDroit.Controls.Add(Me.lbl10)
        Me.pnlDroit.Controls.Add(Me.lbl9)
        Me.pnlDroit.Controls.Add(Me.lbl11)
        Me.pnlDroit.Controls.Add(Me.btnSeconnecter)
        Me.pnlDroit.Controls.Add(Me.cboxaffichage)
        Me.pnlDroit.Controls.Add(Me.txtPassword)
        Me.pnlDroit.Controls.Add(Me.txtEmail)
        Me.pnlDroit.Controls.Add(Me.lbl8)
        Me.pnlDroit.Controls.Add(Me.lbl7)
        Me.pnlDroit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDroit.Location = New System.Drawing.Point(414, 0)
        Me.pnlDroit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlDroit.Name = "pnlDroit"
        Me.pnlDroit.Size = New System.Drawing.Size(454, 467)
        Me.pnlDroit.TabIndex = 1
        '
        'lblErrorMessage
        '
        Me.lblErrorMessage.AutoSize = True
        Me.lblErrorMessage.Location = New System.Drawing.Point(39, 195)
        Me.lblErrorMessage.Name = "lblErrorMessage"
        Me.lblErrorMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblErrorMessage.TabIndex = 14
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        Me.lbl10.ForeColor = System.Drawing.Color.White
        Me.lbl10.Location = New System.Drawing.Point(47, 268)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(82, 13)
        Me.lbl10.TabIndex = 13
        Me.lbl10.Text = "Mot de passe"
        '
        'lbl9
        '
        Me.lbl9.AutoSize = True
        Me.lbl9.ForeColor = System.Drawing.Color.White
        Me.lbl9.Location = New System.Drawing.Point(47, 225)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(38, 13)
        Me.lbl9.TabIndex = 12
        Me.lbl9.Text = "Email"
        '
        'lbl11
        '
        Me.lbl11.AutoSize = True
        Me.lbl11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl11.ForeColor = System.Drawing.Color.White
        Me.lbl11.Location = New System.Drawing.Point(137, 413)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(183, 13)
        Me.lbl11.TabIndex = 11
        Me.lbl11.Text = "©  2026 - Gestion Immobilière"
        '
        'btnSeconnecter
        '
        Me.btnSeconnecter.BackColor = System.Drawing.Color.Gray
        Me.btnSeconnecter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeconnecter.FlatAppearance.BorderSize = 0
        Me.btnSeconnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeconnecter.ForeColor = System.Drawing.Color.White
        Me.btnSeconnecter.Location = New System.Drawing.Point(47, 353)
        Me.btnSeconnecter.Name = "btnSeconnecter"
        Me.btnSeconnecter.Size = New System.Drawing.Size(361, 38)
        Me.btnSeconnecter.TabIndex = 9
        Me.btnSeconnecter.Text = "Se connecter"
        Me.btnSeconnecter.UseVisualStyleBackColor = False
        '
        'cboxaffichage
        '
        Me.cboxaffichage.AutoSize = True
        Me.cboxaffichage.ForeColor = System.Drawing.Color.White
        Me.cboxaffichage.Location = New System.Drawing.Point(47, 317)
        Me.cboxaffichage.Name = "cboxaffichage"
        Me.cboxaffichage.Size = New System.Drawing.Size(149, 17)
        Me.cboxaffichage.TabIndex = 8
        Me.cboxaffichage.Text = "Afficher Mot de passe"
        Me.cboxaffichage.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(47, 284)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(361, 21)
        Me.txtPassword.TabIndex = 7
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(47, 241)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(361, 21)
        Me.txtEmail.TabIndex = 6
        '
        'lbl8
        '
        Me.lbl8.AutoSize = True
        Me.lbl8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl8.ForeColor = System.Drawing.Color.White
        Me.lbl8.Location = New System.Drawing.Point(44, 169)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(255, 13)
        Me.lbl8.TabIndex = 5
        Me.lbl8.Text = "Connectez-vous à votre espace de gestion."
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.ForeColor = System.Drawing.Color.White
        Me.lbl7.Location = New System.Drawing.Point(44, 137)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(124, 18)
        Me.lbl7.TabIndex = 2
        Me.lbl7.Text = "Bienvenue 👋🏾"
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 467)
        Me.Controls.Add(Me.pnlDroit)
        Me.Controls.Add(Me.pnlGauche)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lokatoo - Connexion"
        Me.pnlGauche.ResumeLayout(False)
        Me.pnlGauche.PerformLayout()
        Me.pnlDroit.ResumeLayout(False)
        Me.pnlDroit.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlGauche As Panel
    Friend WithEvents pnlDroit As Panel
    Friend WithEvents lbltitre As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl7 As Label
    Friend WithEvents cboxaffichage As CheckBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lbl8 As Label
    Friend WithEvents btnSeconnecter As Button
    Friend WithEvents pnlsep As Panel
    Friend WithEvents lblsoustitre As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents lbl11 As Label
    Friend WithEvents lbl9 As Label
    Friend WithEvents lbl10 As Label
    Friend WithEvents lblErrorMessage As Label
End Class
