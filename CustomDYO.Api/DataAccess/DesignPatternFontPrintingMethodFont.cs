using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class DesignPatternFontPrintingMethodFont
    {
        public int DesignPatternFontPrintingMethodFontId { get; set; }
        public int DesignPatternFontPrintingMethodId { get; set; }
        public int ConsumerProductFontId { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
