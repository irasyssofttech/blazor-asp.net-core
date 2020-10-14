using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class BrandLogoSize
    {
        public int BrandLogoSizeId { get; set; }
        public int CustomerId { get; set; }
        public string RefCode { get; set; }
        public string RefCodeDisplay { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public string LogoType { get; set; }
        public bool? IsSelected { get; set; }
        public bool? IsActive { get; set; }
    }
}
