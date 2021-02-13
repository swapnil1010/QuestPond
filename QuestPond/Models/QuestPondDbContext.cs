
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using Microsoft.Extensions.Configuration;

namespace FewaTelemedicine.Domain
{
    public class FewaContextFactory : IDesignTimeDbContextFactory<QuestPondDbContext>
    {
        // private readonly IHttpContextAccessor accessor;

        public QuestPondDbContext CreateDbContext(string[] args)
        {
            string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            // Build config
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();
            var connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<QuestPondDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new QuestPondDbContext(optionsBuilder.Options);
        }

    }


    public class QuestPondDbContext : DbContext
    {

        public QuestPondDbContext(DbContextOptions<QuestPondDbContext> options)
            : base(options)
        {
            //this.accessor = httpContextAccessor;

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
