using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class OrderCarton
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public string CartonNo { get; set; }
        public string CartonDisplayName { get; set; }
        public bool IsClosed { get; set; }
    }
}
