using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class WmsfactoryUser
    {
        public int WmsfactoryUserId { get; set; }
        public int? UserId { get; set; }
        public int? FactoryUserId { get; set; }
        public bool? IsPrimary { get; set; }
        public string Remark { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
