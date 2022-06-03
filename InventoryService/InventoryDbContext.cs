using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;

namespace CIMgmt702000.InventoryService
{
    public class InventoryDbContext : DbContext
    {
        private readonly IServiceProvider serviceProvider;
        private readonly IConfiguration configuration;

        public InventoryDbContext(DbContextOptions<InventoryDbContext> dbContextOptions
            , IServiceProvider serviceProvider, IConfiguration configuration)
            :base(dbContextOptions)
        {
            this.serviceProvider = serviceProvider;
            this.configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var loggerFactory = (ILoggerFactory)serviceProvider.GetService(typeof(ILoggerFactory));
            var connectionString = configuration.GetConnectionString("InventoryString");
            optionsBuilder.UseSqlServer(connectionString, config =>
            {
                config.EnableRetryOnFailure(3, TimeSpan.FromSeconds(30), null);
            })
            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
            .UseLoggerFactory(loggerFactory);
            
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Domain.EntityConfig.ProductTypeConfig).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}