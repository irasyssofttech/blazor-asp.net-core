using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ProductFontAlignment
    {
        public int ProductFontAlignmentId { get; set; }
        public int? ProductId { get; set; }
        public string AlignmentName { get; set; }
        public string EmblishmentType { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
