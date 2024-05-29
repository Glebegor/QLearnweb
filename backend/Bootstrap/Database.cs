using Npgsql;

namespace backend.Bootstrap
{
    public class Database
    {
        private readonly Config config;
        public NpgsqlConnection Connection;

        public Database(Config config)
        {
            config = config;
            
            string connectionString = $"Host={config.Database.HOST};Port={config.Database.PORT};Database={config.Database.NAME};Username={config.Database.USER};Password={config.Database.PASSWORD}"; 
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            this.Connection = connection;

        }
    }
}
