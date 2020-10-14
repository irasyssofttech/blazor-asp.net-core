using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class DesignPatternSection
    {
        public int DesignPatternSectionId { get; set; }
        public int DesignPatternId { get; set; }
        public int ConsumerProductPatternSectionId { get; set; }
        public int ConsumerProductPatternId { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
