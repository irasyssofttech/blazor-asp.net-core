using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class UserStock
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductSkuid { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
        public int UpdatedBy { get; set; }
    }
}
