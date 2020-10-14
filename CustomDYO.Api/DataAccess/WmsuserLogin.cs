using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class WmsuserLogin
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public int UserId { get; set; }
        public int? UserLoginId { get; set; }
        public bool? IsActive { get; set; }
        public bool IsLocked { get; set; }
    }
}
