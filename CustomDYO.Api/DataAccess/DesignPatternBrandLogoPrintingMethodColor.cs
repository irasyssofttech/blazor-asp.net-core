using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class DesignPatternBrandLogoPrintingMethodColor
    {
        public int DesignPatternBrandLogoPrintingMethodColorId { get; set; }
        public int DesignPatternBrandLogoPrintingMethodId { get; set; }
        public int ConsumerProductColorId { get; set; }
        public bool IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
