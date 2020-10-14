using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ConsumerProductPatternSection
    {
        public int ConsumerProductPatternSectionId { get; set; }
        public int ConsumerProductPatternId { get; set; }
        public string SectionName { get; set; }
        public int? PositionNo { get; set; }
        public int? ConsumerProductSectionId { get; set; }
        public string CuffChange { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
