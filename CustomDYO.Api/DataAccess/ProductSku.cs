using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ProductSku
    {
        public ProductSku()
        {
            OrderCartonDetail = new HashSet<OrderCartonDetail>();
        }

        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Sku { get; set; }
        public byte SizeId { get; set; }
        public int? ColorId { get; set; }
        public string Style { get; set; }
        public decimal Weight { get; set; }
        public string WeightUnit { get; set; }
        public int? ActualQuantity { get; set; }
        public int? ExpectedQuantity { get; set; }
        public int? WarningLevel { get; set; }
        public string OriginalJob { get; set; }
        public string FebricNo { get; set; }
        public string FebricDescription { get; set; }
        public string ProductDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }
        public string Hscode { get; set; }
        public string LanguageDescription { get; set; }

        public virtual ICollection<OrderCartonDetail> OrderCartonDetail { get; set; }
    }
}
