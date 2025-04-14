using System.Text;

using WbSailerNotifier.DataAccess.Models;
using WbSailerNotifier.Models;

namespace WbSailerNotifier.Mappers
{
    public static class OrderNewMapper
    {
        public static AssemblyTask ToEntity(this WbOrderNewDto dto)
        {
            return new AssemblyTask
            {
                Id = dto.Id,
                IsNotified = false,
                Article = dto.Article,
                CargoType = dto.CargoType,
                ChrtId = dto.ChrtId,
                ColorCode = dto.ColorCode,
                Comment = dto.Comment,
                ConvertedCurrencyCode = dto.ConvertedCurrencyCode,
                ConvertedPrice = dto.ConvertedPrice,
                CreatedAt = dto.CreatedAt,
                CurrencyCode = dto.CurrencyCode,
                Ddate = dto.Ddate,
                DeliveryType = dto.DeliveryType,
                DTimeFrom = dto.DTimeFrom,
                DTimeTo = dto.DTimeTo,
                FullAddress = dto.Address?.FullAddress,
                LatitudeAddress = dto.Address?.Latitude,
                LongitudeAddress = dto.Address?.Longitude,
                IsZeroOrder = dto.IsZeroOrder,
                NmId = dto.NmId,
                Offices = dto.Offices,
                OrderUid = dto.OrderUid,
                Price = dto.Price,
                RequiredMeta = dto.RequiredMeta,
                Rid = dto.Rid,
                SalePrice = dto.SalePrice,
                ScanPrice = dto.ScanPrice,
                Skus = dto.Skus,
                WarehouseId = dto.WarehouseId
            };
        }

        public static string ToTgMessage(this AssemblyTask dto)
        {
            var res = new StringBuilder();
            res.AppendLine("Новое сборочное задание!")
                .Append("ID задания: ").AppendLine(dto.Rid)
                .Append("Артикул: ").AppendLine(dto.Article)
                .Append("Адрес: ").AppendLine(dto.FullAddress)
                .Append("Комментарий покупателя: ").AppendLine(dto.Comment);
            return res.ToString();
        }
    };
}
