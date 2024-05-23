using System;
using System.IO;
using System.Text.Json;

namespace backend.Bootstrap;


public class App
{
    private Server server;
    private Config config;

    private Logger logger;
    private Database database;
    
    public App()
    {
        // Config init
        this.config = GetConfig("./Config/config.json");
        
        // Db init
        this.database = new Database(this.config);
        
        // Logger init
        this.logger = new Logger(this.config, this.database);
        
        // Server init
        this.server = new Server(this.config, this.logger, this.database);
    }

    public Config GetConfig(string path)
    {
        string jsonString = File.ReadAllText(path);
        Config config = JsonSerializer.Deserialize<Config>(jsonString);
        return config;
    }
    public void Run()
    {
        server.Run();
    }
}