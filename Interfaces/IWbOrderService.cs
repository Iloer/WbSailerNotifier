using WbSailerNotifier.Models;

namespace WbSailerNotifier.Interfaces
{
    public interface IWbOrderService
    {
        Task<List<WbOrderDto>> GetListAsync(CancellationToken ct);
    }
}
