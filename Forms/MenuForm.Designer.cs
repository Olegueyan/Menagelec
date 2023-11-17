using System.ComponentModel;

namespace Menagelec.Forms
{
    partial class MenuForm
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
            this.btnCommandeGestion = new System.Windows.Forms.Button();
            this.labelGestionCommande = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCommandeGestion
            // 
            this.btnCommandeGestion.BackgroundImage = global::Menagelec.Properties.Resources.commande_impayee;
            this.btnCommandeGestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCommandeGestion.Location = new System.Drawing.Point(21, 21);
            this.btnCommandeGestion.Name = "btnCommandeGestion";
            this.btnCommandeGestion.Size = new System.Drawing.Size(64, 64);
            this.btnCommandeGestion.TabIndex = 0;
            this.btnCommandeGestion.UseVisualStyleBackColor = true;
            // 
            // labelGestionCommande
            // 
            this.labelGestionCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGestionCommande.ForeColor = System.Drawing.Color.White;
            this.labelGestionCommande.Location = new System.Drawing.Point(102, 48);
            this.labelGestionCommande.Name = "labelGestionCommande";
            this.labelGestionCommande.Size = new System.Drawing.Size(168, 29);
            this.labelGestionCommande.TabIndex = 1;
            this.labelGestionCommande.Text = "Gestion des commandes";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.labelGestionCommande);
            this.Controls.Add(this.btnCommandeGestion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MenuForm";
            this.Text = "Menagelec - Menu";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelGestionCommande;

        private System.Windows.Forms.Button btnCommandeGestion;

        #endregion
    }
}