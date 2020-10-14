using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class CountryPortBackup
    {
        public int CountryPortId { get; set; }
        public int CountryId { get; set; }
        public string CountryPort { get; set; }
        public bool IsActive { get; set; }
    }
}
