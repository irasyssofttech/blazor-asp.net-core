using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class DesignPatternLogoPrintingMethodColor
    {
        public int DesignPatternLogoPrintingMethodColorId { get; set; }
        public int DesignPatternLogoPrintingMethodId { get; set; }
        public int ConsumerProductColorId { get; set; }
        public string ColorName { get; set; }
        public bool IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
