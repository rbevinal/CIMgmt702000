using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace CIMgmt702000.CatalogueService
{
    public class CatalogueDbContext : DbContext
    {
        private readonly IServiceProvider serviceProvider;
        private readonly IConfiguration configuration;

        public CatalogueDbContext(DbContextOptions<CatalogueDbContext> dbContextOptions
            , IServiceProvider serviceProvider, IConfiguration configuration)
            :base(dbContextOptions)
        {
            this.serviceProvider = serviceProvider;
            this.configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var loggerFactory = (ILoggerFactory)serviceProvider.GetService(typeof(ILoggerFactory));
            var connectionString = configuration.GetConnectionString("CatalogueString");
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