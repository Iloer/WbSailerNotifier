using Microsoft.EntityFrameworkCore;

using WbSailerNotifier.DataAccess.Context;

namespace WbSailerNotifier.DataAccess
{
    public class MigrationHelper
    {
        private IDatabaseContextFactory ContextFactory { get; }
        public MigrationHelper(IDatabaseContextFactory contextFactory)
        {
            ContextFactory = contextFactory ?? throw new ArgumentNullException(nameof(contextFactory));
        }
        public async Task MigrateAsync(CancellationToken ct = default)
        {
            await using var context = ContextFactory.CreateDbContext();
            await context.Database.MigrateAsync(ct);
        }
    }
}
