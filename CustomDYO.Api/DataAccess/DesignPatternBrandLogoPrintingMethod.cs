using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class DesignPatternBrandLogoPrintingMethod
    {
        public int DesignPatternBrandLogoPrintingMethodId { get; set; }
        public int DesignPatternBrandLogoId { get; set; }
        public int ConsumerProductPrintingMethodId { get; set; }
        public int PrintingMethodId { get; set; }
        public bool IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
