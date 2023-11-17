using System;
using System.Windows.Forms;

namespace Menagelec.Forms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            
            // Event registering
            
            btnCommandeGestion.Click += btnCommandeGestion_Click;
            
            // Form Closing Event
            
            FormClosing += (_, _) =>
            {
                Application.Exit();
            };
        }

        private void btnCommandeGestion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}