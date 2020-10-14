using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class OrderStatus
    {
        public byte Id { get; set; }
        public string StatusName { get; set; }
        public string StatusDisplay { get; set; }
        public string Image { get; set; }
        public string Type { get; set; }
    }
}
