using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class OrderDesign
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int? ConsumerProductId { get; set; }
        public string DesignName { get; set; }
        public string DesignNumber { get; set; }
        public int ProductId { get; set; }
        public int? OrderId { get; set; }
        public string ProductDesignImage { get; set; }
        public string ProductDesignImageThumb253X107 { get; set; }
        public string ProductDesignImageThumb100X44 { get; set; }
        public string ProductDesignImageThumb241X105 { get; set; }
        public string ProductDesignImageThumb900X400 { get; set; }
        public string ProductColor { get; set; }
        public string JobSeetImage { get; set; }
        public string JobSeetFile { get; set; }
        public string PickFormFile { get; set; }
        public bool IsDeafultLogo { get; set; }
        public bool? IsCuff { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? OrderDesignStatusId { get; set; }
    }
}
