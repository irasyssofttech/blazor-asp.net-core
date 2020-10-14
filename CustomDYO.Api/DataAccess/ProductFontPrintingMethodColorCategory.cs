using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ProductFontPrintingMethodColorCategory
    {
        public int ProductFontPrintingMethodColorCategoryId { get; set; }
        public int? ProductFontPrintingMethodId { get; set; }
        public int? ColorCategoryId { get; set; }
        public string EmblishmentType { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
