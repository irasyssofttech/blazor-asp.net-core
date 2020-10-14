using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ConsumerProductFont
    {
        public int ConsumerProductFontId { get; set; }
        public int? ParentId { get; set; }
        public string ParentType { get; set; }
        public string FontName { get; set; }
        public string FontCode { get; set; }
        public string Description { get; set; }
        public string SelectedFont { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
