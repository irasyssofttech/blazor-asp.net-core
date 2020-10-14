using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ProductCollarType
    {
        public int ProductCollarTypeId { get; set; }
        public int? ProductId { get; set; }
        public string CollarTypeName { get; set; }
        public string ProductCollorTypeThumbnailPath { get; set; }
        public string ThreeDmodelObjFile { get; set; }
        public string NormalMapFilePath { get; set; }
        public string SpecularMapFilePath { get; set; }
        public bool? IsDefaultCollarType { get; set; }
        public bool? IsBrandLevel { get; set; }
        public bool? IsNeckType { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
