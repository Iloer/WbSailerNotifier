using Microsoft.Extensions.Options;

using System.Web;

using WbSailerNotifier.Configurations;
using WbSailerNotifier.Interfaces;

namespace WbSailerNotifier.Services
{
    public class TgService : ITgService
    {
        private ILogger<TgService> Logger { get; }
        private HttpClient HttpClient { get; }
        private TelegramConfiguration TgConfig { get; }
        public TgService(ILogger<TgService> logger, HttpClient httpClient, IOptions<TelegramConfiguration> tgConfig)
        {
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
            HttpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            TgConfig = tgConfig.Value ?? throw new ArgumentNullException(nameof(tgConfig));

            HttpClient.BaseAddress = new Uri(TgConfig.BaseUrl ?? "");
        }
        public async Task<bool> SendMsgAsync(string message, CancellationToken ct)
        {
            var route = $"/bot{TgConfig.Token}/sendMessage?chat_id={TgConfig.ChatId}&text={HttpUtility.UrlEncode(message)}&parse_mode=HTML";

            var request = new HttpRequestMessage(HttpMethod.Get, route);

            try
            {
                var response = await HttpClient.SendAsync(request, ct);

                response.EnsureSuccessStatusCode();

                return true;

            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Telegram send error");
                return false;
            }
        }
    }
}
