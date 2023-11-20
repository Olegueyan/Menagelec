using System;
using System.Linq;
using System.Windows.Forms;
using Menagelec.Data;
using Menagelec.Forms;

namespace Menagelec
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            // Event registering
            
            buttonConnect.Click += buttonConnect_Click;
            
            // Keyboard handling

            KeyDown += (sender, args) =>
            {
                if (args.KeyCode == Keys.Enter) buttonConnect.PerformClick();
            };
        }
        
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            var loginType = new LoginType
            {
                Login = textBoxUser.Text,
                Password = textBoxPassword.Text
            };

            if (Constants.PossibleLogin.Any(type => type.Equals(loginType)))
            {
                Hide();
                var menuForm = new MenuForm();
                menuForm.Show();
            }
            else
            {
                textBoxUser.Text = "";
                textBoxPassword.Text = "";
            }
        }
    }
}