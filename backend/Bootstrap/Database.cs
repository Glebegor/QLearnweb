using backend.Core.Common.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;

namespace backend.Bootstrap
{
    public class Database
    {
        private readonly Config config;
        private readonly IServiceCollection services;

        public Database(Config config, IServiceCollection services)
        {
            config = config;
            services = services;
        }

        public void ConfigureDatabase()
        {
            string connectionString = $"Host={config.Database.HOST};Port={config.Database.PORT};Database={config.Database.NAME};Username={config.Database.USER};Password={config.Database.PASSWORD}";

            this.services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(connectionString));

            this.services.AddControllersWithViews();
        }
    }
}
