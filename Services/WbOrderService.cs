using Microsoft.Extensions.Options;

using System.Net.Http.Headers;
using System.Net.Http.Json;

using WbSailerNotifier.Configurations;
using WbSailerNotifier.Interfaces;
using WbSailerNotifier.Models;

namespace WbSailerNotifier.Services
{
    public class WbOrderService : IWbOrderService
    {
        private ILogger<WbOrderService> Logger { get; }
        private HttpClient HttpClient { get; }
        private WbConfiguration WbConfig { get; }
        public WbOrderService(ILogger<WbOrderService> logger, HttpClient httpClient, IOptions<WbConfiguration> wbConfig) 
        {
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
            HttpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            WbConfig = wbConfig.Value ?? throw new ArgumentNullException(nameof(wbConfig));

            HttpClient.BaseAddress = new Uri(WbConfig.StatisticBaseUrl ?? "");
        }
        public async Task<List<WbOrderDto>> GetListAsync(CancellationToken ct)
        {
            var route = $"api/v1/supplier/orders?dateFrom=2024-07-24&flag=0";

            var request = new HttpRequestMessage(HttpMethod.Get, route);
            request.Headers.Authorization = new AuthenticationHeaderValue(WbConfig.Token ?? "");


            var response = await HttpClient.SendAsync(request, ct);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<List<WbOrderDto>>(ct) ??
                throw new NullReferenceException("Order models are null");
        }        
    }
}
