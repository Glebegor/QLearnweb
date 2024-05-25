using System;
using System.IO;
using System.Text.Json;
using backend.Api.Controller;
using DotNetEnv;

namespace backend.Bootstrap;

public class App
{
    private Server server;
    private Config config;

    private Logger logger;
    // private Database database;
    
    public App()
    {
        // Config init
        this.config = GetConfig("./Config/config.json");
        
        // Db init
        // this.database = new Database(this.config);
        
        // Logger init
        this.logger = new Logger(this.config);
        
        // Server init
        this.server = new Server(this.config, this.logger);
    }

    public Config GetConfig(string path)
    {
        // config.json
        string jsonString = File.ReadAllText(path);
        Config config = JsonSerializer.Deserialize<Config>(jsonString);
        
        // .env
        string envPath = "./.env";
        try
        {
            Env.Load(envPath);

            config.Server.SECRETKEY = Env.GetString("SECRET_KEY");
            config.Database.PASSWORD = Env.GetString("DB_PASSWORD");
            config.Database.PASSWORDADMIN = Env.GetString("DB_ADMIN_PASSWORD");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading .env file: {ex.Message}");
        }
        
        return config;
    }
    public void Run()
    {
        
        server.Run(new Controller(), this.logger);
    }
}