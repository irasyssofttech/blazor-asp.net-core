using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class NumberofApproval
    {
        public int NumberofApprovalId { get; set; }
        public int? UserId { get; set; }
        public int? NoOfApprovalForLogo { get; set; }
        public int? NoOfApprovalForOrder { get; set; }
        public int? TotalApprovalUser { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
