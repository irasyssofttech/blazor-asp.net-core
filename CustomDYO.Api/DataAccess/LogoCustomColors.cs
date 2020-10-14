using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class LogoCustomColors
    {
        public int LogoCustomColorsId { get; set; }
        public int? DesignPatternId { get; set; }
        public int? ConsumerProductLogoId { get; set; }
        public int? DesignPatternLogoId { get; set; }
        public string CustomColorType { get; set; }
        public string CustomColorValue { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
