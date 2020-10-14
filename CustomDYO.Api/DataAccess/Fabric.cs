using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class Fabric
    {
        public int FabricId { get; set; }
        public string FabricName { get; set; }
        public string FabricDescription { get; set; }
        public bool? IsActive { get; set; }
    }
}
