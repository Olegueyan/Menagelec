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
}