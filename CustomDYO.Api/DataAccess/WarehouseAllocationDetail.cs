using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class WarehouseAllocationDetail
    {
        public int Id { get; set; }
        public int? SectionDetailId { get; set; }
        public int? ProductSkuid { get; set; }
        public int? Quantity { get; set; }
    }
}
