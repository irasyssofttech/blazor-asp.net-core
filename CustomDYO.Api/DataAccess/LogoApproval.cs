using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class LogoApproval
    {
        public int LogoApprovalId { get; set; }
        public int UserId { get; set; }
        public int LogoId { get; set; }
        public string Comment { get; set; }
        public bool? IsApprove { get; set; }
        public bool? IsDisapprove { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
