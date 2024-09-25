using WbSailerNotifier.DataAccess.Interfaces;
using WbSailerNotifier.Interfaces;
using WbSailerNotifier.Mappers;

namespace WbSailerNotifier
{
    public class WbWorker : BackgroundService
    {
        private ILogger<WbWorker> Logger { get; }
        private IWbOrderService WbOrderService { get; }
        private IOrderRepository OrderRepository { get; }

        public WbWorker(ILogger<WbWorker> logger, IWbOrderService wbOrderService, IOrderRepository orderRepository)
        {
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
            WbOrderService = wbOrderService ?? throw new ArgumentNullException(nameof(wbOrderService));
            OrderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
        }

        protected override async Task ExecuteAsync(CancellationToken ct)
        {
            while (!ct.IsCancellationRequested)
            {
                try
                {
                    var orders = await WbOrderService.GetListAsync(ct);
                    foreach (var order in orders)
                    {
                        await OrderRepository.CreateAsync(order.ToEntity(), ct);
                    }

                }
                catch (Exception ex)
                {
                    Logger.LogError(ex, $"Error in {nameof(WbWorker)}");
                }

                await Task.Delay(1000 * 60 * 10, ct); // Раз в 10 минут
            }
        }
    }
}
