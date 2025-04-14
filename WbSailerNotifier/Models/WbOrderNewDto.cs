using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace WbSailerNotifier.Models
{
    public class WbOrderNewDto
    {
        /// <summary>
        /// ID сборочного задания в Маркетплейсе
        /// </summary>
        /// <value>ID сборочного задания в Маркетплейсе</value>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [JsonPropertyName("address")]
        public OrderAddressDto Address { get; set; }

        /// <summary>
        /// Планируемая дата доставки.<br>  Поле отображается для схем:   - `dbs` — доставка силами продавца   - `edbs` — экспресс-доставка силами продавца   - `wbgo` — доставка курьером WB   - `СГТ` — заказы сверхгабаритных товаров (<code>cargoType: 2</code>) для схем fbs — доставка на склад Wildberries — и dbs. 
        /// </summary>
        /// <value>Планируемая дата доставки.<br>  Поле отображается для схем:   - `dbs` — доставка силами продавца   - `edbs` — экспресс-доставка силами продавца   - `wbgo` — доставка курьером WB   - `СГТ` — заказы сверхгабаритных товаров (<code>cargoType: 2</code>) для схем fbs — доставка на склад Wildberries — и dbs. </value>
        [JsonPropertyName("ddate")]
        public DateTime? Ddate { get; set; }

        /// <summary>
        /// Цена в валюте продажи с учётом скидки продавца, без учёта скидки WB Клуба, умноженная на 100 
        /// </summary>
        /// <value>Цена в валюте продажи с учётом скидки продавца, без учёта скидки WB Клуба, умноженная на 100 </value>
        [JsonPropertyName("salePrice")]
        public int? SalePrice { get; set; }

        /// <summary>
        /// Время доставки \"с\".<br> Поле отображается только для edbs (экспресс-доставка силами продавца)
        /// </summary>
        /// <value>Время доставки \"с\".<br> Поле отображается только для edbs (экспресс-доставка силами продавца)</value>
        [JsonPropertyName("dTimeFrom")]
        public DateTime? DTimeFrom { get; set; }

        /// <summary>
        /// Время доставки \"до\".<br> Поле отображается только для edbs (экспресс-доставка силами продавца)
        /// </summary>
        /// <value>Время доставки \"до\".<br> Поле отображается только для edbs (экспресс-доставка силами продавца)</value>
        [JsonPropertyName("dTimeTo")]
        public DateTime? DTimeTo { get; set; }

        /// <summary>
        /// Перечень метаданных, которые необходимо добавить в сборочное задание.  <br> На данный момент обязательным к добавлению является только UIN, при его наличии в перечне.              
        /// </summary>
        /// <value>Перечень метаданных, которые необходимо добавить в сборочное задание.  <br> На данный момент обязательным к добавлению является только UIN, при его наличии в перечне.              </value>
        [JsonPropertyName("requiredMeta")]
        public List<string> RequiredMeta { get; set; }

        /// <summary>
        /// <dl> <dt>Тип доставки:</dt> <dd>fbs - доставка на склад Wildberries</dd> <dd>dbs - доставка силами продавца</dd> <dd>edbs - экспресс-доставка силами продавца</dd> <dd>wbgo - доставка курьером WB</dd> </dl> 
        /// </summary>
        /// <value><dl> <dt>Тип доставки:</dt> <dd>fbs - доставка на склад Wildberries</dd> <dd>dbs - доставка силами продавца</dd> <dd>edbs - экспресс-доставка силами продавца</dd> <dd>wbgo - доставка курьером WB</dd> </dl> </value>
        [JsonPropertyName("deliveryType")]
        public string DeliveryType { get; set; }

        /// <summary>
        /// Комментарий покупателя
        /// </summary>
        /// <value>Комментарий покупателя</value>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Цена приёмки в копейках. Появляется после фактической приёмки заказа. Для данного метода всегда будет возвращаться null
        /// </summary>
        /// <value>Цена приёмки в копейках. Появляется после фактической приёмки заказа. Для данного метода всегда будет возвращаться null</value>
        [JsonPropertyName("scanPrice")]
        public decimal? ScanPrice { get; set; }

        /// <summary>
        /// ID транзакции для группировки сборочных заданий. Сборочные задания в одной корзине покупателя будут иметь одинаковый orderUID
        /// </summary>
        /// <value>ID транзакции для группировки сборочных заданий. Сборочные задания в одной корзине покупателя будут иметь одинаковый orderUID</value>
        [JsonPropertyName("orderUid")]
        public string OrderUid { get; set; }

        /// <summary>
        /// Артикул продавца
        /// </summary>
        /// <value>Артикул продавца</value>
        [JsonPropertyName("article")]
        public string Article { get; set; }

        /// <summary>
        /// Код цвета (только для колеруемых товаров)
        /// </summary>
        /// <value>Код цвета (только для колеруемых товаров)</value>
        [JsonPropertyName("colorCode")]
        public string ColorCode { get; set; }

        /// <summary>
        /// ID сборочного задания в системе Wildberries
        /// </summary>
        /// <value>ID сборочного задания в системе Wildberries</value>
        [JsonPropertyName("rid")]
        public string Rid { get; set; }

        /// <summary>
        /// Дата создания сборочного задания (RFC3339)
        /// </summary>
        /// <value>Дата создания сборочного задания (RFC3339)</value>
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Список офисов, куда следует привезти товар
        /// </summary>
        /// <value>Список офисов, куда следует привезти товар</value>
        [JsonPropertyName("offices")]
        public List<string> Offices { get; set; }

        /// <summary>
        /// Массив баркодов товара
        /// </summary>
        /// <value>Массив баркодов товара</value>
        [JsonPropertyName("skus")]
        public List<string> Skus { get; set; }

        /// <summary>
        /// ID склада продавца, на который поступило сборочное задание
        /// </summary>
        /// <value>ID склада продавца, на который поступило сборочное задание</value>
        [JsonPropertyName("warehouseId")]
        public int? WarehouseId { get; set; }

        /// <summary>
        /// Артикул WB
        /// </summary>
        /// <value>Артикул WB</value>
        [JsonPropertyName("nmId")]
        public int? NmId { get; set; }

        /// <summary>
        /// ID размера товара в системе Wildberries
        /// </summary>
        /// <value>ID размера товара в системе Wildberries</value>
        [JsonPropertyName("chrtId")]
        public int? ChrtId { get; set; }

        /// <summary>
        /// Цена в валюте продажи с учётом всех скидок, кроме суммы по WB Кошельку, умноженная на 100. Код валюты продажи — в поле `currencyCode` 
        /// </summary>
        /// <value>Цена в валюте продажи с учётом всех скидок, кроме суммы по WB Кошельку, умноженная на 100. Код валюты продажи — в поле `currencyCode` </value>
        [JsonPropertyName("price")]
        public int? Price { get; set; }

        /// <summary>
        /// Цена в валюте страны продавца с учетом всех скидок, кроме суммы по WB Кошельку, умноженная на 100. Предоставляется в информационных целях.
        /// </summary>
        /// <value>Цена в валюте страны продавца с учетом всех скидок, кроме суммы по WB Кошельку, умноженная на 100. Предоставляется в информационных целях.</value>
        [JsonPropertyName("convertedPrice")]
        public int? ConvertedPrice { get; set; }

        /// <summary>
        /// Код валюты продажи (ISO 4217)
        /// </summary>
        /// <value>Код валюты продажи (ISO 4217)</value>
        [JsonPropertyName("currencyCode")]
        public int? CurrencyCode { get; set; }

        /// <summary>
        /// Код валюты страны продавца (ISO 4217)
        /// </summary>
        /// <value>Код валюты страны продавца (ISO 4217)</value>
        [JsonPropertyName("convertedCurrencyCode")]
        public int? ConvertedCurrencyCode { get; set; }

        /// <summary>
        /// <dl> <dt>Тип товара:</dt> <dd>1 - обычный</dd> <dd>2 - СГТ (Сверхгабаритный товар)</dd> <dd>3 - КГТ (Крупногабаритный товар). Не используется на данный момент.</dd> </dl> 
        /// </summary>
        /// <value><dl> <dt>Тип товара:</dt> <dd>1 - обычный</dd> <dd>2 - СГТ (Сверхгабаритный товар)</dd> <dd>3 - КГТ (Крупногабаритный товар). Не используется на данный момент.</dd> </dl> </value>
        [JsonPropertyName("cargoType")]
        public int? CargoType { get; set; }

        /// <summary>
        /// Признак заказа сделанного на нулевой остаток товара. (<code>false</code> - заказ сделан на товар с ненулевым остатком, <code>true</code> - заказ сделан на товар с остатком равным нулю. Такой заказ можно отменить без штрафа за отмену)
        /// </summary>
        /// <value>Признак заказа сделанного на нулевой остаток товара. (<code>false</code> - заказ сделан на товар с ненулевым остатком, <code>true</code> - заказ сделан на товар с остатком равным нулю. Такой заказ можно отменить без штрафа за отмену)</value>
        [JsonPropertyName("isZeroOrder")]
        public bool IsZeroOrder { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderNew {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Ddate: ").Append(Ddate).Append("\n");
            sb.Append("  SalePrice: ").Append(SalePrice).Append("\n");
            sb.Append("  DTimeFrom: ").Append(DTimeFrom).Append("\n");
            sb.Append("  DTimeTo: ").Append(DTimeTo).Append("\n");
            sb.Append("  RequiredMeta: ").Append(RequiredMeta).Append("\n");
            sb.Append("  DeliveryType: ").Append(DeliveryType).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  ScanPrice: ").Append(ScanPrice).Append("\n");
            sb.Append("  OrderUid: ").Append(OrderUid).Append("\n");
            sb.Append("  Article: ").Append(Article).Append("\n");
            sb.Append("  ColorCode: ").Append(ColorCode).Append("\n");
            sb.Append("  Rid: ").Append(Rid).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Offices: ").Append(Offices).Append("\n");
            sb.Append("  Skus: ").Append(Skus).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  NmId: ").Append(NmId).Append("\n");
            sb.Append("  ChrtId: ").Append(ChrtId).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  ConvertedPrice: ").Append(ConvertedPrice).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  ConvertedCurrencyCode: ").Append(ConvertedCurrencyCode).Append("\n");
            sb.Append("  CargoType: ").Append(CargoType).Append("\n");
            sb.Append("  IsZeroOrder: ").Append(IsZeroOrder).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

    }
}
