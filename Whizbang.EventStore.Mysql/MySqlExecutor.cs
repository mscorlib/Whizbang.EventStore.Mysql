using MySql.Data.MySqlClient;
using Whizbang.Core.Data.FluentSqlClient;

namespace Whizbang.EventStore.MySql
{
    public class MySqlExecutor : Executor
    {
        public MySqlExecutor(string connectionString)
            : base(
                () => new MySqlConnection(connectionString),
                () => new MySqlCommand(),
                (cmd, paramName, value) => ((MySqlCommand) cmd).Parameters.AddWithValue(paramName, value))
        {
        }
    }
}