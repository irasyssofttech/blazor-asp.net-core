using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class Size
    {
        public byte Id { get; set; }
        public string Size1 { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public int? OrderNumber { get; set; }
        public string Type { get; set; }
    }
}
