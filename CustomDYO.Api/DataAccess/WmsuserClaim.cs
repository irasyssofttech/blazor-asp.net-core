using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class WmsuserClaim
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
    }
}
