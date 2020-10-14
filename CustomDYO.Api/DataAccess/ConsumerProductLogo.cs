using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ConsumerProductLogo
    {
        public int ConsumerProductLogoId { get; set; }
        public int? ConsumerProductPatternId { get; set; }
        public string LogoType { get; set; }
        public int? PositionNo { get; set; }
        public string Position { get; set; }
        public string PositionDescription { get; set; }
        public string AdditionalInformation { get; set; }
        public string MaxHeight { get; set; }
        public string MinHeight { get; set; }
        public string MaxWidth { get; set; }
        public string MinWidth { get; set; }
        public string LogoBase64 { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
        public string LogoBytes { get; set; }
        public bool? IsAspectRatio { get; set; }
        public bool? IsTextUnderLogo { get; set; }
        public string TextUnderLogoMinWidth { get; set; }
        public string TextUnderLogoMaxWidth { get; set; }
        public string TextUnderLogoMinHeight { get; set; }
        public string TextUnderLogoMaxHeight { get; set; }
        public string TextUnderLogoHeight { get; set; }
        public string TextUnderLogoWidth { get; set; }
        public bool? TextUnderLogoIsAspectRatio { get; set; }
        public bool? LogoPositionDisable { get; set; }
        public bool? UploadLogoShowOrHide { get; set; }
        public bool? RemoveLogoShowOrHide { get; set; }
        public bool? SelectedLogo { get; set; }
        public bool? TextUnderLogoShowOrHide { get; set; }
        public bool? LogoEnableOrDisable { get; set; }
        public bool? LogoheightDisable { get; set; }
        public bool? LogoWidthDisable { get; set; }
        public bool? LogoCheckBoxDisable { get; set; }
        public bool? TextUnderLogoHeightDisable { get; set; }
        public bool? TextUnderLogoWidthDisable { get; set; }
        public bool? TextUnderLogoCheckBoxDisable { get; set; }
        public bool? PrintingMethodCheckOrUncheck { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
