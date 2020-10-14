using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class OrderFactoryUser
    {
        public int OrderFactoryUserId { get; set; }
        public int? UserId { get; set; }
        public int? NotifyUserId { get; set; }
        public bool? IsApprovalTo { get; set; }
        public bool? IsNotifyTo { get; set; }
        public string Remark { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
