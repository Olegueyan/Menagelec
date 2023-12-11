namespace Menagelec
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.pictureBoxMenagelec = new System.Windows.Forms.PictureBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenagelec)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMenagelec
            // 
            this.pictureBoxMenagelec.Image = global::Menagelec.Properties.Resources.logo_menagelec;
            this.pictureBoxMenagelec.Location = new System.Drawing.Point(25, 25);
            this.pictureBoxMenagelec.Name = "pictureBoxMenagelec";
            this.pictureBoxMenagelec.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxMenagelec.TabIndex = 0;
            this.pictureBoxMenagelec.TabStop = false;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(373, 275);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(319, 35);
            this.buttonConnect.TabIndex = 10;
            this.buttonConnect.Text = "Se connecter";
            this.buttonConnect.UseVisualStyleBackColor = true;
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(373, 139);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(176, 20);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Mot de passe";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(373, 187);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(319, 34);
            this.textBoxPassword.TabIndex = 8;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(373, 73);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(319, 34);
            this.textBoxUser.TabIndex = 7;
            // 
            // labelUser
            // 
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(373, 37);
            this.labelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(176, 20);
            this.labelUser.TabIndex = 6;
            this.labelUser.Text = "Utilisateur";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(750, 353);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.pictureBoxMenagelec);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormLogin";
            this.Text = "Ménagelec - Accès à l\'application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenagelec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelUser;

        private System.Windows.Forms.PictureBox pictureBoxMenagelec;

        #endregion
    }
}