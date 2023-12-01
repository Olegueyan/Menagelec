using System;
using System.Data;
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

    /**
     * Task<int> Number of rows affected
     * Task<T> Entity of Entities
     */
    
    public delegate Task<T> AsyncActionOnConnection<T>(MySqlConnection connection);
    
    public static async Task<T> OpenAndExecute<T>(AsyncActionOnConnection<T> asyncAction)
    {
        if (_connection.State == ConnectionState.Open) return await asyncAction.Invoke(_connection);
        await _connection.OpenAsync();
        var task = await asyncAction.Invoke(_connection);   
        await _connection.CloseAsync();
        return task;
    }
}