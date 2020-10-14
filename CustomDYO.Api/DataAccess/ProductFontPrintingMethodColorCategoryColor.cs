using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ProductFontPrintingMethodColorCategoryColor
    {
        public int ProductFontPrintingMethodColorCategoryColorId { get; set; }
        public int? ProductFontPrintingMethodColorCategoryId { get; set; }
        public int? ColorId { get; set; }
        public string EmblishmentType { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
