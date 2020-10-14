using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class Font
    {
        public int FontId { get; set; }
        public string FontName { get; set; }
        public string FontCode { get; set; }
        public bool? IsActive { get; set; }
    }
}
