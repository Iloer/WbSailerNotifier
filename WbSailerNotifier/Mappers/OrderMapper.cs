using System.Text;

using WbSailerNotifier.DataAccess.Models;
using WbSailerNotifier.Models;

namespace WbSailerNotifier.Mappers
{
    public static class OrderMapper
    {
        public static Order ToEntity(this WbOrderDto dto)
        {
            return new Order
            {
                Srid = dto.Srid,
                IsNotified = false,
                Barcode = dto.Barcode,
                Brand = dto.Brand,
                Category = dto.Category,
                CountryName = dto.CountryName,
                GNumber = dto.GNumber,
                OblastOkrugName = dto.OblastOkrugName,
                OrderType = dto.OrderType,
                RegionName = dto.RegionName,
                Sticker = dto.Sticker,
                Subject = dto.Subject,
                SupplierArticle = dto.SupplierArticle,
                TechSize = dto.TechSize,
                WarehouseName = dto.WarehouseName,
                CancelDate = dto.CancelDate,
                Date = dto.Date,
                DiscountPercent = dto.DiscountPercent,
                FinishedPrice = dto.FinishedPrice,
                IncomeID = dto.IncomeID,
                IsCancel = dto.IsCancel,
                IsRealization = dto.IsRealization,
                IsSupply = dto.IsSupply,
                LastChangeDate = dto.LastChangeDate,
                NmId = dto.NmId,
                PriceWithDisc = dto.PriceWithDisc,
                Spp = dto.Spp,
                TotalPrice = dto.TotalPrice
            };
        }

        public static string ToTgMessage(this Order dto)
        {
            var res = new StringBuilder();
            res.AppendLine("Новый заказ!")
                .Append("Заказ: ").AppendLine(dto.GNumber)
                .Append("Артикул: ").AppendLine(dto.SupplierArticle)
                .Append("Товар: ").AppendLine(dto.Subject)
                .Append("Размер: ").AppendLine(dto.TechSize)
                .Append("Ссылка: ").AppendLine("{Тут будет ссылка}");
            return res.ToString();
        }
    };
}
