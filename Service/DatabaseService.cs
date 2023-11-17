using System.Threading.Tasks;
using Menagelec.Data;
using MySql.Data.MySqlClient;

namespace Menagelec.Service;

public static class DatabaseService
{
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
}