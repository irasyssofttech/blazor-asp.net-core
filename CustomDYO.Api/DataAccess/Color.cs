using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class Color
    {
        public int ColorId { get; set; }
        public int? ColorCategoryId { get; set; }
        public string ColorName { get; set; }
        public string HexCode { get; set; }
        public string Pmscode { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
    }
}
