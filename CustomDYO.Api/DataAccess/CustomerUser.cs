using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class CustomerUser
    {
        public int CustomerUserId { get; set; }
        public int? CustomerId { get; set; }
        public int? UserId { get; set; }
        public string UserType { get; set; }
        public bool? IsPrimary { get; set; }
        public string Remark { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
