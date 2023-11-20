using System.Collections.ObjectModel;
using System.Data.Common;
using System.Threading.Tasks;
using Menagelec.Entity;
using Menagelec.Service;
using MySql.Data.MySqlClient;

namespace Menagelec.Repository;

public static class CommandeRepository
{
    // TODO : gestion des exceptions, Read (unknown id)
    
    private const string QueryInsertion = "INSERT INTO commande (date, estPayee, estExpediee, client) VALUES (@date, @estPayee, @estExpediee, @client)";
    private const string QuerySelect = "SELECT * FROM commande WHERE id = @id";
    private const string QueryUpdate = "UPDATE commande SET date = @date, estPayee = @estPayee, estExpediee = @estExpediee, client = @client WHERE id = @id";
    private const string QueryDelete = "DELETE FROM commande WHERE id = @id";
    
    private const string QuerySelectAll = "SELECT * FROM commande";
    
    private const string QuerySelectEstPayee = "SELECT * FROM commande WHERE estPayee = 1";
    private const string QuerySelectEstExpediee = "SELECT * FROM commande WHERE estExpediee = 1";
    
    public static async Task<int> Create(Commande commande)
    {
        var connection = DatabaseService.GetConnection();
        await connection.OpenAsync();
        var command = new MySqlCommand(QueryInsertion, connection);
        command.Parameters.Add(new MySqlParameter("@date", commande.Date));
        command.Parameters.Add(new MySqlParameter("@estPayee", commande.EstPayee));
        command.Parameters.Add(new MySqlParameter("@estExpediee", commande.EstExpediee));
        command.Parameters.Add(new MySqlParameter("@client", commande.Client));
        var result = await command.ExecuteNonQueryAsync();
        await connection.CloseAsync();
        return result;
    }
    
    public static async Task<Commande> Read(int idCommande)
    {
        var connection = DatabaseService.GetConnection();
        await connection.OpenAsync();
        var command = new MySqlCommand(QuerySelect, connection);
        command.Parameters.Add(new MySqlParameter("@id", idCommande));
        var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            var commande = new Commande(reader.GetInt32(0))
            {
                Date = reader.GetDateTime(1),
                EstPayee = reader.GetInt32(2),
                EstExpediee = reader.GetInt32(3),
                Client = reader.GetInt32(4),
            };
            await connection.CloseAsync();
            return commande;
        }
        return default;
    }

    public static async Task<int> Update(Commande commande)
    {
        var connection = DatabaseService.GetConnection();
        await connection.OpenAsync();
        var command = new MySqlCommand(QueryUpdate, connection);
        command.Parameters.Add(new MySqlParameter("@date", commande.Date));
        command.Parameters.Add(new MySqlParameter("estPayee", commande.EstPayee));
        command.Parameters.Add(new MySqlParameter("@estExpediee", commande.EstExpediee));
        command.Parameters.Add(new MySqlParameter("@client", commande.Client));
        command.Parameters.Add(new MySqlParameter("@id", commande.Id));
        var result = await command.ExecuteNonQueryAsync();
        await connection.CloseAsync();
        return result;
    }

    public static async Task<int> Delete(int idCommande)
    {
        var connection = DatabaseService.GetConnection();
        await connection.OpenAsync();
        var command = new MySqlCommand(QueryDelete, connection);
        command.Parameters.Add(new MySqlParameter("@id", idCommande));
        var result = await command.ExecuteNonQueryAsync();
        await connection.CloseAsync();
        return result;
    }
    
    public static async Task<Collection<Commande>> ReadAll()
    {
        var connection = DatabaseService.GetConnection();
        await connection.OpenAsync();
        var command = new MySqlCommand(QuerySelectAll, connection);
        var reader = await command.ExecuteReaderAsync();
        var commandes = await ExtractCommandesFromReader(reader);
        await connection.CloseAsync();
        return commandes;
    }
    
    public static async Task<Collection<Commande>> ReadAllEstPayee()
    {
        var connection = DatabaseService.GetConnection();
        await connection.OpenAsync();
        var command = new MySqlCommand(QuerySelectEstPayee, connection);
        var reader = await command.ExecuteReaderAsync();
        var commandes = await ExtractCommandesFromReader(reader);
        await connection.CloseAsync();
        return commandes;
    }
    
    public static async Task<Collection<Commande>> ReadAllEstExpediee()
    {
        var connection = DatabaseService.GetConnection();
        await connection.OpenAsync();
        var command = new MySqlCommand(QuerySelectEstExpediee, connection);
        var reader = await command.ExecuteReaderAsync();
        var commandes = await ExtractCommandesFromReader(reader);
        await connection.CloseAsync();
        return commandes;
    }

    private static async Task<Collection<Commande>> ExtractCommandesFromReader(DbDataReader reader)
    {
        var commandes = new Collection<Commande>();
        while (await reader.ReadAsync())
        {
            commandes.Add(new Commande(reader.GetInt32(0))
            {
                Date = reader.GetDateTime(1),
                EstPayee = reader.GetInt32(2),
                EstExpediee = reader.GetInt32(3),
                Client = reader.GetInt32(4),
            });
        }
        return commandes;
    }
}