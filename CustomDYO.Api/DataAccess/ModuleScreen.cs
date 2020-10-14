using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ModuleScreen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Class { get; set; }
        public string Route { get; set; }
        public int? OrderNumber { get; set; }
    }
}
