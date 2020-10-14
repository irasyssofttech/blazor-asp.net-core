using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ProductBrandLogo
    {
        public int ProductBrandLogoId { get; set; }
        public int? ProductId { get; set; }
        public string BrandLogoPosition { get; set; }
        public string BrandLogoPositionDescription { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
