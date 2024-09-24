using WbSailerNotifier.DataAccess.Interfaces;
using WbSailerNotifier.Interfaces;
using WbSailerNotifier.Mappers;

namespace WbSailerNotifier
{
    public class Worker : BackgroundService
    {
        private ILogger<Worker> Logger { get; }
        private IWbOrderService WbOrderService { get; }
        private IOrderRepository OrderRepository { get; }

        public Worker(ILogger<Worker> logger, IWbOrderService wbOrderService, IOrderRepository orderRepository)
        {
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
            WbOrderService = wbOrderService ?? throw new ArgumentNullException(nameof(wbOrderService));
            OrderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
        }

        protected override async Task ExecuteAsync(CancellationToken ct)
        {
            while (!ct.IsCancellationRequested)
            {

                var orders = await WbOrderService.GetListAsync(ct);
                foreach ( var order in orders)
                {
                    await OrderRepository.CreateAsync(order.ToEntity(), ct);
                }


                await Task.Delay(1000 * 60 * 30, ct);
            }
        }
    }
}
