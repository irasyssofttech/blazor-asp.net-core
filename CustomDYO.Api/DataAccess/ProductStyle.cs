using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ProductStyle
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string StyleCode { get; set; }
        public string StyleName { get; set; }
        public string StyleThumbnail { get; set; }
        public string ThreeDstyleObj { get; set; }
        public byte SectionNumber { get; set; }
        public bool? IsUploadLogo { get; set; }
        public bool IsText { get; set; }
    }
}
