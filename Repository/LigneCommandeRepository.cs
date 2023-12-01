using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Menagelec.Entity;
using Menagelec.Service;
using MySql.Data.MySqlClient;

namespace Menagelec.Repository;

public static class LigneCommandeRepository
{
    // TODO : Specific - Read, Delete and Update
    
    private const string QueryInsertion = "INSERT INTO lignecommande (produit, commande, quantite) VALUES (@produit, @commande, @quantite)";
    
    private const string QueryLigneCommande = "SELECT * FROM lignecommande WHERE commande = @commande";
    
    public static async Task<int> Create(LigneCommande ligneCommande)
    {
        return await DatabaseService.OpenAndExecute(async connection =>
        {
            var command = new MySqlCommand(QueryInsertion, connection);
            command.Parameters.Add(new MySqlParameter("@produit", ligneCommande.Produit));
            command.Parameters.Add(new MySqlParameter("@commande", ligneCommande.Commande));
            command.Parameters.Add(new MySqlParameter("@quantite", ligneCommande.Quantite));
            return await command.ExecuteNonQueryAsync(); 
        });
    }

    public static async Task<Collection<LigneCommande>> ReadAllLigneCommandeWithAsync(int idCommande)
    {
        return await DatabaseService.OpenAndExecute(async connection =>
        {
            var ligneCommandes = new Collection<LigneCommande>();
            var command = new MySqlCommand(QueryLigneCommande, connection);
            command.Parameters.Add(new MySqlParameter("@commande", idCommande));
            var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                ligneCommandes.Add(new LigneCommande
                {
                    Produit = await ProduitRepository.Read(reader.GetInt32(0)),
                    Commande = await CommandeRepository.Read(reader.GetInt32(1)),
                    Quantite = reader.GetInt32(2)
                });
            }
            return ligneCommandes; 
        });
    }
}