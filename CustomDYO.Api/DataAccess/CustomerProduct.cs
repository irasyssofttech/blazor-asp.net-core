using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class CustomerProduct
    {
        public int CustomerProductId { get; set; }
        public int? CustomerId { get; set; }
        public int? ProductId { get; set; }
        public int ProductCategoryId { get; set; }
        public int? ConsumerOfficeId { get; set; }
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
        public bool? IsNumberInsideBrandLogo { get; set; }
        public bool IsUploadLogo { get; set; }
        public bool IsVerticalText { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
