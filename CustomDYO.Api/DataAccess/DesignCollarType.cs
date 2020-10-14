using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class DesignCollarType
    {
        public int DesignCollarTypeId { get; set; }
        public int OrderDesignId { get; set; }
        public int ConsumerProductPatternId { get; set; }
        public int ConsumerProductCollarTypeId { get; set; }
        public string SelectedCollarType { get; set; }
        public bool IsBrandLevel { get; set; }
        public bool IsNeckTape { get; set; }
        public bool IsCollarTape { get; set; }
        public bool IsCollarStand { get; set; }
        public bool IsButton { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
