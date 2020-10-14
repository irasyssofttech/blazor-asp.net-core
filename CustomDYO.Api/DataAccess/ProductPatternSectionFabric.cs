using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ProductPatternSectionFabric
    {
        public int ProductPatternSectionFabricId { get; set; }
        public int? ProductPatternSectionId { get; set; }
        public int? FabricId { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
