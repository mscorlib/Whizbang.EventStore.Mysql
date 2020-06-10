using Whizbang.Core.Data.FluentSqlClient;

namespace Whizbang.EventStore.MySql
{
    public static class MySql
    {
        public static IExecutor With(string connectionString)
        {
            return new MySqlExecutor(connectionString);
        }
    }
}