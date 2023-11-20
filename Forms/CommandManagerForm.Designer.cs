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
            returnToMenuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeCommandes)).BeginInit();
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
            // CommandManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1262, 721);
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
            this.ResumeLayout(false);
            this.PerformLayout();
        }

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