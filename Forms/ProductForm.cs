using System.Windows.Forms;
using Menagelec.Entity;
using Menagelec.Service;

namespace Menagelec.Forms
{
    public partial class ProductForm : Form
    {
        public ProductForm(Produit produit)
        {
            InitializeComponent();

            labelNameProduct.Text = produit.Designation;
            imageProduct.BackgroundImage = ResourceService.GetProductImage(produit.FichierImage);
            labelPriceProductValue.Text = produit.Prix + @" €";
            labelDescriptionProduct.Text = produit.Description;
        }
    }
}