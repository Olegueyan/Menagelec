using System.Collections.ObjectModel;
using System.Data.Common;
using System.Threading.Tasks;
using Menagelec.Component;
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

    public static readonly Filter EST_PAYEE = new("estPayee");
    public static readonly Filter EST_EXPEDIEE = new("estExpediee");
    public static readonly Filter CLIENT = new("client");
    public static readonly Filter COMMANDE = new("id");
    
    public static async Task<int> Create(Commande commande)
    {
        return await DatabaseService.OpenAndExecute(async connection =>
        {
            var command = new MySqlCommand(QueryInsertion, connection);
            command.Parameters.Add(new MySqlParameter("@date", commande.Date));
            command.Parameters.Add(new MySqlParameter("@estPayee", commande.EstPayee));
            command.Parameters.Add(new MySqlParameter("@estExpediee", commande.EstExpediee));
            command.Parameters.Add(new MySqlParameter("@client", commande.Client));
            return await command.ExecuteNonQueryAsync();
        });
    }
    
    public static async Task<Commande> Read(int idCommande)
    {
        return await DatabaseService.OpenAndExecute(async connection =>
        {
            var command = new MySqlCommand(QuerySelect, connection);
            command.Parameters.Add(new MySqlParameter("@id", idCommande));
            var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                return new Commande(reader.GetInt32(0))
                {
                    Date = reader.GetDateTime(1),
                    EstPayee = reader.GetInt32(2),
                    EstExpediee = reader.GetInt32(3),
                    Client = await ClientRepository.Read(reader.GetInt32(4)),
                };
            }
            return default;
        });
    }

    public static async Task<int> Update(Commande commande)
    {
        return await DatabaseService.OpenAndExecute(async connection =>
        {
            var command = new MySqlCommand(QueryUpdate, connection);
            command.Parameters.Add(new MySqlParameter("@date", commande.Date));
            command.Parameters.Add(new MySqlParameter("estPayee", commande.EstPayee));
            command.Parameters.Add(new MySqlParameter("@estExpediee", commande.EstExpediee));
            command.Parameters.Add(new MySqlParameter("@client", commande.Client));
            command.Parameters.Add(new MySqlParameter("@id", commande.Id));
            return await command.ExecuteNonQueryAsync();
        });
    }

    public static async Task<int> Delete(int idCommande)
    {
        return await DatabaseService.OpenAndExecute(async connection =>
        {
            var command = new MySqlCommand(QueryDelete, connection);
            command.Parameters.Add(new MySqlParameter("@id", idCommande));
            return await command.ExecuteNonQueryAsync();
        });
    }
    
    public static async Task<Collection<Commande>> ReadAll()
    {
        return await DatabaseService.OpenAndExecute(async connection =>
        {
            var command = new MySqlCommand(QuerySelectAll, connection);
            var reader = await command.ExecuteReaderAsync();
            return await ExtractCommandesFromReader(reader);
        });
    }
    
    public static async Task<Collection<Commande>> ReadFiltered(params FilterStruct[] filters)
    {
        return await DatabaseService.OpenAndExecute(async connection =>
        {
            var query = QuerySelectAll;
            var whereClause = FilterStruct.WhereClause(filters);
            if (whereClause.Length > 0) query = $"{query} WHERE {whereClause}";
            var command = new MySqlCommand(query, connection);
            var reader = await command.ExecuteReaderAsync();
            return await ExtractCommandesFromReader(reader);
        });
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
                Client = await ClientRepository.Read(reader.GetInt32(4)),
            });
        }
        return commandes;
    }
}