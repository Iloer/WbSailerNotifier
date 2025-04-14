using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using WbSailerNotifier.DataAccess.Context;
using WbSailerNotifier.DataAccess.Interfaces;
using WbSailerNotifier.DataAccess.Models;

namespace WbSailerNotifier.DataAccess.Repositories
{
    public class AssemblyTaskRepository : IAssemblyTaskRepository
    {
        protected ILogger<AssemblyTaskRepository> Logger { get; set; }
        protected IDatabaseContextFactory ContextFactory { get; set; }
        public AssemblyTaskRepository(ILogger<AssemblyTaskRepository> logger, IDatabaseContextFactory contextFactory) {
            ContextFactory = contextFactory ?? throw new ArgumentNullException(nameof(contextFactory));
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<AssemblyTask> CreateAsync(AssemblyTask entity, CancellationToken ct = default)
        {
            ArgumentNullException.ThrowIfNull(entity, nameof(entity));

            Logger.LogDebug($"Create or Update order in database");

            await using var context = ContextFactory.CreateDbContext();

            var isExist = await context.AssemblyTasks.ContainsAsync(entity, ct);
            if (!isExist)
            {
                await context.AssemblyTasks.AddAsync(entity, ct);
                await context.SaveChangesAsync(ct);
            }
            return entity;
        }

        public async Task<AssemblyTask> GetAsync(long id, CancellationToken ct = default)
        {
            await using var context = ContextFactory.CreateDbContext();
            return await context.AssemblyTasks.SingleOrDefaultAsync(x => x.Id == id, ct) ??
                throw new KeyNotFoundException($"AssemblyTask not found");
        }

        public async Task<List<AssemblyTask>> GetListAsync(GetOrdersByNotifyFilter filter, CancellationToken ct = default)
        {
            await using var context = ContextFactory.CreateDbContext();
            return await context.AssemblyTasks.Where(x => x.IsNotified == filter.IsNotified).ToListAsync(ct);
        }

        public async Task<bool> SetNotifyAsync(long id, CancellationToken ct = default)
        {
            await using var context = ContextFactory.CreateDbContext();
            try
            {
                await context.AssemblyTasks
                    .Where(o => o.Id == id)
                    .ExecuteUpdateAsync(setter => setter.SetProperty(o => o.IsNotified, true), ct);
                return true;
            }catch
            {
                Logger.LogError("Notify property is not update;");
                throw;
            }

        }
    }
}
