using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ProductPatternSectionFabricColorCategoryColor
    {
        public int ProductPatternSectionFabricColorCategoryColorId { get; set; }
        public int? ProductPatternSectionFabricColorCategoryId { get; set; }
        public int? ColorId { get; set; }
        public bool? IsDefaultColor { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
