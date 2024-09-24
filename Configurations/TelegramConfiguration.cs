namespace WbSailerNotifier.Configurations
{
    /// <summary>
    /// Конфигурация WB
    /// </summary>
    public class TelegramConfiguration
    {
        /// <summary>
        /// Адрес WB
        /// </summary>
        public string? BaseUrl { get; set; } = null;
        /// <summary>
        /// Token WB
        /// </summary>
        public string? Token { get; set; } = null;
    }
}