using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using Menagelec.Entity;
using Menagelec.Repository;

namespace Menagelec.Forms
{
    public partial class CommandManagerForm : Form
    {
        public CommandManagerForm()
        {
            InitializeComponent();
            
            // Form Closing Event
            
            FormClosing += (sender, args) =>
            {
                Application.Exit();
            };

            Load += async (sender, args) =>
            {
                // Initialize DataGridView
                
                dataGridViewListeCommandes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
                dataGridViewListeCommandes.Columns.Add("idCommande", "idCommande");
                dataGridViewListeCommandes.Columns.Add("date", "date");
                dataGridViewListeCommandes.Columns.Add("client", "client");
                
                InsertCommandesIntoDataGridView(dataGridViewListeCommandes, await CommandeRepository.ReadAll());
                numCommandesValue.Text = dataGridViewListeCommandes.Rows.Count.ToString();
            };
        }
        
        private static void InsertCommandesIntoDataGridView(DataGridView dataGridView, Collection<Commande> commandes)
        {
            dataGridView.Rows.Clear();
            
            foreach (var commande in commandes)
            {
                dataGridView.Rows.Add(commande.Id, commande.Date.ToString("dd/MM/yyyy"), commande.Client);
            }  
        }


        /**
         * When the CheckedState change
         *
         * Checked is True : Get all commands
         */
        private async void checkBoxLSTout_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLSTout.Checked)
            {
                checkBoxLSAPayer.Checked = false;
                checkBoxLSAExpedier.Checked = false;
                InsertCommandesIntoDataGridView(dataGridViewListeCommandes, await CommandeRepository.ReadAll());
                numCommandesValue.Text = dataGridViewListeCommandes.Rows.Count.ToString();
            }
            else
            {
                dataGridViewListeCommandes.Rows.Clear();
                numCommandesValue.Text = 0.ToString();
            }
        }

        /**
         * When the CheckedState change
         *
         * Checked is True : Get all commands "APayer"
         */
        private async void checkBoxLSAPayer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLSAPayer.Checked)
            {
                checkBoxLSTout.Checked = false;
                checkBoxLSAExpedier.Checked = false;
                InsertCommandesIntoDataGridView(dataGridViewListeCommandes, await CommandeRepository.ReadAllEstPayee()); 
                numCommandesValue.Text = dataGridViewListeCommandes.Rows.Count.ToString();
            }
            else
            {
                if (!checkBoxLSAExpedier.Checked)
                {
                    checkBoxLSTout.Checked = true;
                }
            }
        }

        /**
         * When the CheckedState change
         *
         * Checked is True : Get all commands "AExpedier"
         */
        private async void checkBoxLSAExpedier_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLSAExpedier.Checked)
            {
                checkBoxLSTout.Checked = false;
                checkBoxLSAPayer.Checked = false;
                InsertCommandesIntoDataGridView(dataGridViewListeCommandes, await CommandeRepository.ReadAllEstExpediee()); 
                numCommandesValue.Text = dataGridViewListeCommandes.Rows.Count.ToString();
            }
            else
            {
                if (!checkBoxLSAPayer.Checked) checkBoxLSTout.Checked = true;
            }
        }
    }
}