using System.Threading.Tasks;
using Menagelec.Entity;
using Menagelec.Service;
using MySql.Data.MySqlClient;

namespace Menagelec.Repository;

public static class ProduitRepository
{
    // TODO : gestion des exceptions, Read (unknown id)
    
    private const string QueryInsertion = "INSERT INTO produit (designation, description, dateAjout, qte, prix, fichierImage, pk_fournisseur) VALUES (@designation, @description, @dateAjout, @qte, @prix, @fichierImage, @pk_fournisseur)";
    private const string QuerySelect = "SELECT * FROM produit WHERE idProduit = @idProduit";
    private const string QueryUpdate = "UPDATE produit SET designation = @designation, description = @description, dateAjout = @dateAjout, qte = @qte, prix = @prix, fichierImage = @fichierImage, pk_fournisseur = @pk_fournisseur WHERE idProduit = @idProduit";
    private const string QueryDelete = "DELETE FROM produit WHERE idProduit = @idProduit";
    
    public static async Task<int> Create(Produit produit)
    {
        var connection = DatabaseService.GetConnection();
        await connection.OpenAsync();
        var command = new MySqlCommand(QueryInsertion, connection);
        command.Parameters.Add(new MySqlParameter("@designation", produit.Designation));
        command.Parameters.Add(new MySqlParameter("@description", produit.Description));
        command.Parameters.Add(new MySqlParameter("@dateAjout", produit.DateAjout));
        command.Parameters.Add(new MySqlParameter("@qte", produit.Qte));
        command.Parameters.Add(new MySqlParameter("@prix", produit.Prix));
        command.Parameters.Add(new MySqlParameter("@fichierImage", produit.FichierImage));
        command.Parameters.Add(new MySqlParameter("@pk_fournisseur", produit.PkFournisseur));
        var result = await command.ExecuteNonQueryAsync();
        await connection.CloseAsync();
        return result;
    }
    
    public static async Task<Produit> Read(int idProduit)
    {
        var connection = DatabaseService.GetConnection();
        await connection.OpenAsync();
        var command = new MySqlCommand(QuerySelect, connection);
        command.Parameters.Add(new MySqlParameter("@idProduit", idProduit));
        var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            var produit = new Produit(reader.GetInt32(0))
            {
                Designation = reader.GetString(1),
                Description = reader.GetString(2),
                DateAjout = reader.GetDateTime(3),
                Qte = reader.GetInt32(4),
                Prix = reader.GetDouble(5),
                FichierImage = reader.GetString(6),
                PkFournisseur = reader.GetInt32(7),
            };
            await connection.CloseAsync();
            return produit;
        }
        return default;
    }

    public static async Task<int> Update(Produit produit)
    {
        var connection = DatabaseService.GetConnection();
        await connection.OpenAsync();
        var command = new MySqlCommand(QueryUpdate, connection);
        command.Parameters.Add(new MySqlParameter("@designation", produit.Designation));
        command.Parameters.Add(new MySqlParameter("@description", produit.Description));
        command.Parameters.Add(new MySqlParameter("@dateAjout", produit.DateAjout));
        command.Parameters.Add(new MySqlParameter("@qte", produit.Qte));
        command.Parameters.Add(new MySqlParameter("@prix", produit.Prix));
        command.Parameters.Add(new MySqlParameter("@fichierImage", produit.FichierImage));
        command.Parameters.Add(new MySqlParameter("@pk_fournisseur", produit.PkFournisseur));
        command.Parameters.Add(new MySqlParameter("@idProduit", produit.IdProduit));
        var result = await command.ExecuteNonQueryAsync();
        await connection.CloseAsync();
        return result;
    }

    public static async Task<int> Delete(int idProduit)
    {
        var connection = DatabaseService.GetConnection();
        await connection.OpenAsync();
        var command = new MySqlCommand(QueryDelete, connection);
        command.Parameters.Add(new MySqlParameter("@idProduit", idProduit));
        var result = await command.ExecuteNonQueryAsync();
        await connection.CloseAsync();
        return result;
    }
}