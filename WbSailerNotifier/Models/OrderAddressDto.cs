using System.Text;
using System.Text.Json.Serialization;

namespace WbSailerNotifier.Models
{
    public class OrderAddressDto
    {
        /// <summary>
        /// Адрес доставки.
        /// </summary>
        /// <value>Адрес доставки.</value>
        [JsonPropertyName("fullAddress")]
        public string FullAddress { get; set; }

        /// <summary>
        /// Координата долготы
        /// </summary>
        /// <value>Координата долготы</value>
        [JsonPropertyName("longitude")]
        public decimal? Longitude { get; set; }

        /// <summary>
        /// Координаты широты
        /// </summary>
        /// <value>Координаты широты</value>
        [JsonPropertyName("latitude")]
        public decimal? Latitude { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderAddress {\n");
            sb.Append("  FullAddress: ").Append(FullAddress).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
