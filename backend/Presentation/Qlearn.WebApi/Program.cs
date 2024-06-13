using DotNetEnv;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
[assembly: ApiController]

namespace Qlearn.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Env.Load();
            
            var host = CreateHostBuilder(args).Build();
            host.Run();
        }
        
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                    config.AddJsonFile($"appsettings.{context.HostingEnvironment.EnvironmentName}.json", optional: true, reloadOnChange: true);
                    config.AddJsonFile("config.json", optional: true, reloadOnChange: true);
                    config.AddEnvironmentVariables();
                    config.Add(new DotEnvConfigSource());
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }    
    
    public class DotEnvConfigProvider : ConfigurationProvider
    {
        public override void Load()
        {
            Env.Load();

            foreach (System.Collections.DictionaryEntry envVar in Environment.GetEnvironmentVariables())
            {
                Data[envVar.Key.ToString()] = envVar.Value.ToString();
            }
        }
    }

    public class DotEnvConfigSource : IConfigurationSource
    {
        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return new DotEnvConfigProvider();
        }
    }
}