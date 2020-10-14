using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class DesignPatternFontPrintingMethod
    {
        public int DesignPatternFontPrintingMethodId { get; set; }
        public int DesignPatternFontId { get; set; }
        public int ConsumerProductPrintingMethodId { get; set; }
        public int PrintingMethodId { get; set; }
        public string ConsumerProductPrintingMethodName { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
