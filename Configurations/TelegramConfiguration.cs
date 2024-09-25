namespace WbSailerNotifier.Configurations
{
    /// <summary>
    /// Конфигурация
    /// </summary>
    public class TelegramConfiguration
    {
        /// <summary>
        /// Адрес
        /// </summary>
        public string? BaseUrl { get; set; } = null;
        /// <summary>
        /// Token
        /// </summary>
        public string? Token { get; set; } = null;
        /// <summary>
        /// ChatId
        /// </summary>
        public string? ChatId { get; set; } = null;
    }
}