using System.Text.Json.Serialization;

namespace WbSailerNotifier.Models
{
    public class WbOrderNewListDto
    {
        [JsonPropertyName("orders")]
        public List<WbOrderNewDto> Orders { get; set; }

    }
}
