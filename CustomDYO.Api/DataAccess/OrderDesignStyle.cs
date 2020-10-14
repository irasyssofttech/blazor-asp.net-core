using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class OrderDesignStyle
    {
        public int Id { get; set; }
        public int OrderDesignId { get; set; }
        public string Section { get; set; }
        public string Color { get; set; }
    }
}
