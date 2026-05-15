<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLocataires
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbltitre = New System.Windows.Forms.Label()
        Me.btnExporter = New System.Windows.Forms.Button()
        Me.btnNouveauLoc = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlsep1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlinfo = New System.Windows.Forms.Panel()
        Me.lblinfodimunitif = New System.Windows.Forms.Label()
        Me.lblloc = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblTel1 = New System.Windows.Forms.Label()
        Me.lblMail1 = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblCNI1 = New System.Windows.Forms.Label()
        Me.lblCNI = New System.Windows.Forms.Label()
        Me.lblGerant = New System.Windows.Forms.Label()
        Me.lblGerant1 = New System.Windows.Forms.Label()
        Me.lblContratactif = New System.Windows.Forms.Label()
        Me.lblContratactif1 = New System.Windows.Forms.Label()
        Me.lblinscrit = New System.Windows.Forms.Label()
        Me.lblinscrit1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnVoirContrat = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtrech = New System.Windows.Forms.TextBox()
        Me.cmbFilitres1 = New System.Windows.Forms.ComboBox()
        Me.cmbFiltres2 = New System.Windows.Forms.ComboBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.dgvloc = New System.Windows.Forms.DataGridView()
        Me.colNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTelephone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProfession = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGerant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlinfo.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dgvloc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnNouveauLoc)
        Me.Panel1.Controls.Add(Me.btnExporter)
        Me.Panel1.Controls.Add(Me.lbltitre)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(933, 55)
        Me.Panel1.TabIndex = 0
        '
        'lbltitre
        '
        Me.lbltitre.AutoSize = True
        Me.lbltitre.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitre.ForeColor = System.Drawing.Color.White
        Me.lbltitre.Location = New System.Drawing.Point(18, 20)
        Me.lbltitre.Name = "lbltitre"
        Me.lbltitre.Size = New System.Drawing.Size(206, 18)
        Me.lbltitre.TabIndex = 0
        Me.lbltitre.Text = "Gestion des Locataires"
        '
        'btnExporter
        '
        Me.btnExporter.BackColor = System.Drawing.Color.Silver
        Me.btnExporter.FlatAppearance.BorderSize = 0
        Me.btnExporter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExporter.Location = New System.Drawing.Point(673, 15)
        Me.btnExporter.Name = "btnExporter"
        Me.btnExporter.Size = New System.Drawing.Size(75, 23)
        Me.btnExporter.TabIndex = 1
        Me.btnExporter.Text = "Exporter"
        Me.btnExporter.UseVisualStyleBackColor = False
        '
        'btnNouveauLoc
        '
        Me.btnNouveauLoc.BackColor = System.Drawing.Color.Gray
        Me.btnNouveauLoc.FlatAppearance.BorderSize = 0
        Me.btnNouveauLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNouveauLoc.Location = New System.Drawing.Point(768, 15)
        Me.btnNouveauLoc.Name = "btnNouveauLoc"
        Me.btnNouveauLoc.Size = New System.Drawing.Size(132, 23)
        Me.btnNouveauLoc.TabIndex = 2
        Me.btnNouveauLoc.Text = "+ Nouveau locataire"
        Me.btnNouveauLoc.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.btnSupprimer)
        Me.Panel2.Controls.Add(Me.btnModifier)
        Me.Panel2.Controls.Add(Me.btnVoirContrat)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.lblinscrit1)
        Me.Panel2.Controls.Add(Me.lblinscrit)
        Me.Panel2.Controls.Add(Me.lblContratactif1)
        Me.Panel2.Controls.Add(Me.lblContratactif)
        Me.Panel2.Controls.Add(Me.lblGerant1)
        Me.Panel2.Controls.Add(Me.lblGerant)
        Me.Panel2.Controls.Add(Me.lblCNI1)
        Me.Panel2.Controls.Add(Me.lblCNI)
        Me.Panel2.Controls.Add(Me.lblMail1)
        Me.Panel2.Controls.Add(Me.lblMail)
        Me.Panel2.Controls.Add(Me.lblTel1)
        Me.Panel2.Controls.Add(Me.lblTel)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lblloc)
        Me.Panel2.Controls.Add(Me.pnlinfo)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.pnlsep1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(663, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(270, 493)
        Me.Panel2.TabIndex = 1
        '
        'pnlsep1
        '
        Me.pnlsep1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlsep1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.pnlsep1.Location = New System.Drawing.Point(10, 44)
        Me.pnlsep1.Name = "pnlsep1"
        Me.pnlsep1.Size = New System.Drawing.Size(248, 1)
        Me.pnlsep1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Détail Locataire"
        '
        'pnlinfo
        '
        Me.pnlinfo.BackColor = System.Drawing.Color.Gray
        Me.pnlinfo.Controls.Add(Me.lblinfodimunitif)
        Me.pnlinfo.Location = New System.Drawing.Point(115, 50)
        Me.pnlinfo.Name = "pnlinfo"
        Me.pnlinfo.Size = New System.Drawing.Size(40, 38)
        Me.pnlinfo.TabIndex = 10
        '
        'lblinfodimunitif
        '
        Me.lblinfodimunitif.AutoSize = True
        Me.lblinfodimunitif.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinfodimunitif.ForeColor = System.Drawing.Color.White
        Me.lblinfodimunitif.Location = New System.Drawing.Point(6, 11)
        Me.lblinfodimunitif.Name = "lblinfodimunitif"
        Me.lblinfodimunitif.Size = New System.Drawing.Size(27, 16)
        Me.lblinfodimunitif.TabIndex = 10
        Me.lblinfodimunitif.Text = "AX"
        '
        'lblloc
        '
        Me.lblloc.AutoSize = True
        Me.lblloc.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblloc.ForeColor = System.Drawing.Color.White
        Me.lblloc.Location = New System.Drawing.Point(91, 91)
        Me.lblloc.Name = "lblloc"
        Me.lblloc.Size = New System.Drawing.Size(88, 13)
        Me.lblloc.TabIndex = 11
        Me.lblloc.Text = "Aissa Xavier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(94, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Commerçant"
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel.ForeColor = System.Drawing.Color.White
        Me.lblTel.Location = New System.Drawing.Point(7, 127)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(75, 13)
        Me.lblTel.TabIndex = 13
        Me.lblTel.Text = "Téléphone"
        '
        'lblTel1
        '
        Me.lblTel1.AutoSize = True
        Me.lblTel1.ForeColor = System.Drawing.Color.White
        Me.lblTel1.Location = New System.Drawing.Point(7, 145)
        Me.lblTel1.Name = "lblTel1"
        Me.lblTel1.Size = New System.Drawing.Size(107, 13)
        Me.lblTel1.TabIndex = 14
        Me.lblTel1.Text = "+2290100000000"
        '
        'lblMail1
        '
        Me.lblMail1.AutoSize = True
        Me.lblMail1.ForeColor = System.Drawing.Color.White
        Me.lblMail1.Location = New System.Drawing.Point(7, 185)
        Me.lblMail1.Name = "lblMail1"
        Me.lblMail1.Size = New System.Drawing.Size(105, 13)
        Me.lblMail1.TabIndex = 16
        Me.lblMail1.Text = "aissa@gmail.com"
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.ForeColor = System.Drawing.Color.White
        Me.lblMail.Location = New System.Drawing.Point(7, 167)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(47, 13)
        Me.lblMail.TabIndex = 15
        Me.lblMail.Text = "EMAIL"
        '
        'lblCNI1
        '
        Me.lblCNI1.AutoSize = True
        Me.lblCNI1.ForeColor = System.Drawing.Color.White
        Me.lblCNI1.Location = New System.Drawing.Point(7, 221)
        Me.lblCNI1.Name = "lblCNI1"
        Me.lblCNI1.Size = New System.Drawing.Size(67, 13)
        Me.lblCNI1.TabIndex = 18
        Me.lblCNI1.Text = "BJ-000234"
        '
        'lblCNI
        '
        Me.lblCNI.AutoSize = True
        Me.lblCNI.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCNI.ForeColor = System.Drawing.Color.White
        Me.lblCNI.Location = New System.Drawing.Point(7, 206)
        Me.lblCNI.Name = "lblCNI"
        Me.lblCNI.Size = New System.Drawing.Size(30, 13)
        Me.lblCNI.TabIndex = 17
        Me.lblCNI.Text = "CNI"
        '
        'lblGerant
        '
        Me.lblGerant.AutoSize = True
        Me.lblGerant.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGerant.ForeColor = System.Drawing.Color.White
        Me.lblGerant.Location = New System.Drawing.Point(7, 243)
        Me.lblGerant.Name = "lblGerant"
        Me.lblGerant.Size = New System.Drawing.Size(51, 13)
        Me.lblGerant.TabIndex = 19
        Me.lblGerant.Text = "Gérant"
        '
        'lblGerant1
        '
        Me.lblGerant1.AutoSize = True
        Me.lblGerant1.ForeColor = System.Drawing.Color.White
        Me.lblGerant1.Location = New System.Drawing.Point(7, 265)
        Me.lblGerant1.Name = "lblGerant1"
        Me.lblGerant1.Size = New System.Drawing.Size(199, 13)
        Me.lblGerant1.TabIndex = 20
        Me.lblGerant1.Text = "Serges Roland |+2290100000000"
        '
        'lblContratactif
        '
        Me.lblContratactif.AutoSize = True
        Me.lblContratactif.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContratactif.ForeColor = System.Drawing.Color.White
        Me.lblContratactif.Location = New System.Drawing.Point(7, 291)
        Me.lblContratactif.Name = "lblContratactif"
        Me.lblContratactif.Size = New System.Drawing.Size(109, 13)
        Me.lblContratactif.TabIndex = 21
        Me.lblContratactif.Text = "CONTRAT ACTIF"
        '
        'lblContratactif1
        '
        Me.lblContratactif1.AutoSize = True
        Me.lblContratactif1.ForeColor = System.Drawing.Color.White
        Me.lblContratactif1.Location = New System.Drawing.Point(7, 313)
        Me.lblContratactif1.Name = "lblContratactif1"
        Me.lblContratactif1.Size = New System.Drawing.Size(125, 13)
        Me.lblContratactif1.TabIndex = 22
        Me.lblContratactif1.Text = "oui - Villa Karakasse"
        '
        'lblinscrit
        '
        Me.lblinscrit.AutoSize = True
        Me.lblinscrit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinscrit.ForeColor = System.Drawing.Color.White
        Me.lblinscrit.Location = New System.Drawing.Point(7, 338)
        Me.lblinscrit.Name = "lblinscrit"
        Me.lblinscrit.Size = New System.Drawing.Size(79, 13)
        Me.lblinscrit.TabIndex = 23
        Me.lblinscrit.Text = "INSCRIT LE"
        '
        'lblinscrit1
        '
        Me.lblinscrit1.AutoSize = True
        Me.lblinscrit1.ForeColor = System.Drawing.Color.White
        Me.lblinscrit1.Location = New System.Drawing.Point(7, 360)
        Me.lblinscrit1.Name = "lblinscrit1"
        Me.lblinscrit1.Size = New System.Drawing.Size(59, 13)
        Me.lblinscrit1.TabIndex = 24
        Me.lblinscrit1.Text = "06/10/25"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel3.Location = New System.Drawing.Point(10, 390)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(248, 1)
        Me.Panel3.TabIndex = 25
        '
        'btnVoirContrat
        '
        Me.btnVoirContrat.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnVoirContrat.FlatAppearance.BorderSize = 0
        Me.btnVoirContrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoirContrat.ForeColor = System.Drawing.Color.White
        Me.btnVoirContrat.Location = New System.Drawing.Point(10, 426)
        Me.btnVoirContrat.Name = "btnVoirContrat"
        Me.btnVoirContrat.Size = New System.Drawing.Size(247, 23)
        Me.btnVoirContrat.TabIndex = 26
        Me.btnVoirContrat.Text = "Voir le contrat"
        Me.btnVoirContrat.UseVisualStyleBackColor = False
        '
        'btnModifier
        '
        Me.btnModifier.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnModifier.FlatAppearance.BorderSize = 0
        Me.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifier.ForeColor = System.Drawing.Color.White
        Me.btnModifier.Location = New System.Drawing.Point(10, 397)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(247, 23)
        Me.btnModifier.TabIndex = 27
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = False
        '
        'btnSupprimer
        '
        Me.btnSupprimer.BackColor = System.Drawing.Color.IndianRed
        Me.btnSupprimer.FlatAppearance.BorderSize = 0
        Me.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupprimer.ForeColor = System.Drawing.Color.White
        Me.btnSupprimer.Location = New System.Drawing.Point(10, 455)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(247, 23)
        Me.btnSupprimer.TabIndex = 28
        Me.btnSupprimer.Text = "Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Panel10)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.lbl1)
        Me.Panel4.Controls.Add(Me.cmbFiltres2)
        Me.Panel4.Controls.Add(Me.cmbFilitres1)
        Me.Panel4.Controls.Add(Me.txtrech)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 55)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(663, 45)
        Me.Panel4.TabIndex = 2
        '
        'txtrech
        '
        Me.txtrech.Location = New System.Drawing.Point(21, 9)
        Me.txtrech.Name = "txtrech"
        Me.txtrech.Size = New System.Drawing.Size(203, 21)
        Me.txtrech.TabIndex = 0
        '
        'cmbFilitres1
        '
        Me.cmbFilitres1.FormattingEnabled = True
        Me.cmbFilitres1.Location = New System.Drawing.Point(231, 9)
        Me.cmbFilitres1.Name = "cmbFilitres1"
        Me.cmbFilitres1.Size = New System.Drawing.Size(121, 21)
        Me.cmbFilitres1.TabIndex = 1
        '
        'cmbFiltres2
        '
        Me.cmbFiltres2.FormattingEnabled = True
        Me.cmbFiltres2.Location = New System.Drawing.Point(359, 9)
        Me.cmbFiltres2.Name = "cmbFiltres2"
        Me.cmbFiltres2.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltres2.TabIndex = 2
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(521, 17)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(52, 13)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "Total : "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(569, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(14, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "0"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(663, 1)
        Me.Panel5.TabIndex = 9
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Panel9)
        Me.Panel6.Controls.Add(Me.Label22)
        Me.Panel6.Controls.Add(Me.lbl4)
        Me.Panel6.Controls.Add(Me.Label20)
        Me.Panel6.Controls.Add(Me.lbl3)
        Me.Panel6.Controls.Add(Me.Label19)
        Me.Panel6.Controls.Add(Me.lbl2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.ForeColor = System.Drawing.Color.White
        Me.Panel6.Location = New System.Drawing.Point(0, 513)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(663, 35)
        Me.Panel6.TabIndex = 3
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(18, 13)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(52, 13)
        Me.lbl2.TabIndex = 0
        Me.lbl2.Text = "Total : "
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(66, 13)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 13)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(161, 13)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(14, 13)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "0"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(109, 13)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(56, 13)
        Me.lbl3.TabIndex = 2
        Me.lbl3.Text = "Actifs : "
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(280, 13)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(14, 13)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "0"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.Location = New System.Drawing.Point(214, 13)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(69, 13)
        Me.lbl4.TabIndex = 4
        Me.lbl4.Text = "Inactifs : "
        '
        'dgvloc
        '
        Me.dgvloc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvloc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNom, Me.colTelephone, Me.colCNI, Me.colProfession, Me.colGerant, Me.colStatut})
        Me.dgvloc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvloc.Location = New System.Drawing.Point(0, 100)
        Me.dgvloc.Name = "dgvloc"
        Me.dgvloc.Size = New System.Drawing.Size(663, 413)
        Me.dgvloc.TabIndex = 4
        '
        'colNom
        '
        Me.colNom.HeaderText = "Locataire"
        Me.colNom.Name = "colNom"
        Me.colNom.Width = 180
        '
        'colTelephone
        '
        Me.colTelephone.HeaderText = "Téléphone"
        Me.colTelephone.Name = "colTelephone"
        Me.colTelephone.Width = 130
        '
        'colCNI
        '
        Me.colCNI.HeaderText = "CNI"
        Me.colCNI.Name = "colCNI"
        '
        'colProfession
        '
        Me.colProfession.HeaderText = "Profession"
        Me.colProfession.Name = "colProfession"
        Me.colProfession.Width = 120
        '
        'colGerant
        '
        Me.colGerant.HeaderText = "Gérant"
        Me.colGerant.Name = "colGerant"
        Me.colGerant.Width = 130
        '
        'colStatut
        '
        Me.colStatut.HeaderText = "Statut"
        Me.colStatut.Name = "colStatut"
        Me.colStatut.Width = 80
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(270, 1)
        Me.Panel7.TabIndex = 29
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel8.Location = New System.Drawing.Point(662, 100)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1, 413)
        Me.Panel8.TabIndex = 9
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel9.Location = New System.Drawing.Point(662, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1, 35)
        Me.Panel9.TabIndex = 9
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel10.Location = New System.Drawing.Point(662, 1)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1, 44)
        Me.Panel10.TabIndex = 10
        '
        'FrmLocataires
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 548)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.dgvloc)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmLocataires"
        Me.Text = "FrmLocataires"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlinfo.ResumeLayout(False)
        Me.pnlinfo.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.dgvloc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbltitre As Label
    Friend WithEvents btnNouveauLoc As Button
    Friend WithEvents btnExporter As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlsep1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblloc As Label
    Friend WithEvents pnlinfo As Panel
    Friend WithEvents lblinfodimunitif As Label
    Friend WithEvents lblTel1 As Label
    Friend WithEvents lblTel As Label
    Friend WithEvents lblCNI1 As Label
    Friend WithEvents lblCNI As Label
    Friend WithEvents lblMail1 As Label
    Friend WithEvents lblMail As Label
    Friend WithEvents lblGerant1 As Label
    Friend WithEvents lblGerant As Label
    Friend WithEvents lblinscrit As Label
    Friend WithEvents lblContratactif1 As Label
    Friend WithEvents lblContratactif As Label
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnVoirContrat As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblinscrit1 As Label
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cmbFiltres2 As ComboBox
    Friend WithEvents cmbFilitres1 As ComboBox
    Friend WithEvents txtrech As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents dgvloc As DataGridView
    Friend WithEvents colNom As DataGridViewTextBoxColumn
    Friend WithEvents colTelephone As DataGridViewTextBoxColumn
    Friend WithEvents colCNI As DataGridViewTextBoxColumn
    Friend WithEvents colProfession As DataGridViewTextBoxColumn
    Friend WithEvents colGerant As DataGridViewTextBoxColumn
    Friend WithEvents colStatut As DataGridViewTextBoxColumn
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
End Class
