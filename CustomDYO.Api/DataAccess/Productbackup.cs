using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class Productbackup
    {
        public int Id { get; set; }
        public int? ProductCatagoryId { get; set; }
        public int StockRangeId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string LogoThumbnail { get; set; }
        public string ThreeDmodelObjFile { get; set; }
        public string BrandLogoFilePath { get; set; }
        public decimal? NameHeight { get; set; }
        public decimal? NumberHeight { get; set; }
        public bool? IsName { get; set; }
        public bool? IsNumber { get; set; }
        public bool? IsNumberBrandLogoInside { get; set; }
        public bool IsUpperArmRight { get; set; }
        public bool IsLowerArmRight { get; set; }
        public bool IsUpperArmLeft { get; set; }
        public bool IsLowerArmLeft { get; set; }
        public bool IsChestCenterTop { get; set; }
        public bool IsRightChest { get; set; }
        public bool IsLeftChest { get; set; }
        public bool IsFrontMain { get; set; }
        public bool IsBackNeck { get; set; }
        public bool IsPlayerName { get; set; }
        public bool IsPlayerNumber { get; set; }
        public bool IsMidBack { get; set; }
        public bool IsLowerBack { get; set; }
        public bool IsLowerSleeveRight { get; set; }
        public bool IsLowerSleeveLeft { get; set; }
        public bool IsThighRight { get; set; }
        public bool IsThighLeft { get; set; }
        public bool IsBackThighLeft { get; set; }
        public bool IsBackThighRight { get; set; }
        public bool IsLeftShoulder { get; set; }
        public bool IsRightShoulder { get; set; }
        public bool IsSockFrontRight { get; set; }
        public bool IsSockFrontLeft { get; set; }
        public bool IsSockCalfLeft { get; set; }
        public bool IsSockCalfRight { get; set; }
        public bool IsUploadLogo { get; set; }
        public bool IsText { get; set; }
        public byte NumberOfSection { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
