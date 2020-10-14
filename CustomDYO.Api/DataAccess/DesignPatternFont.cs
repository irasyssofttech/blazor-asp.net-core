using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class DesignPatternFont
    {
        public int DesignPatternFontId { get; set; }
        public int DesignPatternId { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
        public string EmblishmentType { get; set; }
        public string EmblishmentTypeValue { get; set; }
        public string EmblishMentTypePosition { get; set; }
        public string EmblishmentTypePositionValue { get; set; }
        public bool IsAcpectRatio { get; set; }
        public bool? NameHeightDisable { get; set; }
        public bool? NameWidthDisable { get; set; }
        public bool? NameCheckBoxDisable { get; set; }
        public bool? NumberHeightDisable { get; set; }
        public bool? NumberWidthDisable { get; set; }
        public bool? NumberCheckBoxDisable { get; set; }
        public bool IsTextInsideNumber { get; set; }
        public bool IsBrandLogoInsideNumber { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
