using System;
using System.Threading.Tasks;
using Menagelec.Data;
using Menagelec.Entity;
using Menagelec.Repository;
using Menagelec.Service;
using MySql.Data.MySqlClient;
using NUnit.Framework;

namespace MenagelecTest
{
    [TestFixture]
    public class TestsCrud
    {
        // Look at database
        
        private const int ClientStarterId = 3125;
        private const int CommandeStarterId = 1536;
        private const int ProduitStarterId = 501;
        
        // Datetime
        private static readonly DateTime Now = DateTime.Today;
        
        [OneTimeSetUp]
        public async Task RunBeforeAnyTests()
        {
            DatabaseService.InitializeService(new MysqlParameters
            {
                Host = "localhost",
                Port = "3306",
                Database = "menagelec_test",
                User = "root",
                Password = ""
            });
            
            await ResetClientAutoIncrement();
            await ResetCommandeAutoIncrement();
            await ResetProduitAutoIncrement();
        }

        [OneTimeTearDown]
        public async Task RunAfterAnyTests()
        {
            await ResetClientAutoIncrement();
            await ResetCommandeAutoIncrement();
            await ResetProduitAutoIncrement();
        }

        private static async Task ResetClientAutoIncrement()
        {
            // Reset AUTO_INCREMENT for client
            
            var queryClientResetAutoIncrement = $"ALTER TABLE client AUTO_INCREMENT = {ClientStarterId}";
            var connection = DatabaseService.GetConnection();
            await connection.OpenAsync();
            using (var command = new MySqlCommand(queryClientResetAutoIncrement, connection))
            {
                await command.ExecuteNonQueryAsync();
            }
            await connection.CloseAsync();
        }
        
        private static async Task ResetCommandeAutoIncrement()
        {
            // Reset AUTO_INCREMENT for commande
            
            var queryCommandeResetAutoIncrement = $"ALTER TABLE commande AUTO_INCREMENT = {CommandeStarterId}";
            var connection = DatabaseService.GetConnection();
            await connection.OpenAsync();
            using (var command = new MySqlCommand(queryCommandeResetAutoIncrement, connection))
            {
                await command.ExecuteNonQueryAsync();
            }
            await connection.CloseAsync();
        }
        
        private static async Task ResetProduitAutoIncrement()
        {
            // Reset AUTO_INCREMENT for produit
            
            var queryProduitResetAutoIncrement = $"ALTER TABLE produit AUTO_INCREMENT = {ProduitStarterId}";
            var connection = DatabaseService.GetConnection();
            await connection.OpenAsync();
            using (var command = new MySqlCommand(queryProduitResetAutoIncrement, connection))
            {
                await command.ExecuteNonQueryAsync();
            }
            await connection.CloseAsync();
        }
        
        [Test, Order(1)]
        public async Task TestCreationClient()
        {
            var client = new Client
            {
                Civilite = "M",
                Nom = "Test Nom",
                Prenom = "Test Prenom",
                Adresse = "Test Adresse",
                Ville = "Test Ville",
                Cp = "Test Cp",
                Mail = "Test Mail",
                Tel = "Test Tel"
            };
            var result = await ClientRepository.Create(client);
            Assert.That(result, Is.EqualTo(1));
        }
        
        [Test, Order(2)]
        public async Task TestReadClient()
        {
            var clientChecker = new Client(ClientStarterId)
            {
                Civilite = "M",
                Nom = "Test Nom",
                Prenom = "Test Prenom",
                Adresse = "Test Adresse",
                Ville = "Test Ville",
                Cp = "Test Cp",
                Mail = "Test Mail",
                Tel = "Test Tel"
            };
            var result = await ClientRepository.Read(ClientStarterId);
            Assert.That(result, Is.EqualTo(clientChecker));
        }
        
        [Test, Order(3)]
        public async Task TestUpdateClient()
        {
            var client = await ClientRepository.Read(ClientStarterId);
            client.Nom = "Update Nom";
            var result = await ClientRepository.Update(client);
            Assert.That(result, Is.EqualTo(1));
        }
        
        [Test, Order(4)]
        public async Task TestDeleteClient()
        {
            var result = await ClientRepository.Delete(ClientStarterId);
            Assert.That(result, Is.EqualTo(1));
        }
        
        [Test, Order(1)]
        public async Task TestCreationCommande()
        {
            var commande = new Commande
            {
                Date = Now,
                EstPayee = 0,
                EstExpediee = 0,
                Client = 1
            };
            var result = await CommandeRepository.Create(commande);
            Assert.That(result, Is.EqualTo(1));
        }
        
        [Test, Order(2)]
        public async Task TestReadCommande()
        {
            var commandeChecker = new Commande(CommandeStarterId)
            {
                Date = Now,
                EstPayee = 0,
                EstExpediee = 0,
                Client = 1
            };
            var result = await CommandeRepository.Read(CommandeStarterId);
            Assert.That(result, Is.EqualTo(commandeChecker));
        }
        
        [Test, Order(3)]
        public async Task TestUpdateCommande()
        {
            var commande = await CommandeRepository.Read(CommandeStarterId);
            commande.EstPayee = 0;
            var result = await CommandeRepository.Update(commande);
            Assert.That(result, Is.EqualTo(1));
        }
        
        [Test, Order(4)]
        public async Task TestDeleteCommande()
        {
            var result = await CommandeRepository.Delete(CommandeStarterId);
            Assert.That(result, Is.EqualTo(1));
        }
        
        [Test, Order(1)]
        public async Task TestCreationProduit()
        {
            var produit = new Produit
            {
                Designation = "Test Designation",
                Description = "Test Description",
                DateAjout = Now,
                Qte = 1,
                Prix = 100.2,
                FichierImage = "Test Fichier Image",
                PkFournisseur = 1
            };
            var result = await ProduitRepository.Create(produit);
            Assert.That(result, Is.EqualTo(1));
        }
        
        [Test, Order(2)]
        public async Task TestReadProduit()
        {
            var produitChecker = new Produit(ProduitStarterId)
            {
                Designation = "Test Designation",
                Description = "Test Description",
                DateAjout = Now,
                Qte = 1,
                Prix = 100.2,
                FichierImage = "Test Fichier Image",
                PkFournisseur = 1
            };
            var result = await ProduitRepository.Read(ProduitStarterId);
            Assert.That(result, Is.EqualTo(produitChecker));
        }
        
        [Test, Order(3)]
        public async Task TestUpdateProduit()
        {
            var produit = await ProduitRepository.Read(ProduitStarterId);
            produit.Description = "Update Description";
            var result = await ProduitRepository.Update(produit);
            Assert.That(result, Is.EqualTo(1));
        }
        
        [Test, Order(4)]
        public async Task TestDeleteProduit()
        {
            var result = await ProduitRepository.Delete(ProduitStarterId);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}