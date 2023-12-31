using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menagelec.Component;
using Menagelec.Data;
using Menagelec.Entity;
using Menagelec.Properties;
using Menagelec.Repository;
using QuestPDF.Fluent;

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
                dataGridViewListeCommandes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(223, 80, 0);

                dataGridViewListeCommandes.AllowUserToResizeColumns = false;
                dataGridViewListeCommandes.AllowUserToResizeRows = false;
                
                dataGridViewCommandRef.DefaultCellStyle.SelectionBackColor = Color.FromArgb(223, 80, 0);
                
                dataGridViewCommandRef.AllowUserToResizeColumns = false;
                dataGridViewCommandRef.AllowUserToResizeRows = false;
                
                // Initialize DataGridViews
                
                dataGridViewListeCommandes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
                dataGridViewListeCommandes.Columns.Add("idCommande", "idCommande");
                dataGridViewListeCommandes.Columns.Add("date", "date");
                dataGridViewListeCommandes.Columns.Add("client", "client");

                dataGridViewCommandRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                
                dataGridViewCommandRef.Columns.Add("Produit commandé", "Produit commandé");
                dataGridViewCommandRef.Columns.Add("Quantité", "Quantité");

                dataGridViewListeCommandes.MultiSelect = false;
                
                InsertCommandesIntoDataGridView(dataGridViewListeCommandes, await CommandeRepository.ReadAll());
                numCommandesValue.Text = dataGridViewListeCommandes.Rows.Count.ToString();
                
                dataGridViewListeCommandes.ClearSelection();
                dataGridViewListeCommandes.CurrentCell = dataGridViewListeCommandes.FirstDisplayedCell;
                dataGridViewListeCommandes.CurrentCell.Selected = true;

                await SelectCommandAndDisplay(dataGridViewListeCommandes, 0, 2, 0, DisplayType.STANDARD);
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
                
                var commandes = await CommandeRepository.ReadFiltered(GenerateFilters());
                InsertCommandesIntoDataGridView(dataGridViewListeCommandes, commandes); 
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
                
                var commandes = await CommandeRepository.ReadFiltered(GenerateFilters());
                InsertCommandesIntoDataGridView(dataGridViewListeCommandes, commandes); 
                numCommandesValue.Text = dataGridViewListeCommandes.Rows.Count.ToString();
            }
            else
            {
                if (!checkBoxLSAExpedier.Checked) checkBoxLSTout.Checked = true;
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

                var commandes = await CommandeRepository.ReadFiltered(GenerateFilters());
                InsertCommandesIntoDataGridView(dataGridViewListeCommandes, commandes); 
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
            var specificSearch = DisplayType.STANDARD;

            if (checkBoxClientSearch.Checked)
            {
                specificSearch = DisplayType.SPECIFIC_CLIENT;
            }

            if (checkBoxCommandSearch.Checked)
            {
                specificSearch = DisplayType.SPECIFIC_COMMAND;
            }
            
            await SelectCommandAndDisplay(dataGridViewListeCommandes, e.RowIndex, 2, 0, specificSearch);
        }

        private async Task SelectCommandAndDisplay(DataGridView of, int idRow, int cellIndexIdClient,
            int cellIndexIdCommand, DisplayType specificSearch)
        {
            try
            {
                int.TryParse(of.Rows[idRow].Cells[cellIndexIdClient].Value.ToString(), out var idClient);

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

                clientSpecificSearch.Visible = (specificSearch == DisplayType.SPECIFIC_CLIENT);
                
                foreach (var control in paneClientInfo.Controls.OfType<Label>())
                {
                    control.ForeColor = specificSearch == DisplayType.SPECIFIC_CLIENT ? Constants.DisplaySearchSpecificColor : Constants.DisplayStandardColor;
                }

                int.TryParse(of.Rows[idRow].Cells[cellIndexIdCommand].Value.ToString(), out var idCommande);

                // Metadata

                paneClientInfo.Tag = client;

                // Link command entity to command info pane

                var command = await CommandeRepository.Read(idCommande);
                commandId.Text = command.Id.ToString();
                commandDate.Text = command.Date.ToString("dd/MM/yyyy");

                if (command.EstPayee == 1)
                {
                    paiementImage.BackgroundImage = Resources.etatOk;
                    paiementOkBtn.Visible = false;
                }
                else
                {
                    paiementImage.BackgroundImage = Resources.etatNotOk;
                    paiementOkBtn.Visible = true;
                }

                if (command.EstExpediee == 1)
                {
                    expeditionImage.BackgroundImage = Resources.etatOk;
                    expeditionOkBtn.Visible = false;
                }
                else
                {
                    expeditionImage.BackgroundImage = Resources.etatNotOk;
                    expeditionOkBtn.Visible = true;
                }
                
                commandSpecificSearch.Visible = (specificSearch == DisplayType.SPECIFIC_COMMAND);
                
                foreach (var control in panelCommandInfo.Controls.OfType<Label>())
                {
                    control.ForeColor = specificSearch == DisplayType.SPECIFIC_COMMAND ? Constants.DisplaySearchSpecificColor : Constants.DisplayStandardColor;
                }

                // Metadata

                panelCommandInfo.Tag = command;

                // Link lignecommande entity to lignecommand info pane

                dataGridViewCommandRef.Rows.Clear();

                var lignecommandes = await LigneCommandeRepository.ReadAllLigneCommandeWithAsync(idCommande);
                refCommandNum.Text = lignecommandes.Count.ToString();
                foreach (var lignecommande in lignecommandes)
                {
                    dataGridViewCommandRef.Rows.Add(lignecommande.Produit, lignecommande.Quantite);
                }

                dataGridViewCommandRef.Tag = lignecommandes;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private async void checkBoxClientSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxClientSearch.Checked && checkBoxCommandSearch.Checked) return;
            checkBoxCommandSearch.Checked = false;
            await CommonDatabaseRequest();
        }

        private async void checkBoxCommandSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxCommandSearch.Checked && checkBoxClientSearch.Checked) return;
            checkBoxClientSearch.Checked = false;
            await CommonDatabaseRequest();
        }
        
        private async void paiementOkBtn_Click(object sender, EventArgs e)
        {
            paiementOkBtn.Visible = false;
            var commande = (Commande) panelCommandInfo.Tag;
            commande.EstPayee = 1;
            await CommandeRepository.Update(commande);
            paiementImage.BackgroundImage = Resources.etatOk;
        }

        private async void expeditionOkBtn_Click(object sender, EventArgs e)
        {
            expeditionOkBtn.Visible = false;
            var commande = (Commande) panelCommandInfo.Tag;
            commande.EstExpediee = 1;
            await CommandeRepository.Update(commande);
            expeditionImage.BackgroundImage = Resources.etatOk;
        }

        private FilterStruct[] GenerateFilters()
        {
            var filters = new Collection<FilterStruct>();

            if (checkBoxLSAPayer.Checked)
            {
                filters.Add(CommandeRepository.EST_PAYEE.With(0));
            }

            if (checkBoxLSAExpedier.Checked)
            {
                filters.Add(CommandeRepository.EST_EXPEDIEE.With(0));
            }

            if (checkBoxClientSearch.Checked)
            {
                int.TryParse(textBoxClientSearch.Text, out var idClient);
                filters.Add(CommandeRepository.CLIENT.With(idClient));
            }
            
            if (checkBoxCommandSearch.Checked)
            {
                int.TryParse(textBoxCommandSearch.Text, out var idCommande);
                filters.Add(CommandeRepository.COMMANDE.With(idCommande));
            }

            return filters.ToArray();
        }

        private async void textBoxClientSearch_Leave(object sender, EventArgs e)
        {
            // await CommonDatabaseRequest();
        }
        
        private async void textBoxCommandSearch_Leave(object sender, EventArgs e)
        {
            // await CommonDatabaseRequest();
        }

        private async Task CommonDatabaseRequest()
        {
            var commandes = await CommandeRepository.ReadFiltered(GenerateFilters());
            InsertCommandesIntoDataGridView(dataGridViewListeCommandes, commandes);
            numCommandesValue.Text = dataGridViewListeCommandes.Rows.Count.ToString();
        }

        private async void dataGridViewCommandRef_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int.TryParse(dataGridViewCommandRef.Rows[e.RowIndex].Cells[0].Value.ToString(), out var idProduit);
                var product = await ProduitRepository.Read(idProduit);
                new ProductForm(product).Show();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private async void buttonListeColisage_Click(object sender, EventArgs e)
        {
            var ligneCommandes = (Collection<LigneCommande>) dataGridViewCommandRef.Tag;
            var commande = (Commande) panelCommandInfo.Tag;
            await PdfPackagingListGenerator.GeneratePdfPackagingListOf(commande, ligneCommandes);
        }
    }
}