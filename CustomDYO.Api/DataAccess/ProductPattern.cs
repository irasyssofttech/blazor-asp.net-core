using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ProductPattern
    {
        public int ProductPatternId { get; set; }
        public int? ProductId { get; set; }
        public string PatterName { get; set; }
        public string PatternCode { get; set; }
        public string PatternImageFilePath { get; set; }
        public string PattenIconFilePath { get; set; }
        public bool? IsDefaultPattern { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
