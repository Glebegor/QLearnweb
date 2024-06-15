using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args[0] == "dev")
            {
                args[0] = "appsettings.Development.json";
            } else if (args[0] == "prod")
            {
                args[0] = "appsettings.Product.json";
            } else if (args[0] == "test")
            {
                args[0] = "appsettings.Test.json";
            }
            else
            {
                throw new Exception("Invalid environment");
            }
            var host = CreateHostBuilder(args).Build();

            
            host.Run();
        }
        
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    config.SetBasePath(Directory.GetCurrentDirectory());
                    config.AddJsonFile(args[0], optional: false, reloadOnChange: true);
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {

                    var configuration = new ConfigurationBuilder()
                        .AddJsonFile(args[0])
                        .Build();
                    
                    var port = configuration.GetValue<string>("Server:Port");
                    var host = configuration.GetValue<string>("Server:Host");
                    webBuilder.UseUrls("http://" + host + ":" + port);
                    webBuilder.UseStartup<Startup>();
                });
    }
}

