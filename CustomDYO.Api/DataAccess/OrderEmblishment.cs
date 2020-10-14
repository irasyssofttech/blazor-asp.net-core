using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class OrderEmblishment
    {
        public int Id { get; set; }
        public int OrderDesignId { get; set; }
        public string EmblishmentType { get; set; }
        public string PrintMethod { get; set; }
        public string LogoImage { get; set; }
        public decimal? LogoWidth { get; set; }
        public decimal? LogoHeight { get; set; }
        public bool? IsAspectRatio { get; set; }
        public bool? IsLogoFromLogoLibrary { get; set; }
        public string DimensionUnit { get; set; }
        public string Color { get; set; }
        public string FontFamily { get; set; }
        public string LogoThumbImage { get; set; }
    }
}
