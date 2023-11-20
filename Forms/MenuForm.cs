using System;
using System.Windows.Forms;

namespace Menagelec.Forms
{
    public partial class MenuForm : Form
    {
        public static MenuForm Instance = new();
        
        public MenuForm()
        {
            InitializeComponent();
            
            // Form Closing Event
            
            FormClosing += (sender, args) =>
            {
                Application.Exit();
            };
            
            // Event registering
            
            btnCommandeGestion.Click += btnCommandeGestion_Click;
        }

        private void btnCommandeGestion_Click(object sender, EventArgs e)
        {
            Hide();
            CommandManagerForm.Instance.Show();
        }
    }
}