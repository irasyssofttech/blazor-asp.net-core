using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class DesignPatternLogoPrintingMethod
    {
        public int DesignPatternLogoPrintingMethodId { get; set; }
        public int? DesignPatternLogoId { get; set; }
        public int ConsumerProductPrintingMethodId { get; set; }
        public int PrintingMethodId { get; set; }
        public bool IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
