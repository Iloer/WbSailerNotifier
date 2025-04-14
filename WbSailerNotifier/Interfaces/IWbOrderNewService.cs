using WbSailerNotifier.Models;

namespace WbSailerNotifier.Interfaces
{
    public interface IWbOrderNewService
    {
        Task<List<WbOrderNewDto>> GetListAsync(CancellationToken ct);
    }
}
