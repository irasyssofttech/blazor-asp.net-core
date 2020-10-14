using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class Logo
    {
        public int LogoId { get; set; }
        public int? CustomerId { get; set; }
        public string LogoType { get; set; }
        public int? LogoStatusId { get; set; }
        public int? PrintingMethodId { get; set; }
        public string LogoCodePrefix { get; set; }
        public string LogoCode { get; set; }
        public string LogoTitle { get; set; }
        public string LogoNumber { get; set; }
        public decimal? FactoryCost { get; set; }
        public decimal? SalesCost { get; set; }
        public string Description { get; set; }
        public string LogoImagePath { get; set; }
        public string LogoThumbnailPath { get; set; }
        public string LogoThumbnail2Path { get; set; }
        public string VectorImagePath { get; set; }
        public string VectorImageThumbnailPath { get; set; }
        public string VectorImageThumbnail2Path { get; set; }
        public string PrintingImagePath { get; set; }
        public string PrintingImageThumbnailPath { get; set; }
        public string PrintingImageThumbnail2Path { get; set; }
        public int? TotalApprovalUser { get; set; }
        public int? RemainingApprovalUser { get; set; }
        public int RequiredApprovalCount { get; set; }
        public int ApprovedCount { get; set; }
        public int DisapproveCount { get; set; }
        public string LogoHeight { get; set; }
        public string Logowidth { get; set; }
        public bool IsAspectRatioLogo { get; set; }
        public bool IsFavorite { get; set; }
        public bool? IsPublic { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
