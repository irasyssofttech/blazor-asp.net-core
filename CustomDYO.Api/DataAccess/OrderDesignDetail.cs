using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class OrderDesignDetail
    {
        public int Id { get; set; }
        public int OrderDesignId { get; set; }
        public string PlayerName { get; set; }
        public string PlayerNumber { get; set; }
        public short Quantity { get; set; }
        public int ProductSkuid { get; set; }
        public short? PickedQuantity { get; set; }
    }
}
