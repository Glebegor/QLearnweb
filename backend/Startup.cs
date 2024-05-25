using System;
using System.IO;
using System.Text.Json;
using backend.Api.Controller;
using backend.Core.Common.Database;
using backend.Core.Interface.Database;
using backend.Bootstrap;
using DotNetEnv;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace backend;


public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    
    public IConfiguration Configuration { get; }
    
    public void ConfigureServices(IServiceCollection services)
    {
        var config = GetConfig("./Config/config.json");
        var database = new Database(config, services);
        database.ConfigureDatabase(); 
        services.AddScoped<IDbService, DbService>();
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
}