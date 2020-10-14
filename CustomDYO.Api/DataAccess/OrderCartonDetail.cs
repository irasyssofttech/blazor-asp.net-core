using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class OrderCartonDetail
    {
        public int Id { get; set; }
        public int? CartonId { get; set; }
        public int? ProductSkuid { get; set; }
        public int? Quantity { get; set; }

        public virtual ProductSku ProductSku { get; set; }
    }
}
