using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ConsumerProductCuff
    {
        public int ConsumerProductCuffId { get; set; }
        public int? ConsumerProductId { get; set; }
        public string CuffDisplayName { get; set; }
        public string CuffName { get; set; }
        public string ThreeDname { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
