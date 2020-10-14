using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ConsumerProductPrintingMethod
    {
        public int ConsumerProductPrintingMethodId { get; set; }
        public int? ConsumerProductId { get; set; }
        public int? PrintingMethodId { get; set; }
        public string ConsumerProductPrintingMethodName { get; set; }
        public string LogoName { get; set; }
        public int? ParentId { get; set; }
        public string ParentType { get; set; }
        public string SelectedPrintingMethod { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
