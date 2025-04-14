namespace WbSailerNotifier.Configurations
{
    /// <summary>
    /// Конфигурация WB
    /// </summary>
    public class WbConfiguration
    {
        /// <summary>
        /// Адрес WB
        /// </summary>
        public string? StatisticBaseUrl { get; set; } = "https://statistics-api.wildberries.ru";
        /// <summary>
        /// Адрес WB
        /// </summary>
        public string? MarketplaceApiBaseUrl { get; set; } = "https://marketplace-api.wildberries.ru";
        /// <summary>
        /// Token WB
        /// </summary>
        public string? Token { get; set; } = "";
    }
}