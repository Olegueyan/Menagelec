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
            returnToMenuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeCommandes)).BeginInit();
            this.paneClientInfo.SuspendLayout();
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
            this.clientTelephone.Size = new System.Drawing.Size(118, 18);
            this.clientTelephone.TabIndex = 11;
            this.clientTelephone.Text = "07 07 07 07 07";
            // 
            // clientAdresseMail
            // 
            this.clientAdresseMail.AutoSize = true;
            this.clientAdresseMail.BackColor = System.Drawing.Color.White;
            this.clientAdresseMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientAdresseMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.clientAdresseMail.Location = new System.Drawing.Point(131, 172);
            this.clientAdresseMail.Name = "clientAdresseMail";
            this.clientAdresseMail.Size = new System.Drawing.Size(39, 18);
            this.clientAdresseMail.TabIndex = 10;
            this.clientAdresseMail.Text = "mail";
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
            this.clientVille.Size = new System.Drawing.Size(39, 18);
            this.clientVille.TabIndex = 7;
            this.clientVille.Text = "Ville";
            // 
            // clientCp
            // 
            this.clientCp.AutoSize = true;
            this.clientCp.BackColor = System.Drawing.Color.White;
            this.clientCp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientCp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.clientCp.Location = new System.Drawing.Point(6, 134);
            this.clientCp.Name = "clientCp";
            this.clientCp.Size = new System.Drawing.Size(53, 18);
            this.clientCp.TabIndex = 6;
            this.clientCp.Text = "00000";
            // 
            // clientAdresse
            // 
            this.clientAdresse.AutoSize = true;
            this.clientAdresse.BackColor = System.Drawing.Color.White;
            this.clientAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientAdresse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.clientAdresse.Location = new System.Drawing.Point(6, 80);
            this.clientAdresse.Name = "clientAdresse";
            this.clientAdresse.Size = new System.Drawing.Size(69, 18);
            this.clientAdresse.TabIndex = 5;
            this.clientAdresse.Text = "Adresse";
            // 
            // clientPrenom
            // 
            this.clientPrenom.AutoSize = true;
            this.clientPrenom.BackColor = System.Drawing.Color.White;
            this.clientPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientPrenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.clientPrenom.Location = new System.Drawing.Point(199, 38);
            this.clientPrenom.Name = "clientPrenom";
            this.clientPrenom.Size = new System.Drawing.Size(67, 18);
            this.clientPrenom.TabIndex = 4;
            this.clientPrenom.Text = "Prenom";
            // 
            // clientNom
            // 
            this.clientNom.AutoSize = true;
            this.clientNom.BackColor = System.Drawing.Color.White;
            this.clientNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.clientNom.Location = new System.Drawing.Point(68, 38);
            this.clientNom.Name = "clientNom";
            this.clientNom.Size = new System.Drawing.Size(44, 18);
            this.clientNom.TabIndex = 3;
            this.clientNom.Text = "Nom";
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
            this.clientCivilite.Size = new System.Drawing.Size(22, 18);
            this.clientCivilite.TabIndex = 2;
            this.clientCivilite.Text = "M";
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
            this.clientId.Size = new System.Drawing.Size(17, 18);
            this.clientId.TabIndex = 1;
            this.clientId.Text = "0";
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
            // CommandManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1262, 721);
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
            this.ResumeLayout(false);
            this.PerformLayout();
        }

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