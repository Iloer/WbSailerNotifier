using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WbSailerNotifier.DataAccess.Models
{
    public class AssemblyTask
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public long Id { get; set; }
        
        public bool? IsNotified { get; set; } = false;

        public string? FullAddress { get; set; }

        public decimal? LongitudeAddress { get; set; }

        public decimal? LatitudeAddress { get; set; }

        public DateTime? Ddate { get; set; }

        public int? SalePrice { get; set; }

        public DateTime? DTimeFrom { get; set; }

        public DateTime? DTimeTo { get; set; }

        public List<string> RequiredMeta { get; set; }

        public string DeliveryType { get; set; }

        public string Comment { get; set; }

        public decimal? ScanPrice { get; set; }

        public string OrderUid { get; set; }

        public string Article { get; set; }

        public string ColorCode { get; set; }

        public string Rid { get; set; }

        public DateTime? CreatedAt { get; set; }

        public List<string> Offices { get; set; }

        public List<string> Skus { get; set; }

        public int? WarehouseId { get; set; }

        public int? NmId { get; set; }

        public int? ChrtId { get; set; }

        public int? Price { get; set; }

        public int? ConvertedPrice { get; set; }

        public int? CurrencyCode { get; set; }

        public int? ConvertedCurrencyCode { get; set; }

        public int? CargoType { get; set; }

        public bool? IsZeroOrder { get; set; }

    }

}
