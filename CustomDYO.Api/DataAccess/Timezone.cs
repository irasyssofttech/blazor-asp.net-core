using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class Timezone
    {
        public int TimezoneId { get; set; }
        public string Name { get; set; }
        public string Offset { get; set; }
        public string OffsetShort { get; set; }
    }
}
