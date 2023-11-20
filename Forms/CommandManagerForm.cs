using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using Menagelec.Entity;
using Menagelec.Properties;
using Menagelec.Repository;

namespace Menagelec.Forms
{
    public partial class CommandManagerForm : Form
    {
        public static CommandManagerForm Instance = new();
        
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

        private void returnToMenuBtn_Click(object sender, EventArgs e)
        {
            Hide();
            MenuForm.Instance.Show();
        }

        private async void dataGridViewListeCommandes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int.TryParse(dataGridViewListeCommandes.Rows[e.RowIndex].Cells[2].Value.ToString(), out var idClient);
            
            // Link client entity to client info pane

            var client = await ClientRepository.Read(idClient);
            clientId.Text = client.IdClient.ToString();
            clientCivilite.Text = client.Civilite;
            clientNom.Text = client.Nom;
            clientPrenom.Text = client.Prenom;
            clientAdresse.Text = client.Adresse;
            clientCp.Text = client.Cp;
            clientVille.Text = client.Ville;
            clientAdresseMail.Text = client.Mail;
            clientTelephone.Text = client.Tel;
            
            int.TryParse(dataGridViewListeCommandes.Rows[e.RowIndex].Cells[0].Value.ToString(), out var idCommande);
            
            // Link command entity to command info pane

            var command = await CommandeRepository.Read(idCommande);
            commandId.Text = command.Id.ToString();
            commandDate.Text = command.Date.ToString("dd/MM/yyyy");

            paiementImage.BackgroundImage = (command.EstPayee == 1) ? Resources.etatOk : Resources.etatNotOk;
            expeditionImage.BackgroundImage = (command.EstExpediee == 1) ? Resources.etatOk : Resources.etatNotOk;
        }
    }
}