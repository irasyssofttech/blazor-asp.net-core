using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ConsumerProductCollarType
    {
        public int ConsumerProductCollarTypeId { get; set; }
        public int? ConsumerProductId { get; set; }
        public string CollarTypeCode { get; set; }
        public string CollarTypeName { get; set; }
        public string ConsumerProductCollorTypeThumbnailPath { get; set; }
        public string CollarIconPath { get; set; }
        public string NormalMapFilePath { get; set; }
        public string ThreeDmodelObjFile { get; set; }
        public string SpecularMapFilePath { get; set; }
        public string Description { get; set; }
        public string SelectedCollarType { get; set; }
        public bool? IsBrandLevel { get; set; }
        public bool? IsCollar { get; set; }
        public bool? IsNeckTape { get; set; }
        public bool? IsCollarTape { get; set; }
        public bool? IsCollarStand { get; set; }
        public bool? IsButton { get; set; }
        public bool? IsDrawcordFlat { get; set; }
        public bool? IsDrawcordTipClear { get; set; }
        public bool? IsEyelet { get; set; }
        public bool? IsZip { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
