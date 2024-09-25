using Microsoft.EntityFrameworkCore;

namespace WbSailerNotifier.DataAccess.Context
{
    public class DatabaseContextFactory : IDatabaseContextFactory
    {
        private Func<string> ConnectionStringProvider { get; }

        public DatabaseContextFactory(string connectionString)
        {
            if (connectionString == null)
            {
                throw new ArgumentNullException(nameof(connectionString));
            }
            ConnectionStringProvider = () => connectionString;
        }

        public DatabaseContextFactory(Func<string> connectionStringProvider)
        {
            ConnectionStringProvider = connectionStringProvider ??
                                       throw new ArgumentNullException(nameof(connectionStringProvider));
        }

        public DatabaseContext CreateDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            optionsBuilder.UseNpgsql($"{ConnectionStringProvider()}",
                x => x.MigrationsHistoryTable(
                    DatabaseContext.DefaultMigrationHistoryTableName,
                    DatabaseContext.DefaultSchema
                ));
            optionsBuilder.EnableSensitiveDataLogging(true);
            return new DatabaseContext(optionsBuilder.Options);
        }
    }
}
