using WbSailerNotifier.DataAccess.Models;

namespace WbSailerNotifier.DataAccess.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order> CreateAsync(Order entity, CancellationToken ct = default);
        Task<Order> GetAsync(string srid, CancellationToken ct = default);
        Task<List<Order>> GetListAsync(GetOrdersFilter filter, CancellationToken ct = default);
        Task<bool> SetNotifyAsync(string srid, CancellationToken ct = default);
    }
}