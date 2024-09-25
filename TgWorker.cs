using WbSailerNotifier.DataAccess.Interfaces;
using WbSailerNotifier.DataAccess.Models;
using WbSailerNotifier.Interfaces;
using WbSailerNotifier.Mappers;

namespace WbSailerNotifier
{
    public class TgWorker : BackgroundService
    {
        private ILogger<TgWorker> Logger { get; }
        private IOrderRepository OrderRepository { get; }
        private ITgService TgService { get; }

        public TgWorker(ILogger<TgWorker> logger, IOrderRepository orderRepository, ITgService tgService)
        {
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
            OrderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            TgService = tgService ?? throw new ArgumentNullException(nameof(tgService));
        }

        protected override async Task ExecuteAsync(CancellationToken ct)
        {
            while (!ct.IsCancellationRequested)
            {
                try
                {
                    var orders = await OrderRepository.GetListAsync(new GetOrdersFilter { IsNotified = false }, ct);
                    foreach (var order in orders)
                    {
                        var isSend = await TgService.SendMsgAsync(order.ToTgMessage(), ct);
                        if (isSend)
                        {
                            await OrderRepository.SetNotifyAsync(order.Srid, ct);
                        }
                    }
                } catch (Exception ex)
                {
                    Logger.LogError(ex, $"Error in {nameof(TgWorker)}");
                }

                await Task.Delay(1000 * 60, ct); // Раз в минуту
            }
        }
    }
}
