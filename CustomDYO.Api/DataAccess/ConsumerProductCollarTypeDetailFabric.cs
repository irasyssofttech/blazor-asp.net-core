using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ConsumerProductCollarTypeDetailFabric
    {
        public int ConsumerProductCollarTypeDetailFabricId { get; set; }
        public int ConsumerFabricId { get; set; }
        public int? ConsumerProductCollarTypeDetailId { get; set; }
        public string FabricName { get; set; }
        public string FabricCode { get; set; }
        public string FabricWeight { get; set; }
        public string Description { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
