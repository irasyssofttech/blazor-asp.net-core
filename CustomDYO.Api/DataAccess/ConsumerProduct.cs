using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ConsumerProduct
    {
        public int ConsumerProductId { get; set; }
        public int? CustomerId { get; set; }
        public int? ConsumerId { get; set; }
        public int ProductCategoryId { get; set; }
        public int? ProductId { get; set; }
        public int ConsumerOfficeId { get; set; }
        public string ConsumerProductName { get; set; }
        public string ConsumerProductCode { get; set; }
        public string PatternLocation { get; set; }
        public string ThreeDconfig { get; set; }
        public string Description { get; set; }
        public bool? IsCuff { get; set; }
        public string Route { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
