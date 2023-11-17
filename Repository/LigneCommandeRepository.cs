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
    private const string QuerySelectAll = "SELECT * FROM lignecommande";
    
    public static async Task<int> Create(LigneCommande ligneCommande)
    {
        var connection = DatabaseService.GetConnection();
        await connection.OpenAsync();
        var command = new MySqlCommand(QueryInsertion, connection);
        command.Parameters.Add(new MySqlParameter("@produit", ligneCommande.Produit));
        command.Parameters.Add(new MySqlParameter("@commande", ligneCommande.Commande));
        command.Parameters.Add(new MySqlParameter("@quantite", ligneCommande.Quantite));
        var result = await command.ExecuteNonQueryAsync();
        await connection.CloseAsync();
        return result;
    }

    public static async Task<Collection<LigneCommande>> ReadAll()
    {
        var connection = DatabaseService.GetConnection();
        await connection.OpenAsync();
        var ligneCommandes = new Collection<LigneCommande>();
        var command = new MySqlCommand(QueryInsertion, connection);
        var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            ligneCommandes.Add(new LigneCommande
            {
                Produit = reader.GetInt32(0),
                Commande = reader.GetInt32(1),
                Quantite = reader.GetInt32(2)
            });
        }
        await connection.CloseAsync();
        return ligneCommandes;
    }
}