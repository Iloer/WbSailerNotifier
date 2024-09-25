using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using WbSailerNotifier.DataAccess.Context;
using WbSailerNotifier.DataAccess.Interfaces;
using WbSailerNotifier.DataAccess.Models;

namespace WbSailerNotifier.DataAccess.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        protected ILogger<OrderRepository> Logger { get; set; }
        protected IDatabaseContextFactory ContextFactory { get; set; }
        public OrderRepository(ILogger<OrderRepository> logger, IDatabaseContextFactory contextFactory) {
            ContextFactory = contextFactory ?? throw new ArgumentNullException(nameof(contextFactory));
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Order> CreateAsync(Order entity, CancellationToken ct = default)
        {
            ArgumentNullException.ThrowIfNull(entity, nameof(entity));

            Logger.LogDebug($"Create or Update order in database");

            await using var context = ContextFactory.CreateDbContext();

            var isExist = await context.Orders.ContainsAsync(entity, ct);
            if (!isExist)
            {
                await context.Orders.AddAsync(entity, ct);
                await context.SaveChangesAsync(ct);
            }
            return entity;
        }

        public async Task<Order> GetAsync(string srid, CancellationToken ct = default)
        {
            await using var context = ContextFactory.CreateDbContext();
            return await context.Orders.SingleOrDefaultAsync(x => x.Srid == srid, ct) ??
                throw new KeyNotFoundException($"Order not found");
        }

        public async Task<List<Order>> GetListAsync(GetOrdersFilter filter, CancellationToken ct = default)
        {
            await using var context = ContextFactory.CreateDbContext();
            return await context.Orders.Where(x => x.IsNotified == filter.IsNotified).ToListAsync(ct);
        }

        public async Task<bool> SetNotifyAsync(string srid, CancellationToken ct = default)
        {
            await using var context = ContextFactory.CreateDbContext();
            try
            {
                await context.Orders
                    .Where(o => o.Srid == srid)
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
