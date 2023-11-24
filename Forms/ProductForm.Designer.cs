using System.ComponentModel;

namespace Menagelec.Forms
{
    partial class ProductForm
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
            this.labelNameProduct = new System.Windows.Forms.Label();
            this.imageProduct = new System.Windows.Forms.PictureBox();
            this.labelPriceProduct = new System.Windows.Forms.Label();
            this.labelPriceProductValue = new System.Windows.Forms.Label();
            this.labelDescriptionProduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameProduct
            // 
            this.labelNameProduct.AutoSize = true;
            this.labelNameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameProduct.ForeColor = System.Drawing.Color.White;
            this.labelNameProduct.Location = new System.Drawing.Point(15, 15);
            this.labelNameProduct.Margin = new System.Windows.Forms.Padding(0);
            this.labelNameProduct.Name = "labelNameProduct";
            this.labelNameProduct.Size = new System.Drawing.Size(179, 29);
            this.labelNameProduct.TabIndex = 0;
            this.labelNameProduct.Text = "Product Name";
            // 
            // imageProduct
            // 
            this.imageProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageProduct.Location = new System.Drawing.Point(15, 66);
            this.imageProduct.Name = "imageProduct";
            this.imageProduct.Size = new System.Drawing.Size(328, 275);
            this.imageProduct.TabIndex = 1;
            this.imageProduct.TabStop = false;
            // 
            // labelPriceProduct
            // 
            this.labelPriceProduct.AutoSize = true;
            this.labelPriceProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceProduct.ForeColor = System.Drawing.Color.White;
            this.labelPriceProduct.Location = new System.Drawing.Point(9, 426);
            this.labelPriceProduct.Margin = new System.Windows.Forms.Padding(0);
            this.labelPriceProduct.Name = "labelPriceProduct";
            this.labelPriceProduct.Size = new System.Drawing.Size(41, 18);
            this.labelPriceProduct.TabIndex = 2;
            this.labelPriceProduct.Text = "Prix :";
            // 
            // labelPriceProductValue
            // 
            this.labelPriceProductValue.AutoSize = true;
            this.labelPriceProductValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceProductValue.ForeColor = System.Drawing.Color.White;
            this.labelPriceProductValue.Location = new System.Drawing.Point(61, 426);
            this.labelPriceProductValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelPriceProductValue.Name = "labelPriceProductValue";
            this.labelPriceProductValue.Size = new System.Drawing.Size(16, 18);
            this.labelPriceProductValue.TabIndex = 3;
            this.labelPriceProductValue.Text = "?";
            // 
            // labelDescriptionProduct
            // 
            this.labelDescriptionProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescriptionProduct.ForeColor = System.Drawing.Color.White;
            this.labelDescriptionProduct.Location = new System.Drawing.Point(361, 66);
            this.labelDescriptionProduct.MaximumSize = new System.Drawing.Size(335, 275);
            this.labelDescriptionProduct.Name = "labelDescriptionProduct";
            this.labelDescriptionProduct.Size = new System.Drawing.Size(335, 275);
            this.labelDescriptionProduct.TabIndex = 4;
            this.labelDescriptionProduct.Text = "Description";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.labelDescriptionProduct);
            this.Controls.Add(this.labelPriceProductValue);
            this.Controls.Add(this.labelPriceProduct);
            this.Controls.Add(this.imageProduct);
            this.Controls.Add(this.labelNameProduct);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiche produit";
            ((System.ComponentModel.ISupportInitialize)(this.imageProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelDescriptionProduct;

        private System.Windows.Forms.Label labelPriceProductValue;

        private System.Windows.Forms.Label labelPriceProduct;

        private System.Windows.Forms.PictureBox imageProduct;

        private System.Windows.Forms.Label labelNameProduct;

        #endregion
    }
}