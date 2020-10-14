using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class DesignCollarTypeDetailFabricColor
    {
        public int DesignCollarTypeDetailFabricColorId { get; set; }
        public int DesignCollarTypeDetailFabricId { get; set; }
        public int ConsumerFabricColorId { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
