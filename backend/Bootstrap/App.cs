using System;
using System.IO;
using System.Text.Json;

namespace backend.Bootstrap;


public class App
{
    private Server server;
    private Config config;

    private Logger logger;
    
    public App()
    {
        // Config init
        this.config = GetConfig("./Config/config.json");
        // Logger init
        this.logger = new Logger(config);
        // Server init
        this.server = new Server(this.config.Server.HOST, this.config.Server.PORT);
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