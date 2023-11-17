using System.Windows.Forms;

namespace Menagelec.Forms
{
    public partial class CommandManagerForm : Form
    {
        public CommandManagerForm()
        {
            InitializeComponent();
            FormClosing += (sender, args) =>
            {
                Application.Exit();
            };
        }
    }
}