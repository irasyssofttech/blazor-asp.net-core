using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class DesignPatternLogo
    {
        public int DesignPatternLogoId { get; set; }
        public int DesignPatternId { get; set; }
        public int ConsumerProductLogoId { get; set; }
        public int? PositionNo { get; set; }
        public int LogoId { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
        public string LogoBase64Path { get; set; }
        public bool IsAspectRatio { get; set; }
        public bool IsTextUnderLogo { get; set; }
        public bool? LogoCheckBoxDisable { get; set; }
        public bool? LogoLibraryPositionDisabled { get; set; }
        public bool IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
