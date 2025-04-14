using WbSailerNotifier.DataAccess.Models;

namespace WbSailerNotifier.DataAccess.Interfaces
{
    public interface IAssemblyTaskRepository
    {
        Task<AssemblyTask> CreateAsync(AssemblyTask entity, CancellationToken ct = default);
        Task<AssemblyTask> GetAsync(long id, CancellationToken ct = default);
        Task<List<AssemblyTask>> GetListAsync(GetOrdersByNotifyFilter filter, CancellationToken ct = default);
        Task<bool> SetNotifyAsync(long id, CancellationToken ct = default);
    }
}