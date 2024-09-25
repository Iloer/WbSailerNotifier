using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WbSailerNotifier.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class WbOrderDto
    {
        [JsonPropertyName("date")]
        public DateTime? Date { get; set; }

        [JsonPropertyName("lastChangeDate")]
        public DateTime? LastChangeDate { get; set; }

        [JsonPropertyName("warehouseName")]
        public string WarehouseName { get; set; }

        [JsonPropertyName("countryName")]
        public string CountryName { get; set; }

        [JsonPropertyName("oblastOkrugName")]
        public string OblastOkrugName { get; set; }

        [JsonPropertyName("regionName")]
        public string RegionName { get; set; }

        [JsonPropertyName("supplierArticle")]
        public string SupplierArticle { get; set; }

        [JsonPropertyName("nmId")]
        public int? NmId { get; set; }

        [JsonPropertyName("barcode")]
        public string Barcode { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        [JsonPropertyName("brand")]
        public string Brand { get; set; }

        [JsonPropertyName("techSize")]
        public string TechSize { get; set; }

        [JsonPropertyName("incomeID")]
        public int? IncomeID { get; set; }

        [JsonPropertyName("isSupply")]
        public bool? IsSupply { get; set; }

        [JsonPropertyName("isRealization")]
        public bool? IsRealization { get; set; }

        [JsonPropertyName("totalPrice")]
        public decimal? TotalPrice { get; set; }

        [JsonPropertyName("discountPercent")]
        public int? DiscountPercent { get; set; }

        [JsonPropertyName("spp")]
        public decimal? Spp { get; set; }

        [JsonPropertyName("finishedPrice")]
        public decimal? FinishedPrice { get; set; }

        [JsonPropertyName("priceWithDisc")]
        public decimal? PriceWithDisc { get; set; }

        [JsonPropertyName("isCancel")]
        public bool? IsCancel { get; set; }

        [JsonPropertyName("cancelDate")]
        public DateTime? CancelDate { get; set; }

        [JsonPropertyName("orderType")]
        public string OrderType { get; set; }

        [JsonPropertyName("sticker")]
        public string Sticker { get; set; }

        [JsonPropertyName("gNumber")]
        public string GNumber { get; set; }

        [JsonPropertyName("srid")]
        public string Srid { get; set; }
    }

}
