using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class OrderPickupDetail
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? OrderDesignDetailId { get; set; }
        public int? SectionDetailId { get; set; }
        public int? ProductSkuid { get; set; }
        public int? RequiredQty { get; set; }
        public int? PickedQty { get; set; }
    }
}
