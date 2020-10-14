using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ModuleScreenDetail
    {
        public int Id { get; set; }
        public int ModuleScreenId { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string State { get; set; }
        public string Route { get; set; }
        public string ModuleScreenClass { get; set; }
        public int? OrderNumber { get; set; }
    }
}
