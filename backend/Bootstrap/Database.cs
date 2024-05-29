using Npgsql;

namespace backend.Bootstrap
{
    public class Database
    {
        private readonly Config config;

        public Database(Config config)
        {
            config = config;
        }

        public void ConfigureDatabase()
        {
            string connectionString = $"Host={config.Database.HOST};Port={config.Database.PORT};Database={config.Database.NAME};Username={config.Database.USER};Password={config.Database.PASSWORD}";
            using NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();

            using NpgsqlCommand ping = new NpgsqlCommand("SELECT * FROM users;", connection);

            using NpgsqlDataReader reader = ping.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader["column_name"]);
            }
        }
    }
}
