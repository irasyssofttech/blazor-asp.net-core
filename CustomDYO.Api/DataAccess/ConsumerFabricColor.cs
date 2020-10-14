using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ConsumerFabricColor
    {
        public int ConsumerFabricColorId { get; set; }
        public int? ConsumerFabricId { get; set; }
        public int? ParentId { get; set; }
        public string ParentType { get; set; }
        public string EmblishmentType { get; set; }
        public string ColorCategoryName { get; set; }
        public string ColorName { get; set; }
        public string HexCode { get; set; }
        public string Pmscode { get; set; }
        public string Description { get; set; }
        public string SelectedColor { get; set; }
        public bool? CheckUncheck { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
