using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class DesignCuffSectionFabric
    {
        public int DesignCuffSectionFabricId { get; set; }
        public int DesignCuffSectionId { get; set; }
        public int ConsumerFabricId { get; set; }
        public bool IsDefault { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
