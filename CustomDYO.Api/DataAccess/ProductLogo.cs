using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ProductLogo
    {
        public int ProductLogoId { get; set; }
        public int? ProductId { get; set; }
        public string Position { get; set; }
        public string PositionDescription { get; set; }
        public string AdditionalInformation { get; set; }
        public decimal? LogoMinHeight { get; set; }
        public decimal? LogoMaxHeight { get; set; }
        public decimal? LogoMinWidth { get; set; }
        public decimal? LogoMaxWidth { get; set; }
        public bool? IsAspectRation { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
