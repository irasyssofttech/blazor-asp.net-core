using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class DesignCuff
    {
        public int DesignCuffId { get; set; }
        public int ConsumerProductPatternId { get; set; }
        public int OrderDesignId { get; set; }
        public int ConsumerProductCuffId { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
