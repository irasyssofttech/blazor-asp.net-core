using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class DesignPatternFontAlignment
    {
        public int DesignPatternFontAlignmentId { get; set; }
        public int DesignPatternFontId { get; set; }
        public string DisplayText { get; set; }
        public string DisplayValue { get; set; }
        public string SelectedFontAlignment { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
