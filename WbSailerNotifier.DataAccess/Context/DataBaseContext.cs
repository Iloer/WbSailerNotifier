using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

using WbSailerNotifier.DataAccess.Models;

namespace WbSailerNotifier.DataAccess.Context
{
    public class DatabaseContext : DbContext
    {
        public const string DefaultSchema = "wb-sailer-notifier";
        public const string DefaultMigrationHistoryTableName = "__MigrationsHistory";

        public DbSet<Order> Orders { get; set; }
        
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(DefaultSchema);
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
