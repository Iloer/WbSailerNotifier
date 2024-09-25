using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WbSailerNotifier.DataAccess.Models
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public required string Srid { get; set; }
        public bool? IsNotified { get; set; } = false;   
        public DateTime? Date { get; set; }
        public DateTime? LastChangeDate { get; set; }
        public required string WarehouseName { get; set; }
        public required string CountryName { get; set; }
        public required string OblastOkrugName { get; set; }
        public required string RegionName { get; set; }
        public required string SupplierArticle { get; set; }
        public int? NmId { get; set; }
        public required string Barcode { get; set; }
        public required string Category { get; set; }
        public required string Subject { get; set; }
        public required string Brand { get; set; }
        public required string TechSize { get; set; }
        public int? IncomeID { get; set; }
        public bool? IsSupply { get; set; }
        public bool? IsRealization { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? DiscountPercent { get; set; }
        public decimal? Spp { get; set; }
        public decimal? FinishedPrice { get; set; }
        public decimal? PriceWithDisc { get; set; }
        public bool? IsCancel { get; set; }
        public DateTime? CancelDate { get; set; }
        public required string OrderType { get; set; }
        public required string Sticker { get; set; }
        public required string GNumber { get; set; }
    }
}
