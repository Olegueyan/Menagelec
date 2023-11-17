using System.Threading.Tasks;
using Menagelec.Data;
using MySql.Data.MySqlClient;

namespace Menagelec.Service;

public static class DatabaseService
{
    public delegate Task<int> Query(MySqlCommand command);
        
    private static MySqlConnection _connection;

    public static void InitializeService(MysqlParameters parameters)
    {
        var url = $"server={parameters.Host};" +
                  $"port={parameters.Port};" +
                  $"user={parameters.User};" +
                  $"password={parameters.Password};" +
                  $"database={parameters.Database};";
        _connection = new MySqlConnection(url);
    }

    public static MySqlConnection GetConnection() => _connection;

    public static async Task<int> Execute(string queryStr, Query query)
    {
        await _connection.OpenAsync();
        var result = await query.Invoke(new MySqlCommand(queryStr, _connection));
        await _connection.CloseAsync();
        return result;
    }
}