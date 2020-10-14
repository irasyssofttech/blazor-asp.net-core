using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class UserModuleScreen
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ModuleScreenId { get; set; }
        public int ModuleScreenDetailId { get; set; }
        public bool IsDefault { get; set; }
        public bool IsAllowed { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdateBy { get; set; }
    }
}
