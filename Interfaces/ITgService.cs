using WbSailerNotifier.Models;

namespace WbSailerNotifier.Interfaces
{
    public interface ITgService
    {
        Task<bool> SendMsgAsync(string message, CancellationToken ct);
    }
}
