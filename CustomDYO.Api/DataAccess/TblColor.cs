using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class TblColor
    {
        public int ConsumerProductColorId { get; set; }
        public int? ConsumerProductId { get; set; }
        public int? ConsumerProductPatternId { get; set; }
        public int? ColorId { get; set; }
        public int? ColorCategoryId { get; set; }
        public int? ConsumerProductPrintingMethodId { get; set; }
        public string ColorName { get; set; }
        public string HexCode { get; set; }
        public string Pmscode { get; set; }
        public string ColorCategoryName { get; set; }
        public string EmblishmentType { get; set; }
        public string Description { get; set; }
        public bool? IsDefault { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }
    }
}
