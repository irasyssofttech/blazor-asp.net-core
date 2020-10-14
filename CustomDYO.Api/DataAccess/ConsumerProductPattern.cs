using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ConsumerProductPattern
    {
        public int ConsumerProductPatternId { get; set; }
        public int? ConsumerProductId { get; set; }
        public string ConsumerProductName { get; set; }
        public string PatternName { get; set; }
        public string PatternCode { get; set; }
        public string PatternImageFilePath { get; set; }
        public string PattenIconFilePath { get; set; }
        public string Specification { get; set; }
        public string ThreeDpattern { get; set; }
        public string BaseColor { get; set; }
        public bool? IsVerticalText { get; set; }
        public bool? SelectedVerticalText { get; set; }
        public string VerticalTextPosition { get; set; }
        public string VerticalTextPositionValue { get; set; }
        public string VerticalTextAlignment { get; set; }
        public string VerticalTextMinWidth { get; set; }
        public string VerticalTextMaxWidth { get; set; }
        public string VerticalTextMinHeight { get; set; }
        public string VerticalTextMaxHeight { get; set; }
        public string VerticalTextWidth { get; set; }
        public string VerticalTextHeight { get; set; }
        public bool? VerticalTextIsAspectRatio { get; set; }
        public bool? VerticalTextHeightDisable { get; set; }
        public bool? VerticalTextWidthDisable { get; set; }
        public bool? VerticalTextCheckBoxDisable { get; set; }
        public bool? IsName { get; set; }
        public bool? SelectedName { get; set; }
        public string NamePosition { get; set; }
        public string NamePositionValue { get; set; }
        public string NameAlignment { get; set; }
        public string NameMinWidth { get; set; }
        public string NameMaxWidth { get; set; }
        public string NameMinHeight { get; set; }
        public string NameMaxHeight { get; set; }
        public string NameWidth { get; set; }
        public string NameHeight { get; set; }
        public bool? NameIsAspectRatio { get; set; }
        public bool? NameHeightDisable { get; set; }
        public bool? NameWidthDisable { get; set; }
        public bool? NameCheckBoxDisable { get; set; }
        public bool? IsNumber { get; set; }
        public bool? SelectedNumber { get; set; }
        public string NumberPosition { get; set; }
        public string NumberPositionValue { get; set; }
        public string NumberMinWidth { get; set; }
        public string NumberMaxWidth { get; set; }
        public string NumberMinHeight { get; set; }
        public string NumberMaxHeight { get; set; }
        public string NumberWidth { get; set; }
        public string NumberHeight { get; set; }
        public bool? NumberIsAspectRatio { get; set; }
        public bool? NumberHeightDisable { get; set; }
        public bool? NumberWidthDisable { get; set; }
        public bool? NumberCheckBoxDisable { get; set; }
        public bool? IsCbcname { get; set; }
        public bool? SelectedCbcname { get; set; }
        public string Cbcposition { get; set; }
        public string CbcpositionValue { get; set; }
        public string CbcnameAlignment { get; set; }
        public string CbcnameMinWidth { get; set; }
        public string CbcnameMaxWidth { get; set; }
        public string CbcnameMinHeight { get; set; }
        public string CbcnameMaxHeight { get; set; }
        public string CbcnameHeight { get; set; }
        public string CbcnameWidth { get; set; }
        public bool? CbcnameIsAspectRatio { get; set; }
        public bool? CbcheightDisable { get; set; }
        public bool? CbcwidthDisable { get; set; }
        public bool? CbccheckBoxDisable { get; set; }
        public string SelectedPattern { get; set; }
        public bool? IsTextInsideNumber { get; set; }
        public bool? IsBrandLogoInsideNumber { get; set; }
        public string MainColor { get; set; }
        public string SecondaryColor { get; set; }
        public string TertiaryColor { get; set; }
        public string QuaternaryColor { get; set; }
        public string CollarColor { get; set; }
        public string CuffLeftColor { get; set; }
        public string CuffRightColor { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
