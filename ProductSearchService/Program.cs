using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIMgmt702000.ProductSearchService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ILogger<Program> logger = null;
            try
            {
                var host = CreateHostBuilder(args).Build();
                using (var scope = host.Services.CreateScope())
                {
                    logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
                    var dbContext = scope.ServiceProvider.GetRequiredService<ProductSearchDbContext>();
                    dbContext.Database.Migrate();
                }
                host.Run();
            }
            catch (Exception ex)
            {
                logger?.LogError(ex, ex.Message);
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
