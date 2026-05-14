<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDashboard
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnDeconnexion = New System.Windows.Forms.Button()
        Me.btnNotification = New System.Windows.Forms.Button()
        Me.btnPaiements = New System.Windows.Forms.Button()
        Me.btnContrats = New System.Windows.Forms.Button()
        Me.btnLacataires = New System.Windows.Forms.Button()
        Me.btnBien = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.pnltitre = New System.Windows.Forms.Panel()
        Me.lbltitre = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.pnlstat = New System.Windows.Forms.Panel()
        Me.pnlstat1 = New System.Windows.Forms.Panel()
        Me.pnlstat2 = New System.Windows.Forms.Panel()
        Me.pnlstat3 = New System.Windows.Forms.Panel()
        Me.pnlstat4 = New System.Windows.Forms.Panel()
        Me.pnlsep1 = New System.Windows.Forms.Panel()
        Me.lblsep2 = New System.Windows.Forms.Panel()
        Me.pnlinfo = New System.Windows.Forms.Panel()
        Me.lblinfodimunitif = New System.Windows.Forms.Label()
        Me.lblinfopconnect = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlgrille = New System.Windows.Forms.Panel()
        Me.pnlinfog1 = New System.Windows.Forms.Panel()
        Me.pnlinfog2 = New System.Windows.Forms.Panel()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.dgvStat1 = New System.Windows.Forms.DataGridView()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.dgvStat2 = New System.Windows.Forms.DataGridView()
        Me.btnBailleurs = New System.Windows.Forms.Button()
        Me.btnDécaissements = New System.Windows.Forms.Button()
        Me.btnEtatdesLieux = New System.Windows.Forms.Button()
        Me.btnResiliation = New System.Windows.Forms.Button()
        Me.btnPersonnel = New System.Windows.Forms.Button()
        Me.clLocataire = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clMontant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clMode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clStatut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clAdresse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clLoyer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clQuartier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.lblstat1 = New System.Windows.Forms.Label()
        Me.lblstat2 = New System.Windows.Forms.Label()
        Me.lblstat3 = New System.Windows.Forms.Label()
        Me.lblstat4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnltitre.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlstat.SuspendLayout()
        Me.pnlstat1.SuspendLayout()
        Me.pnlstat2.SuspendLayout()
        Me.pnlstat3.SuspendLayout()
        Me.pnlstat4.SuspendLayout()
        Me.pnlinfo.SuspendLayout()
        Me.pnlgrille.SuspendLayout()
        Me.pnlinfog1.SuspendLayout()
        Me.pnlinfog2.SuspendLayout()
        CType(Me.dgvStat1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStat2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.pnltitre)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(191, 668)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnPersonnel)
        Me.Panel4.Controls.Add(Me.btnResiliation)
        Me.Panel4.Controls.Add(Me.btnEtatdesLieux)
        Me.Panel4.Controls.Add(Me.btnDécaissements)
        Me.Panel4.Controls.Add(Me.btnBailleurs)
        Me.Panel4.Controls.Add(Me.pnlinfo)
        Me.Panel4.Controls.Add(Me.lblinfopconnect)
        Me.Panel4.Controls.Add(Me.lblsep2)
        Me.Panel4.Controls.Add(Me.pnlsep1)
        Me.Panel4.Controls.Add(Me.btnDeconnexion)
        Me.Panel4.Controls.Add(Me.btnNotification)
        Me.Panel4.Controls.Add(Me.btnPaiements)
        Me.Panel4.Controls.Add(Me.btnContrats)
        Me.Panel4.Controls.Add(Me.btnLacataires)
        Me.Panel4.Controls.Add(Me.btnBien)
        Me.Panel4.Controls.Add(Me.btnDashboard)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 63)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(191, 605)
        Me.Panel4.TabIndex = 3
        '
        'btnDeconnexion
        '
        Me.btnDeconnexion.BackColor = System.Drawing.Color.Red
        Me.btnDeconnexion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeconnexion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnDeconnexion.FlatAppearance.BorderSize = 0
        Me.btnDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeconnexion.ForeColor = System.Drawing.Color.White
        Me.btnDeconnexion.Location = New System.Drawing.Point(0, 567)
        Me.btnDeconnexion.Name = "btnDeconnexion"
        Me.btnDeconnexion.Size = New System.Drawing.Size(191, 38)
        Me.btnDeconnexion.TabIndex = 7
        Me.btnDeconnexion.Text = "Deconnexion ↪"
        Me.btnDeconnexion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeconnexion.UseVisualStyleBackColor = False
        '
        'btnNotification
        '
        Me.btnNotification.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnNotification.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotification.FlatAppearance.BorderSize = 0
        Me.btnNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotification.ForeColor = System.Drawing.Color.White
        Me.btnNotification.Location = New System.Drawing.Point(1, 259)
        Me.btnNotification.Name = "btnNotification"
        Me.btnNotification.Size = New System.Drawing.Size(191, 38)
        Me.btnNotification.TabIndex = 6
        Me.btnNotification.Text = "Notification"
        Me.btnNotification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotification.UseVisualStyleBackColor = False
        '
        'btnPaiements
        '
        Me.btnPaiements.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPaiements.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPaiements.FlatAppearance.BorderSize = 0
        Me.btnPaiements.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaiements.ForeColor = System.Drawing.Color.White
        Me.btnPaiements.Location = New System.Drawing.Point(0, 217)
        Me.btnPaiements.Name = "btnPaiements"
        Me.btnPaiements.Size = New System.Drawing.Size(191, 38)
        Me.btnPaiements.TabIndex = 5
        Me.btnPaiements.Text = "Paiements"
        Me.btnPaiements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPaiements.UseVisualStyleBackColor = False
        '
        'btnContrats
        '
        Me.btnContrats.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnContrats.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnContrats.FlatAppearance.BorderSize = 0
        Me.btnContrats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContrats.ForeColor = System.Drawing.Color.White
        Me.btnContrats.Location = New System.Drawing.Point(-1, 176)
        Me.btnContrats.Name = "btnContrats"
        Me.btnContrats.Size = New System.Drawing.Size(191, 38)
        Me.btnContrats.TabIndex = 4
        Me.btnContrats.Text = "Contrats"
        Me.btnContrats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContrats.UseVisualStyleBackColor = False
        '
        'btnLacataires
        '
        Me.btnLacataires.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnLacataires.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLacataires.FlatAppearance.BorderSize = 0
        Me.btnLacataires.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLacataires.ForeColor = System.Drawing.Color.White
        Me.btnLacataires.Location = New System.Drawing.Point(0, 135)
        Me.btnLacataires.Name = "btnLacataires"
        Me.btnLacataires.Size = New System.Drawing.Size(191, 38)
        Me.btnLacataires.TabIndex = 3
        Me.btnLacataires.Text = "Locataires"
        Me.btnLacataires.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLacataires.UseVisualStyleBackColor = False
        '
        'btnBien
        '
        Me.btnBien.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnBien.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBien.FlatAppearance.BorderSize = 0
        Me.btnBien.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBien.ForeColor = System.Drawing.Color.White
        Me.btnBien.Location = New System.Drawing.Point(0, 97)
        Me.btnBien.Name = "btnBien"
        Me.btnBien.Size = New System.Drawing.Size(191, 38)
        Me.btnBien.TabIndex = 2
        Me.btnBien.Text = "Bien"
        Me.btnBien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBien.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Location = New System.Drawing.Point(0, 53)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(191, 38)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "Tableau de bord"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'pnltitre
        '
        Me.pnltitre.Controls.Add(Me.lbltitre)
        Me.pnltitre.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnltitre.Location = New System.Drawing.Point(0, 0)
        Me.pnltitre.Name = "pnltitre"
        Me.pnltitre.Size = New System.Drawing.Size(191, 63)
        Me.pnltitre.TabIndex = 2
        '
        'lbltitre
        '
        Me.lbltitre.AutoSize = True
        Me.lbltitre.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitre.ForeColor = System.Drawing.Color.White
        Me.lbltitre.Location = New System.Drawing.Point(34, 20)
        Me.lbltitre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltitre.Name = "lbltitre"
        Me.lbltitre.Size = New System.Drawing.Size(105, 25)
        Me.lbltitre.TabIndex = 0
        Me.lbltitre.Text = "Lokatoo"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.pnlgrille)
        Me.Panel2.Controls.Add(Me.pnlstat)
        Me.Panel2.Controls.Add(Me.lbl3)
        Me.Panel2.Controls.Add(Me.lbl2)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(191, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(864, 668)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lbl1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(864, 63)
        Me.Panel3.TabIndex = 0
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(18, 20)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(163, 18)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Tableau de board"
        '
        'pnlstat
        '
        Me.pnlstat.Controls.Add(Me.pnlstat4)
        Me.pnlstat.Controls.Add(Me.pnlstat3)
        Me.pnlstat.Controls.Add(Me.pnlstat2)
        Me.pnlstat.Controls.Add(Me.pnlstat1)
        Me.pnlstat.Location = New System.Drawing.Point(21, 145)
        Me.pnlstat.Name = "pnlstat"
        Me.pnlstat.Size = New System.Drawing.Size(822, 162)
        Me.pnlstat.TabIndex = 3
        '
        'pnlstat1
        '
        Me.pnlstat1.BackColor = System.Drawing.Color.Gray
        Me.pnlstat1.Controls.Add(Me.lblstat1)
        Me.pnlstat1.Controls.Add(Me.lbl4)
        Me.pnlstat1.Controls.Add(Me.FlowLayoutPanel2)
        Me.pnlstat1.Location = New System.Drawing.Point(36, 31)
        Me.pnlstat1.Name = "pnlstat1"
        Me.pnlstat1.Size = New System.Drawing.Size(160, 100)
        Me.pnlstat1.TabIndex = 0
        '
        'pnlstat2
        '
        Me.pnlstat2.BackColor = System.Drawing.Color.Gray
        Me.pnlstat2.Controls.Add(Me.lblstat2)
        Me.pnlstat2.Controls.Add(Me.lbl5)
        Me.pnlstat2.Controls.Add(Me.FlowLayoutPanel3)
        Me.pnlstat2.Location = New System.Drawing.Point(232, 31)
        Me.pnlstat2.Name = "pnlstat2"
        Me.pnlstat2.Size = New System.Drawing.Size(160, 100)
        Me.pnlstat2.TabIndex = 1
        '
        'pnlstat3
        '
        Me.pnlstat3.BackColor = System.Drawing.Color.Gray
        Me.pnlstat3.Controls.Add(Me.lblstat3)
        Me.pnlstat3.Controls.Add(Me.lbl6)
        Me.pnlstat3.Controls.Add(Me.FlowLayoutPanel4)
        Me.pnlstat3.Location = New System.Drawing.Point(428, 31)
        Me.pnlstat3.Name = "pnlstat3"
        Me.pnlstat3.Size = New System.Drawing.Size(160, 100)
        Me.pnlstat3.TabIndex = 1
        '
        'pnlstat4
        '
        Me.pnlstat4.BackColor = System.Drawing.Color.Gray
        Me.pnlstat4.Controls.Add(Me.lblstat4)
        Me.pnlstat4.Controls.Add(Me.lbl7)
        Me.pnlstat4.Controls.Add(Me.FlowLayoutPanel5)
        Me.pnlstat4.Location = New System.Drawing.Point(624, 31)
        Me.pnlstat4.Name = "pnlstat4"
        Me.pnlstat4.Size = New System.Drawing.Size(160, 100)
        Me.pnlstat4.TabIndex = 1
        '
        'pnlsep1
        '
        Me.pnlsep1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlsep1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlsep1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.pnlsep1.Location = New System.Drawing.Point(0, 0)
        Me.pnlsep1.Name = "pnlsep1"
        Me.pnlsep1.Size = New System.Drawing.Size(191, 1)
        Me.pnlsep1.TabIndex = 7
        '
        'lblsep2
        '
        Me.lblsep2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblsep2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblsep2.Location = New System.Drawing.Point(0, 51)
        Me.lblsep2.Name = "lblsep2"
        Me.lblsep2.Size = New System.Drawing.Size(191, 1)
        Me.lblsep2.TabIndex = 8
        '
        'pnlinfo
        '
        Me.pnlinfo.BackColor = System.Drawing.Color.Gray
        Me.pnlinfo.Controls.Add(Me.lblinfodimunitif)
        Me.pnlinfo.Location = New System.Drawing.Point(3, 6)
        Me.pnlinfo.Name = "pnlinfo"
        Me.pnlinfo.Size = New System.Drawing.Size(40, 38)
        Me.pnlinfo.TabIndex = 9
        '
        'lblinfodimunitif
        '
        Me.lblinfodimunitif.AutoSize = True
        Me.lblinfodimunitif.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinfodimunitif.ForeColor = System.Drawing.Color.White
        Me.lblinfodimunitif.Location = New System.Drawing.Point(6, 10)
        Me.lblinfodimunitif.Name = "lblinfodimunitif"
        Me.lblinfodimunitif.Size = New System.Drawing.Size(27, 16)
        Me.lblinfodimunitif.TabIndex = 10
        Me.lblinfodimunitif.Text = "DG"
        '
        'lblinfopconnect
        '
        Me.lblinfopconnect.AutoSize = True
        Me.lblinfopconnect.ForeColor = System.Drawing.Color.White
        Me.lblinfopconnect.Location = New System.Drawing.Point(51, 17)
        Me.lblinfopconnect.Name = "lblinfopconnect"
        Me.lblinfopconnect.Size = New System.Drawing.Size(109, 13)
        Me.lblinfopconnect.TabIndex = 10
        Me.lblinfopconnect.Text = "Directeur Général"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(55, 82)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(124, 18)
        Me.lbl2.TabIndex = 1
        Me.lbl2.Text = "Bienvenue 👋🏾"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.White
        Me.lbl3.Location = New System.Drawing.Point(55, 107)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(231, 13)
        Me.lbl3.TabIndex = 2
        Me.lbl3.Text = "Voici le résumé de l'agence aujourd'hui"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(160, 6)
        Me.FlowLayoutPanel2.TabIndex = 13
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(160, 6)
        Me.FlowLayoutPanel3.TabIndex = 14
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(160, 6)
        Me.FlowLayoutPanel4.TabIndex = 14
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FlowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(160, 6)
        Me.FlowLayoutPanel5.TabIndex = 14
        '
        'pnlgrille
        '
        Me.pnlgrille.Controls.Add(Me.pnlinfog2)
        Me.pnlgrille.Controls.Add(Me.pnlinfog1)
        Me.pnlgrille.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlgrille.Location = New System.Drawing.Point(0, 373)
        Me.pnlgrille.Name = "pnlgrille"
        Me.pnlgrille.Size = New System.Drawing.Size(864, 295)
        Me.pnlgrille.TabIndex = 4
        '
        'pnlinfog1
        '
        Me.pnlinfog1.BackColor = System.Drawing.Color.Gray
        Me.pnlinfog1.Controls.Add(Me.dgvStat1)
        Me.pnlinfog1.Controls.Add(Me.lbl8)
        Me.pnlinfog1.ForeColor = System.Drawing.Color.White
        Me.pnlinfog1.Location = New System.Drawing.Point(57, 3)
        Me.pnlinfog1.Name = "pnlinfog1"
        Me.pnlinfog1.Size = New System.Drawing.Size(356, 280)
        Me.pnlinfog1.TabIndex = 0
        '
        'pnlinfog2
        '
        Me.pnlinfog2.BackColor = System.Drawing.Color.Gray
        Me.pnlinfog2.Controls.Add(Me.dgvStat2)
        Me.pnlinfog2.Controls.Add(Me.lbl9)
        Me.pnlinfog2.Location = New System.Drawing.Point(449, 3)
        Me.pnlinfog2.Name = "pnlinfog2"
        Me.pnlinfog2.Size = New System.Drawing.Size(365, 280)
        Me.pnlinfog2.TabIndex = 1
        '
        'lbl8
        '
        Me.lbl8.AutoSize = True
        Me.lbl8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl8.ForeColor = System.Drawing.Color.White
        Me.lbl8.Location = New System.Drawing.Point(3, 12)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(128, 13)
        Me.lbl8.TabIndex = 2
        Me.lbl8.Text = "Paiements récents"
        '
        'dgvStat1
        '
        Me.dgvStat1.AllowUserToAddRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvStat1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStat1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStat1.BackgroundColor = System.Drawing.Color.Gray
        Me.dgvStat1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvStat1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStat1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clLocataire, Me.clMontant, Me.clMode, Me.clDate, Me.clStatut})
        Me.dgvStat1.GridColor = System.Drawing.Color.LightGray
        Me.dgvStat1.Location = New System.Drawing.Point(5, 28)
        Me.dgvStat1.Name = "dgvStat1"
        Me.dgvStat1.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStat1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Azure
        Me.dgvStat1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvStat1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStat1.Size = New System.Drawing.Size(347, 249)
        Me.dgvStat1.TabIndex = 3
        '
        'lbl9
        '
        Me.lbl9.AutoSize = True
        Me.lbl9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl9.ForeColor = System.Drawing.Color.White
        Me.lbl9.Location = New System.Drawing.Point(3, 12)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(120, 13)
        Me.lbl9.TabIndex = 3
        Me.lbl9.Text = "Biens disponibles"
        '
        'dgvStat2
        '
        Me.dgvStat2.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvStat2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStat2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStat2.BackgroundColor = System.Drawing.Color.Gray
        Me.dgvStat2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvStat2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStat2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clAdresse, Me.clType, Me.clLoyer, Me.clQuartier})
        Me.dgvStat2.GridColor = System.Drawing.Color.LightGray
        Me.dgvStat2.Location = New System.Drawing.Point(5, 28)
        Me.dgvStat2.Name = "dgvStat2"
        Me.dgvStat2.ReadOnly = True
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure
        Me.dgvStat2.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStat2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStat2.Size = New System.Drawing.Size(351, 249)
        Me.dgvStat2.TabIndex = 4
        '
        'btnBailleurs
        '
        Me.btnBailleurs.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnBailleurs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBailleurs.FlatAppearance.BorderSize = 0
        Me.btnBailleurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBailleurs.ForeColor = System.Drawing.Color.White
        Me.btnBailleurs.Location = New System.Drawing.Point(0, 303)
        Me.btnBailleurs.Name = "btnBailleurs"
        Me.btnBailleurs.Size = New System.Drawing.Size(191, 38)
        Me.btnBailleurs.TabIndex = 11
        Me.btnBailleurs.Text = "Bailleurs"
        Me.btnBailleurs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBailleurs.UseVisualStyleBackColor = False
        '
        'btnDécaissements
        '
        Me.btnDécaissements.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnDécaissements.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDécaissements.FlatAppearance.BorderSize = 0
        Me.btnDécaissements.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDécaissements.ForeColor = System.Drawing.Color.White
        Me.btnDécaissements.Location = New System.Drawing.Point(0, 347)
        Me.btnDécaissements.Name = "btnDécaissements"
        Me.btnDécaissements.Size = New System.Drawing.Size(191, 38)
        Me.btnDécaissements.TabIndex = 12
        Me.btnDécaissements.Text = "Décaissements"
        Me.btnDécaissements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDécaissements.UseVisualStyleBackColor = False
        '
        'btnEtatdesLieux
        '
        Me.btnEtatdesLieux.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEtatdesLieux.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEtatdesLieux.FlatAppearance.BorderSize = 0
        Me.btnEtatdesLieux.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEtatdesLieux.ForeColor = System.Drawing.Color.White
        Me.btnEtatdesLieux.Location = New System.Drawing.Point(-3, 391)
        Me.btnEtatdesLieux.Name = "btnEtatdesLieux"
        Me.btnEtatdesLieux.Size = New System.Drawing.Size(191, 38)
        Me.btnEtatdesLieux.TabIndex = 13
        Me.btnEtatdesLieux.Text = "États des lieux"
        Me.btnEtatdesLieux.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEtatdesLieux.UseVisualStyleBackColor = False
        '
        'btnResiliation
        '
        Me.btnResiliation.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnResiliation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResiliation.FlatAppearance.BorderSize = 0
        Me.btnResiliation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResiliation.ForeColor = System.Drawing.Color.White
        Me.btnResiliation.Location = New System.Drawing.Point(0, 435)
        Me.btnResiliation.Name = "btnResiliation"
        Me.btnResiliation.Size = New System.Drawing.Size(191, 38)
        Me.btnResiliation.TabIndex = 14
        Me.btnResiliation.Text = "Résiliations"
        Me.btnResiliation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResiliation.UseVisualStyleBackColor = False
        '
        'btnPersonnel
        '
        Me.btnPersonnel.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPersonnel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPersonnel.FlatAppearance.BorderSize = 0
        Me.btnPersonnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPersonnel.ForeColor = System.Drawing.Color.White
        Me.btnPersonnel.Location = New System.Drawing.Point(0, 479)
        Me.btnPersonnel.Name = "btnPersonnel"
        Me.btnPersonnel.Size = New System.Drawing.Size(191, 38)
        Me.btnPersonnel.TabIndex = 15
        Me.btnPersonnel.Text = "Personnel"
        Me.btnPersonnel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPersonnel.UseVisualStyleBackColor = False
        '
        'clLocataire
        '
        Me.clLocataire.HeaderText = "Locataire"
        Me.clLocataire.Name = "clLocataire"
        Me.clLocataire.ReadOnly = True
        '
        'clMontant
        '
        Me.clMontant.HeaderText = "Montant"
        Me.clMontant.Name = "clMontant"
        Me.clMontant.ReadOnly = True
        '
        'clMode
        '
        Me.clMode.HeaderText = "Mode"
        Me.clMode.Name = "clMode"
        Me.clMode.ReadOnly = True
        '
        'clDate
        '
        Me.clDate.HeaderText = "Date"
        Me.clDate.Name = "clDate"
        Me.clDate.ReadOnly = True
        '
        'clStatut
        '
        Me.clStatut.HeaderText = "Statut"
        Me.clStatut.Name = "clStatut"
        Me.clStatut.ReadOnly = True
        '
        'clAdresse
        '
        Me.clAdresse.HeaderText = "Adresse"
        Me.clAdresse.Name = "clAdresse"
        Me.clAdresse.ReadOnly = True
        '
        'clType
        '
        Me.clType.HeaderText = "Type"
        Me.clType.Name = "clType"
        Me.clType.ReadOnly = True
        '
        'clLoyer
        '
        Me.clLoyer.HeaderText = "Loyer"
        Me.clLoyer.Name = "clLoyer"
        Me.clLoyer.ReadOnly = True
        '
        'clQuartier
        '
        Me.clQuartier.HeaderText = "Quartier"
        Me.clQuartier.Name = "clQuartier"
        Me.clQuartier.ReadOnly = True
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.White
        Me.lbl4.Location = New System.Drawing.Point(3, 9)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(75, 13)
        Me.lbl4.TabIndex = 14
        Me.lbl4.Text = "Locataires"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.Color.White
        Me.lbl5.Location = New System.Drawing.Point(3, 9)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(83, 13)
        Me.lbl5.TabIndex = 15
        Me.lbl5.Text = "Biens libres"
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.Color.White
        Me.lbl6.Location = New System.Drawing.Point(3, 9)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(102, 13)
        Me.lbl6.TabIndex = 15
        Me.lbl6.Text = "Contrats actifs"
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.ForeColor = System.Drawing.Color.White
        Me.lbl7.Location = New System.Drawing.Point(3, 9)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(130, 13)
        Me.lbl7.TabIndex = 15
        Me.lbl7.Text = "Paiements du mois"
        '
        'lblstat1
        '
        Me.lblstat1.Font = New System.Drawing.Font("Verdana", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstat1.Location = New System.Drawing.Point(50, 40)
        Me.lblstat1.Name = "lblstat1"
        Me.lblstat1.Size = New System.Drawing.Size(51, 44)
        Me.lblstat1.TabIndex = 15
        Me.lblstat1.Text = "0"
        Me.lblstat1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblstat2
        '
        Me.lblstat2.Font = New System.Drawing.Font("Verdana", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstat2.Location = New System.Drawing.Point(50, 40)
        Me.lblstat2.Name = "lblstat2"
        Me.lblstat2.Size = New System.Drawing.Size(51, 44)
        Me.lblstat2.TabIndex = 16
        Me.lblstat2.Text = "0"
        Me.lblstat2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblstat3
        '
        Me.lblstat3.Font = New System.Drawing.Font("Verdana", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstat3.Location = New System.Drawing.Point(50, 40)
        Me.lblstat3.Name = "lblstat3"
        Me.lblstat3.Size = New System.Drawing.Size(51, 44)
        Me.lblstat3.TabIndex = 16
        Me.lblstat3.Text = "0"
        Me.lblstat3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblstat4
        '
        Me.lblstat4.Font = New System.Drawing.Font("Verdana", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstat4.Location = New System.Drawing.Point(50, 40)
        Me.lblstat4.Name = "lblstat4"
        Me.lblstat4.Size = New System.Drawing.Size(51, 44)
        Me.lblstat4.TabIndex = 16
        Me.lblstat4.Text = "0"
        Me.lblstat4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 668)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1071, 707)
        Me.MinimumSize = New System.Drawing.Size(1071, 707)
        Me.Name = "FrmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lokatoo - Tableau de bord"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.pnltitre.ResumeLayout(False)
        Me.pnltitre.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlstat.ResumeLayout(False)
        Me.pnlstat1.ResumeLayout(False)
        Me.pnlstat1.PerformLayout()
        Me.pnlstat2.ResumeLayout(False)
        Me.pnlstat2.PerformLayout()
        Me.pnlstat3.ResumeLayout(False)
        Me.pnlstat3.PerformLayout()
        Me.pnlstat4.ResumeLayout(False)
        Me.pnlstat4.PerformLayout()
        Me.pnlinfo.ResumeLayout(False)
        Me.pnlinfo.PerformLayout()
        Me.pnlgrille.ResumeLayout(False)
        Me.pnlinfog1.ResumeLayout(False)
        Me.pnlinfog1.PerformLayout()
        Me.pnlinfog2.ResumeLayout(False)
        Me.pnlinfog2.PerformLayout()
        CType(Me.dgvStat1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStat2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbltitre As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl1 As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents pnltitre As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnPaiements As Button
    Friend WithEvents btnContrats As Button
    Friend WithEvents btnLacataires As Button
    Friend WithEvents btnBien As Button
    Friend WithEvents btnDeconnexion As Button
    Friend WithEvents btnNotification As Button
    Friend WithEvents pnlstat As Panel
    Friend WithEvents pnlstat3 As Panel
    Friend WithEvents pnlstat2 As Panel
    Friend WithEvents pnlstat1 As Panel
    Friend WithEvents pnlstat4 As Panel
    Friend WithEvents lblsep2 As Panel
    Friend WithEvents pnlsep1 As Panel
    Friend WithEvents pnlinfo As Panel
    Friend WithEvents lblinfopconnect As Label
    Friend WithEvents lblinfodimunitif As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents pnlinfog1 As Panel
    Friend WithEvents pnlgrille As Panel
    Friend WithEvents pnlinfog2 As Panel
    Friend WithEvents lbl8 As Label
    Friend WithEvents dgvStat1 As DataGridView
    Friend WithEvents dgvStat2 As DataGridView
    Friend WithEvents lbl9 As Label
    Friend WithEvents btnResiliation As Button
    Friend WithEvents btnEtatdesLieux As Button
    Friend WithEvents btnDécaissements As Button
    Friend WithEvents btnBailleurs As Button
    Friend WithEvents btnPersonnel As Button
    Friend WithEvents clLocataire As DataGridViewTextBoxColumn
    Friend WithEvents clMontant As DataGridViewTextBoxColumn
    Friend WithEvents clMode As DataGridViewTextBoxColumn
    Friend WithEvents clDate As DataGridViewTextBoxColumn
    Friend WithEvents clStatut As DataGridViewTextBoxColumn
    Friend WithEvents clAdresse As DataGridViewTextBoxColumn
    Friend WithEvents clType As DataGridViewTextBoxColumn
    Friend WithEvents clLoyer As DataGridViewTextBoxColumn
    Friend WithEvents clQuartier As DataGridViewTextBoxColumn
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl7 As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lblstat1 As Label
    Friend WithEvents lblstat2 As Label
    Friend WithEvents lblstat4 As Label
    Friend WithEvents lblstat3 As Label
End Class
