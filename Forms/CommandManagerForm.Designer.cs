using System.ComponentModel;

namespace Menagelec.Forms
{
    partial class CommandManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button returnToMenuBtn;
            this.titleForm = new System.Windows.Forms.Label();
            this.labelListeCommandes = new System.Windows.Forms.Label();
            this.dataGridViewListeCommandes = new System.Windows.Forms.DataGridView();
            this.checkBoxLSTout = new System.Windows.Forms.CheckBox();
            this.checkBoxLSAPayer = new System.Windows.Forms.CheckBox();
            this.checkBoxLSAExpedier = new System.Windows.Forms.CheckBox();
            this.numCommandesLabel = new System.Windows.Forms.Label();
            this.numCommandesValue = new System.Windows.Forms.Label();
            this.infoCommandLabel = new System.Windows.Forms.Label();
            this.paneClientInfo = new System.Windows.Forms.Panel();
            this.clientTelephone = new System.Windows.Forms.Label();
            this.clientAdresseMail = new System.Windows.Forms.Label();
            this.clientTelephoneLabel = new System.Windows.Forms.Label();
            this.clientAdresseMailLabel = new System.Windows.Forms.Label();
            this.clientVille = new System.Windows.Forms.Label();
            this.clientCp = new System.Windows.Forms.Label();
            this.clientAdresse = new System.Windows.Forms.Label();
            this.clientPrenom = new System.Windows.Forms.Label();
            this.clientNom = new System.Windows.Forms.Label();
            this.clientCivilite = new System.Windows.Forms.Label();
            this.clientId = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.panelCommandInfo = new System.Windows.Forms.Panel();
            this.expeditionImage = new System.Windows.Forms.PictureBox();
            this.paiementImage = new System.Windows.Forms.PictureBox();
            this.commandEstExpedieeLabel = new System.Windows.Forms.Label();
            this.commandEstPayeeLabel = new System.Windows.Forms.Label();
            this.commandDate = new System.Windows.Forms.Label();
            this.commandDateLabel = new System.Windows.Forms.Label();
            this.commandId = new System.Windows.Forms.Label();
            this.commandLabel = new System.Windows.Forms.Label();
            this.refCommandLabel = new System.Windows.Forms.Label();
            this.refCommandNum = new System.Windows.Forms.Label();
            this.dataGridViewCommandRef = new System.Windows.Forms.DataGridView();
            this.specificSearchLabel = new System.Windows.Forms.Label();
            this.textBoxClientSearch = new System.Windows.Forms.TextBox();
            this.labelSearchClient = new System.Windows.Forms.Label();
            this.checkBoxClientSearch = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCommandSearch = new System.Windows.Forms.TextBox();
            this.checkBoxCommandSearch = new System.Windows.Forms.CheckBox();
            returnToMenuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeCommandes)).BeginInit();
            this.paneClientInfo.SuspendLayout();
            this.panelCommandInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expeditionImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paiementImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommandRef)).BeginInit();
            this.SuspendLayout();
            // 
            // returnToMenuBtn
            // 
            returnToMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            returnToMenuBtn.Location = new System.Drawing.Point(1151, 660);
            returnToMenuBtn.Name = "returnToMenuBtn";
            returnToMenuBtn.Size = new System.Drawing.Size(99, 49);
            returnToMenuBtn.TabIndex = 8;
            returnToMenuBtn.Text = "Retour au \r\nmenu";
            returnToMenuBtn.UseVisualStyleBackColor = true;
            returnToMenuBtn.Click += new System.EventHandler(this.returnToMenuBtn_Click);
            // 
            // titleForm
            // 
            this.titleForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleForm.AutoSize = true;
            this.titleForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleForm.ForeColor = System.Drawing.Color.White;
            this.titleForm.Location = new System.Drawing.Point(509, 25);
            this.titleForm.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.titleForm.Name = "titleForm";
            this.titleForm.Size = new System.Drawing.Size(280, 29);
            this.titleForm.TabIndex = 0;
            this.titleForm.Text = "Gestion des commandes";
            // 
            // labelListeCommandes
            // 
            this.labelListeCommandes.AutoSize = true;
            this.labelListeCommandes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelListeCommandes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListeCommandes.ForeColor = System.Drawing.Color.White;
            this.labelListeCommandes.Location = new System.Drawing.Point(100, 75);
            this.labelListeCommandes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelListeCommandes.Name = "labelListeCommandes";
            this.labelListeCommandes.Size = new System.Drawing.Size(202, 25);
            this.labelListeCommandes.TabIndex = 1;
            this.labelListeCommandes.Text = "Liste des commandes";
            // 
            // dataGridViewListeCommandes
            // 
            this.dataGridViewListeCommandes.AllowUserToAddRows = false;
            this.dataGridViewListeCommandes.AllowUserToDeleteRows = false;
            this.dataGridViewListeCommandes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewListeCommandes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewListeCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListeCommandes.GridColor = System.Drawing.Color.White;
            this.dataGridViewListeCommandes.Location = new System.Drawing.Point(12, 159);
            this.dataGridViewListeCommandes.Name = "dataGridViewListeCommandes";
            this.dataGridViewListeCommandes.ReadOnly = true;
            this.dataGridViewListeCommandes.RowHeadersVisible = false;
            this.dataGridViewListeCommandes.RowTemplate.Height = 24;
            this.dataGridViewListeCommandes.Size = new System.Drawing.Size(400, 550);
            this.dataGridViewListeCommandes.TabIndex = 2;
            this.dataGridViewListeCommandes.TabStop = false;
            this.dataGridViewListeCommandes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewListeCommandes_CellMouseClick);
            // 
            // checkBoxLSTout
            // 
            this.checkBoxLSTout.AutoSize = true;
            this.checkBoxLSTout.Checked = true;
            this.checkBoxLSTout.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLSTout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLSTout.Location = new System.Drawing.Point(44, 107);
            this.checkBoxLSTout.Name = "checkBoxLSTout";
            this.checkBoxLSTout.Size = new System.Drawing.Size(59, 21);
            this.checkBoxLSTout.TabIndex = 3;
            this.checkBoxLSTout.Text = "Tout";
            this.checkBoxLSTout.UseVisualStyleBackColor = true;
            this.checkBoxLSTout.CheckedChanged += new System.EventHandler(this.checkBoxLSTout_CheckedChanged);
            // 
            // checkBoxLSAPayer
            // 
            this.checkBoxLSAPayer.AutoSize = true;
            this.checkBoxLSAPayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLSAPayer.Location = new System.Drawing.Point(159, 107);
            this.checkBoxLSAPayer.Name = "checkBoxLSAPayer";
            this.checkBoxLSAPayer.Size = new System.Drawing.Size(79, 21);
            this.checkBoxLSAPayer.TabIndex = 4;
            this.checkBoxLSAPayer.Text = "A payer";
            this.checkBoxLSAPayer.UseVisualStyleBackColor = true;
            this.checkBoxLSAPayer.CheckedChanged += new System.EventHandler(this.checkBoxLSAPayer_CheckedChanged);
            // 
            // checkBoxLSAExpedier
            // 
            this.checkBoxLSAExpedier.AutoSize = true;
            this.checkBoxLSAExpedier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLSAExpedier.Location = new System.Drawing.Point(285, 107);
            this.checkBoxLSAExpedier.Name = "checkBoxLSAExpedier";
            this.checkBoxLSAExpedier.Size = new System.Drawing.Size(97, 21);
            this.checkBoxLSAExpedier.TabIndex = 5;
            this.checkBoxLSAExpedier.Text = "A expédier";
            this.checkBoxLSAExpedier.UseVisualStyleBackColor = true;
            this.checkBoxLSAExpedier.CheckedChanged += new System.EventHandler(this.checkBoxLSAExpedier_CheckedChanged);
            // 
            // numCommandesLabel
            // 
            this.numCommandesLabel.AutoSize = true;
            this.numCommandesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCommandesLabel.ForeColor = System.Drawing.Color.White;
            this.numCommandesLabel.Location = new System.Drawing.Point(12, 135);
            this.numCommandesLabel.Name = "numCommandesLabel";
            this.numCommandesLabel.Size = new System.Drawing.Size(142, 17);
            this.numCommandesLabel.TabIndex = 6;
            this.numCommandesLabel.Text = "Nombre d\'éléments : ";
            // 
            // numCommandesValue
            // 
            this.numCommandesValue.AutoSize = true;
            this.numCommandesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCommandesValue.ForeColor = System.Drawing.Color.White;
            this.numCommandesValue.Location = new System.Drawing.Point(159, 135);
            this.numCommandesValue.Name = "numCommandesValue";
            this.numCommandesValue.Size = new System.Drawing.Size(8, 17);
            this.numCommandesValue.TabIndex = 7;
            this.numCommandesValue.Text = "\r\n";
            // 
            // infoCommandLabel
            // 
            this.infoCommandLabel.AutoSize = true;
            this.infoCommandLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoCommandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoCommandLabel.ForeColor = System.Drawing.Color.White;
            this.infoCommandLabel.Location = new System.Drawing.Point(516, 75);
            this.infoCommandLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.infoCommandLabel.Name = "infoCommandLabel";
            this.infoCommandLabel.Size = new System.Drawing.Size(267, 50);
            this.infoCommandLabel.TabIndex = 9;
            this.infoCommandLabel.Text = "Informations de la commande\r\nséléctionnée\r\n";
            this.infoCommandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paneClientInfo
            // 
            this.paneClientInfo.BackColor = System.Drawing.Color.White;
            this.paneClientInfo.Controls.Add(this.clientTelephone);
            this.paneClientInfo.Controls.Add(this.clientAdresseMail);
            this.paneClientInfo.Controls.Add(this.clientTelephoneLabel);
            this.paneClientInfo.Controls.Add(this.clientAdresseMailLabel);
            this.paneClientInfo.Controls.Add(this.clientVille);
            this.paneClientInfo.Controls.Add(this.clientCp);
            this.paneClientInfo.Controls.Add(this.clientAdresse);
            this.paneClientInfo.Controls.Add(this.clientPrenom);
            this.paneClientInfo.Controls.Add(this.clientNom);
            this.paneClientInfo.Controls.Add(this.clientCivilite);
            this.paneClientInfo.Controls.Add(this.clientId);
            this.paneClientInfo.Controls.Add(this.clientLabel);
            this.paneClientInfo.ForeColor = System.Drawing.Color.White;
            this.paneClientInfo.Location = new System.Drawing.Point(461, 159);
            this.paneClientInfo.Name = "paneClientInfo";
            this.paneClientInfo.Size = new System.Drawing.Size(380, 229);
            this.paneClientInfo.TabIndex = 10;
            // 
            // clientTelephone
            // 
            this.clientTelephone.AutoSize = true;
            this.clientTelephone.BackColor = System.Drawing.Color.White;
            this.clientTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientTelephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.clientTelephone.Location = new System.Drawing.Point(131, 204);
            this.clientTelephone.Name = "clientTelephone";
            this.clientTelephone.Size = new System.Drawing.Size(0, 18);
            this.clientTelephone.TabIndex = 11;
            // 
            // clientAdresseMail
            // 
            this.clientAdresseMail.AutoSize = true;
            this.clientAdresseMail.BackColor = System.Drawing.Color.White;
            this.clientAdresseMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientAdresseMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.clientAdresseMail.Location = new System.Drawing.Point(131, 172);
            this.clientAdresseMail.Name = "clientAdresseMail";
            this.clientAdresseMail.Size = new System.Drawing.Size(0, 18);
            this.clientAdresseMail.TabIndex = 10;
            // 
            // clientTelephoneLabel
            // 
            this.clientTelephoneLabel.AutoSize = true;
            this.clientTelephoneLabel.BackColor = System.Drawing.Color.White;
            this.clientTelephoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientTelephoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.clientTelephoneLabel.Location = new System.Drawing.Point(6, 204);
            this.clientTelephoneLabel.Name = "clientTelephoneLabel";
            this.clientTelephoneLabel.Size = new System.Drawing.Size(86, 18);
            this.clientTelephoneLabel.TabIndex = 9;
            this.clientTelephoneLabel.Text = "Téléphone";
            // 
            // clientAdresseMailLabel
            // 
            this.clientAdresseMailLabel.AutoSize = true;
            this.clientAdresseMailLabel.BackColor = System.Drawing.Color.White;
            this.clientAdresseMailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientAdresseMailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.clientAdresseMailLabel.Location = new System.Drawing.Point(6, 172);
            this.clientAdresseMailLabel.Name = "clientAdresseMailLabel";
            this.clientAdresseMailLabel.Size = new System.Drawing.Size(105, 18);
            this.clientAdresseMailLabel.TabIndex = 8;
            this.clientAdresseMailLabel.Text = "Adresse mail";
            // 
            // clientVille
            // 
            this.clientVille.AutoSize = true;
            this.clientVille.BackColor = System.Drawing.Color.White;
            this.clientVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientVille.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.clientVille.Location = new System.Drawing.Point(131, 134);
            this.clientVille.Name = "clientVille";
            this.clientVille.Size = new System.Drawing.Size(0, 18);
            this.clientVille.TabIndex = 7;
            // 
            // clientCp
            // 
            this.clientCp.AutoSize = true;
            this.clientCp.BackColor = System.Drawing.Color.White;
            this.clientCp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientCp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.clientCp.Location = new System.Drawing.Point(6, 134);
            this.clientCp.Name = "clientCp";
            this.clientCp.Size = new System.Drawing.Size(0, 18);
            this.clientCp.TabIndex = 6;
            // 
            // clientAdresse
            // 
            this.clientAdresse.AutoSize = true;
            this.clientAdresse.BackColor = System.Drawing.Color.White;
            this.clientAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientAdresse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.clientAdresse.Location = new System.Drawing.Point(6, 80);
            this.clientAdresse.Name = "clientAdresse";
            this.clientAdresse.Size = new System.Drawing.Size(0, 18);
            this.clientAdresse.TabIndex = 5;
            // 
            // clientPrenom
            // 
            this.clientPrenom.AutoSize = true;
            this.clientPrenom.BackColor = System.Drawing.Color.White;
            this.clientPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientPrenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.clientPrenom.Location = new System.Drawing.Point(199, 38);
            this.clientPrenom.Name = "clientPrenom";
            this.clientPrenom.Size = new System.Drawing.Size(0, 18);
            this.clientPrenom.TabIndex = 4;
            // 
            // clientNom
            // 
            this.clientNom.AutoSize = true;
            this.clientNom.BackColor = System.Drawing.Color.White;
            this.clientNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.clientNom.Location = new System.Drawing.Point(68, 38);
            this.clientNom.Name = "clientNom";
            this.clientNom.Size = new System.Drawing.Size(0, 18);
            this.clientNom.TabIndex = 3;
            // 
            // clientCivilite
            // 
            this.clientCivilite.AutoSize = true;
            this.clientCivilite.BackColor = System.Drawing.Color.White;
            this.clientCivilite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientCivilite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.clientCivilite.Location = new System.Drawing.Point(16, 38);
            this.clientCivilite.Name = "clientCivilite";
            this.clientCivilite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clientCivilite.Size = new System.Drawing.Size(0, 18);
            this.clientCivilite.TabIndex = 2;
            // 
            // clientId
            // 
            this.clientId.AutoSize = true;
            this.clientId.BackColor = System.Drawing.Color.White;
            this.clientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.clientId.Location = new System.Drawing.Point(63, 0);
            this.clientId.Name = "clientId";
            this.clientId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clientId.Size = new System.Drawing.Size(0, 18);
            this.clientId.TabIndex = 1;
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.BackColor = System.Drawing.Color.White;
            this.clientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.clientLabel.Location = new System.Drawing.Point(0, 0);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(48, 18);
            this.clientLabel.TabIndex = 0;
            this.clientLabel.Text = "client";
            // 
            // panelCommandInfo
            // 
            this.panelCommandInfo.BackColor = System.Drawing.Color.White;
            this.panelCommandInfo.Controls.Add(this.expeditionImage);
            this.panelCommandInfo.Controls.Add(this.paiementImage);
            this.panelCommandInfo.Controls.Add(this.commandEstExpedieeLabel);
            this.panelCommandInfo.Controls.Add(this.commandEstPayeeLabel);
            this.panelCommandInfo.Controls.Add(this.commandDate);
            this.panelCommandInfo.Controls.Add(this.commandDateLabel);
            this.panelCommandInfo.Controls.Add(this.commandId);
            this.panelCommandInfo.Controls.Add(this.commandLabel);
            this.panelCommandInfo.Location = new System.Drawing.Point(461, 394);
            this.panelCommandInfo.Name = "panelCommandInfo";
            this.panelCommandInfo.Size = new System.Drawing.Size(380, 111);
            this.panelCommandInfo.TabIndex = 11;
            // 
            // expeditionImage
            // 
            this.expeditionImage.BackgroundImage = global::Menagelec.Properties.Resources._1394462228_Silver_button;
            this.expeditionImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.expeditionImage.Location = new System.Drawing.Point(131, 83);
            this.expeditionImage.Name = "expeditionImage";
            this.expeditionImage.Size = new System.Drawing.Size(20, 20);
            this.expeditionImage.TabIndex = 18;
            this.expeditionImage.TabStop = false;
            // 
            // paiementImage
            // 
            this.paiementImage.BackgroundImage = global::Menagelec.Properties.Resources._1394462228_Silver_button;
            this.paiementImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.paiementImage.Location = new System.Drawing.Point(131, 59);
            this.paiementImage.Name = "paiementImage";
            this.paiementImage.Size = new System.Drawing.Size(20, 20);
            this.paiementImage.TabIndex = 17;
            this.paiementImage.TabStop = false;
            // 
            // commandEstExpedieeLabel
            // 
            this.commandEstExpedieeLabel.AutoSize = true;
            this.commandEstExpedieeLabel.BackColor = System.Drawing.Color.White;
            this.commandEstExpedieeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandEstExpedieeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.commandEstExpedieeLabel.Location = new System.Drawing.Point(6, 85);
            this.commandEstExpedieeLabel.Name = "commandEstExpedieeLabel";
            this.commandEstExpedieeLabel.Size = new System.Drawing.Size(86, 18);
            this.commandEstExpedieeLabel.TabIndex = 16;
            this.commandEstExpedieeLabel.Text = "Expedition";
            // 
            // commandEstPayeeLabel
            // 
            this.commandEstPayeeLabel.AutoSize = true;
            this.commandEstPayeeLabel.BackColor = System.Drawing.Color.White;
            this.commandEstPayeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandEstPayeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.commandEstPayeeLabel.Location = new System.Drawing.Point(6, 59);
            this.commandEstPayeeLabel.Name = "commandEstPayeeLabel";
            this.commandEstPayeeLabel.Size = new System.Drawing.Size(78, 18);
            this.commandEstPayeeLabel.TabIndex = 15;
            this.commandEstPayeeLabel.Text = "Paiement";
            // 
            // commandDate
            // 
            this.commandDate.AutoSize = true;
            this.commandDate.BackColor = System.Drawing.Color.White;
            this.commandDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.commandDate.Location = new System.Drawing.Point(72, 28);
            this.commandDate.Name = "commandDate";
            this.commandDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.commandDate.Size = new System.Drawing.Size(40, 18);
            this.commandDate.TabIndex = 14;
            // 
            // commandDateLabel
            // 
            this.commandDateLabel.AutoSize = true;
            this.commandDateLabel.BackColor = System.Drawing.Color.White;
            this.commandDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.commandDateLabel.Location = new System.Drawing.Point(6, 28);
            this.commandDateLabel.Name = "commandDateLabel";
            this.commandDateLabel.Size = new System.Drawing.Size(0, 18);
            this.commandDateLabel.TabIndex = 13;
            this.commandDateLabel.Text = "date";
            // 
            // commandId
            // 
            this.commandId.AutoSize = true;
            this.commandId.BackColor = System.Drawing.Color.White;
            this.commandId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.commandId.Location = new System.Drawing.Point(109, 0);
            this.commandId.Name = "commandId";
            this.commandId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.commandId.Size = new System.Drawing.Size(0, 18);
            this.commandId.TabIndex = 12;
            // 
            // commandLabel
            // 
            this.commandLabel.AutoSize = true;
            this.commandLabel.BackColor = System.Drawing.Color.White;
            this.commandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.commandLabel.Location = new System.Drawing.Point(0, 0);
            this.commandLabel.Name = "commandLabel";
            this.commandLabel.Size = new System.Drawing.Size(112, 18);
            this.commandLabel.TabIndex = 12;
            this.commandLabel.Text = "commande n°";
            // 
            // refCommandLabel
            // 
            this.refCommandLabel.AutoSize = true;
            this.refCommandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refCommandLabel.ForeColor = System.Drawing.Color.White;
            this.refCommandLabel.Location = new System.Drawing.Point(461, 517);
            this.refCommandLabel.Name = "refCommandLabel";
            this.refCommandLabel.Size = new System.Drawing.Size(285, 17);
            this.refCommandLabel.TabIndex = 12;
            this.refCommandLabel.Text = "Nombre de références dans la commande : \r\n";
            // 
            // refCommandNum
            // 
            this.refCommandNum.AutoSize = true;
            this.refCommandNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refCommandNum.ForeColor = System.Drawing.Color.White;
            this.refCommandNum.Location = new System.Drawing.Point(752, 517);
            this.refCommandNum.Name = "refCommandNum";
            this.refCommandNum.Size = new System.Drawing.Size(8, 17);
            this.refCommandNum.TabIndex = 13;
            this.refCommandNum.Text = "\r\n";
            // 
            // dataGridViewCommandRef
            // 
            this.dataGridViewCommandRef.AllowUserToAddRows = false;
            this.dataGridViewCommandRef.AllowUserToDeleteRows = false;
            this.dataGridViewCommandRef.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCommandRef.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCommandRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCommandRef.GridColor = System.Drawing.Color.White;
            this.dataGridViewCommandRef.Location = new System.Drawing.Point(461, 543);
            this.dataGridViewCommandRef.Name = "dataGridViewCommandRef";
            this.dataGridViewCommandRef.ReadOnly = true;
            this.dataGridViewCommandRef.RowHeadersVisible = false;
            this.dataGridViewCommandRef.RowTemplate.Height = 24;
            this.dataGridViewCommandRef.Size = new System.Drawing.Size(380, 166);
            this.dataGridViewCommandRef.TabIndex = 14;
            this.dataGridViewCommandRef.TabStop = false;
            // 
            // specificSearchLabel
            // 
            this.specificSearchLabel.AutoSize = true;
            this.specificSearchLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specificSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specificSearchLabel.ForeColor = System.Drawing.Color.White;
            this.specificSearchLabel.Location = new System.Drawing.Point(969, 75);
            this.specificSearchLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.specificSearchLabel.Name = "specificSearchLabel";
            this.specificSearchLabel.Size = new System.Drawing.Size(199, 25);
            this.specificSearchLabel.TabIndex = 15;
            this.specificSearchLabel.Text = "Recherche spécifique";
            this.specificSearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxClientSearch
            // 
            this.textBoxClientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClientSearch.Location = new System.Drawing.Point(916, 195);
            this.textBoxClientSearch.Name = "textBoxClientSearch";
            this.textBoxClientSearch.Size = new System.Drawing.Size(266, 23);
            this.textBoxClientSearch.TabIndex = 16;
            // 
            // labelSearchClient
            // 
            this.labelSearchClient.AutoSize = true;
            this.labelSearchClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchClient.ForeColor = System.Drawing.Color.White;
            this.labelSearchClient.Location = new System.Drawing.Point(916, 157);
            this.labelSearchClient.Name = "labelSearchClient";
            this.labelSearchClient.Size = new System.Drawing.Size(164, 20);
            this.labelSearchClient.TabIndex = 17;
            this.labelSearchClient.Text = "Rechercher un client";
            // 
            // checkBoxClientSearch
            // 
            this.checkBoxClientSearch.AutoSize = true;
            this.checkBoxClientSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBoxClientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxClientSearch.Location = new System.Drawing.Point(1216, 199);
            this.checkBoxClientSearch.Name = "checkBoxClientSearch";
            this.checkBoxClientSearch.Size = new System.Drawing.Size(18, 17);
            this.checkBoxClientSearch.TabIndex = 18;
            this.checkBoxClientSearch.UseVisualStyleBackColor = true;
            this.checkBoxClientSearch.CheckedChanged += new System.EventHandler(this.checkBoxClientSearch_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(916, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Rechercher une commande";
            // 
            // textBoxCommandSearch
            // 
            this.textBoxCommandSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCommandSearch.Location = new System.Drawing.Point(916, 302);
            this.textBoxCommandSearch.Name = "textBoxCommandSearch";
            this.textBoxCommandSearch.Size = new System.Drawing.Size(266, 23);
            this.textBoxCommandSearch.TabIndex = 20;
            // 
            // checkBoxCommandSearch
            // 
            this.checkBoxCommandSearch.AutoSize = true;
            this.checkBoxCommandSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBoxCommandSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCommandSearch.Location = new System.Drawing.Point(1216, 306);
            this.checkBoxCommandSearch.Name = "checkBoxCommandSearch";
            this.checkBoxCommandSearch.Size = new System.Drawing.Size(18, 17);
            this.checkBoxCommandSearch.TabIndex = 21;
            this.checkBoxCommandSearch.UseVisualStyleBackColor = true;
            this.checkBoxCommandSearch.CheckedChanged += new System.EventHandler(this.checkBoxCommandSearch_CheckedChanged);
            // 
            // CommandManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.checkBoxCommandSearch);
            this.Controls.Add(this.textBoxCommandSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxClientSearch);
            this.Controls.Add(this.labelSearchClient);
            this.Controls.Add(this.textBoxClientSearch);
            this.Controls.Add(this.specificSearchLabel);
            this.Controls.Add(this.dataGridViewCommandRef);
            this.Controls.Add(this.refCommandNum);
            this.Controls.Add(this.refCommandLabel);
            this.Controls.Add(this.panelCommandInfo);
            this.Controls.Add(this.paneClientInfo);
            this.Controls.Add(this.infoCommandLabel);
            this.Controls.Add(returnToMenuBtn);
            this.Controls.Add(this.numCommandesValue);
            this.Controls.Add(this.numCommandesLabel);
            this.Controls.Add(this.checkBoxLSAExpedier);
            this.Controls.Add(this.checkBoxLSAPayer);
            this.Controls.Add(this.checkBoxLSTout);
            this.Controls.Add(this.dataGridViewListeCommandes);
            this.Controls.Add(this.labelListeCommandes);
            this.Controls.Add(this.titleForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CommandManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeCommandes)).EndInit();
            this.paneClientInfo.ResumeLayout(false);
            this.paneClientInfo.PerformLayout();
            this.panelCommandInfo.ResumeLayout(false);
            this.panelCommandInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expeditionImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paiementImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommandRef)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxCommandSearch;
        
        private System.Windows.Forms.CheckBox checkBoxCommandSearch;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.CheckBox checkBoxClientSearch;

        private System.Windows.Forms.Label labelSearchClient;

        private System.Windows.Forms.TextBox textBoxClientSearch;

        private System.Windows.Forms.Label specificSearchLabel;

        private System.Windows.Forms.Label refCommandNum;
        
        private System.Windows.Forms.DataGridView dataGridViewCommandRef;

        private System.Windows.Forms.Label refCommandLabel;

        private System.Windows.Forms.PictureBox expeditionImage;

        private System.Windows.Forms.Label commandEstExpedieeLabel;
        
        private System.Windows.Forms.PictureBox paiementImage;

        private System.Windows.Forms.Label commandEstPayeeLabel;

        private System.Windows.Forms.Label commandDate;

        private System.Windows.Forms.Label commandDateLabel;

        private System.Windows.Forms.Label commandId;

        private System.Windows.Forms.Label commandLabel;

        private System.Windows.Forms.Panel panelCommandInfo;

        private System.Windows.Forms.Label clientAdresseMailLabel;
        
        private System.Windows.Forms.Label clientAdresseMail;

        private System.Windows.Forms.Label clientTelephoneLabel;

        private System.Windows.Forms.Label clientTelephone;

        private System.Windows.Forms.Label clientCp;

        private System.Windows.Forms.Label clientAdresse;

        private System.Windows.Forms.Label clientNom;
        
        private System.Windows.Forms.Label clientPrenom;

        private System.Windows.Forms.Label clientCivilite;
        
        private System.Windows.Forms.Label clientVille;

        private System.Windows.Forms.Label clientId;

        private System.Windows.Forms.Label clientLabel;

        private System.Windows.Forms.Panel paneClientInfo;

        private System.Windows.Forms.Label infoCommandLabel;

        private System.Windows.Forms.Label numCommandesValue;

        private System.Windows.Forms.Label numCommandesLabel;

        private System.Windows.Forms.CheckBox checkBoxLSAExpedier;

        private System.Windows.Forms.CheckBox checkBoxLSAPayer;

        private System.Windows.Forms.CheckBox checkBoxLSTout;

        private System.Windows.Forms.DataGridView dataGridViewListeCommandes;

        private System.Windows.Forms.Label labelListeCommandes;

        private System.Windows.Forms.Label titleForm;

        #endregion
    }
}