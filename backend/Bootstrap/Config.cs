namespace backend.Bootstrap;


public class ServerConfig
{
    public string HOST { get; set; }
    public int PORT { get; set; }
}

public class DatabaseConfig
{
    public string HOST { get; set; }
    public int PORT { get; set; }
    public string NAME { get; set; }
    public string USER { get; set; }
}

public class Config
{
    public ServerConfig Server { get; set; }
    public DatabaseConfig Database { get; set; }
}

