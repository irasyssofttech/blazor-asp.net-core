using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class UserStockLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductSkuid { get; set; }
        public int LoggedOnUtc { get; set; }
        public int LoggedBy { get; set; }
    }
}
