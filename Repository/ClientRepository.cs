using System.Threading.Tasks;
using Menagelec.Entity;
using Menagelec.Service;
using MySql.Data.MySqlClient;

namespace Menagelec.Repository;

public static class ClientRepository
{
    // TODO : gestion des exceptions, Read (unknown id)
    
    private const string QueryInsertion = "INSERT INTO client (civilite, nom, prenom, adresse, ville, cp, mail, tel) VALUES (@civilite, @nom, @prenom, @adresse, @ville, @cp, @mail, @tel)";
    private const string QuerySelect = "SELECT * FROM client WHERE idClient = @idClient";
    private const string QueryUpdate = "UPDATE client SET civilite = @civilite, nom = @nom, prenom = @prenom, adresse = @adresse, ville = @ville, cp = @cp, mail = @mail, tel = @tel WHERE idClient = @idClient";
    private const string QueryDelete = "DELETE FROM client WHERE idClient = @idClient";
    
    public static async Task<int> Create(Client client)
    {
        return await DatabaseService.OpenAndExecute(async connection =>
        {
            var command = new MySqlCommand(QueryInsertion, connection);
            command.Parameters.Add(new MySqlParameter("@civilite", client.Civilite));
            command.Parameters.Add(new MySqlParameter("@nom", client.Nom));
            command.Parameters.Add(new MySqlParameter("@prenom", client.Prenom));
            command.Parameters.Add(new MySqlParameter("@adresse", client.Adresse));
            command.Parameters.Add(new MySqlParameter("@ville", client.Ville));
            command.Parameters.Add(new MySqlParameter("@cp", client.Cp));
            command.Parameters.Add(new MySqlParameter("@mail", client.Mail));
            command.Parameters.Add(new MySqlParameter("@tel", client.Tel));
            return await command.ExecuteNonQueryAsync();
        });
    }
    
    public static async Task<Client> Read(int idClient)
    {
        return await DatabaseService.OpenAndExecute(async connection =>
        {
            var command = new MySqlCommand(QuerySelect, connection);
            command.Parameters.Add(new MySqlParameter("@idClient", idClient));
            var reader = await command.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return new Client(reader.GetInt32(0))
                {
                    Civilite = reader.GetString(1),
                    Nom = reader.GetString(2),
                    Prenom = reader.GetString(3),
                    Adresse = reader.GetString(4),
                    Ville = reader.GetString(5),
                    Cp = reader.GetString(6),
                    Mail = reader.GetString(7),
                    Tel = reader.GetString(8)
                };
            }
            return default;
        });
    }

    public static async Task<int> Update(Client client)
    {
        return await DatabaseService.OpenAndExecute(async connection =>
        {
            var command = new MySqlCommand(QueryUpdate, connection);
            command.Parameters.Add(new MySqlParameter("@civilite", client.Civilite));
            command.Parameters.Add(new MySqlParameter("@nom", client.Nom));
            command.Parameters.Add(new MySqlParameter("@prenom", client.Prenom));
            command.Parameters.Add(new MySqlParameter("@adresse", client.Adresse));
            command.Parameters.Add(new MySqlParameter("@ville", client.Ville));
            command.Parameters.Add(new MySqlParameter("@cp", client.Cp));
            command.Parameters.Add(new MySqlParameter("@mail", client.Mail));
            command.Parameters.Add(new MySqlParameter("@tel", client.Tel));
            command.Parameters.Add(new MySqlParameter("@idClient", client.IdClient));
            return await command.ExecuteNonQueryAsync();
        });
    }

    public static async Task<int> Delete(int idClient)
    {
        return await DatabaseService.OpenAndExecute(async connection =>
        {
            var command = new MySqlCommand(QueryDelete, connection);
            command.Parameters.Add(new MySqlParameter("@idClient", idClient));
            return await command.ExecuteNonQueryAsync();
        });
    }
}