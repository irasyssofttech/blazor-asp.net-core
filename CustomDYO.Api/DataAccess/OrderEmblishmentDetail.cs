using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class OrderEmblishmentDetail
    {
        public int Id { get; set; }
        public int OrderEmblishmentId { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
    }
}
