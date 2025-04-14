using WbSailerNotifier.DataAccess.Interfaces;
using WbSailerNotifier.Interfaces;
using WbSailerNotifier.Mappers;

namespace WbSailerNotifier
{
    public class WbOrdersNewWorker : BackgroundService
    {
        private ILogger<WbOrdersNewWorker> Logger { get; }
        private IWbOrderNewService WbOrderNewService { get; }
        private IAssemblyTaskRepository AssemblyTaskRepository { get; }

        public WbOrdersNewWorker(ILogger<WbOrdersNewWorker> logger, IWbOrderNewService wbOrderNewService, IAssemblyTaskRepository assemblyTaskRepository)
        {
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
            WbOrderNewService = wbOrderNewService ?? throw new ArgumentNullException(nameof(wbOrderNewService));
            AssemblyTaskRepository = assemblyTaskRepository ?? throw new ArgumentNullException(nameof(assemblyTaskRepository));
        }

        protected override async Task ExecuteAsync(CancellationToken ct)
        {
            while (!ct.IsCancellationRequested)
            {
                try
                {
                    var ordersNew = await WbOrderNewService.GetListAsync(ct);
                    foreach (var order in ordersNew)
                    {
                        await AssemblyTaskRepository.CreateAsync(order.ToEntity(), ct);
                    }

                }
                catch (Exception ex)
                {
                    Logger.LogError(ex, $"Error in {nameof(WbOrdersNewWorker)}");
                }

                await Task.Delay(1000 * 60, ct); // Раз в минуту
            }
        }
    }
}
