using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class DesignPatternBrandLogo
    {
        public int DesignPatternBrandLogoId { get; set; }
        public int DesignPatternId { get; set; }
        public int ConsumerProductBrandLogoId { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
        public string SizeRefCode { get; set; }
        public string LogoBase64Path { get; set; }
        public bool? AspectRatio { get; set; }
        public bool IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
