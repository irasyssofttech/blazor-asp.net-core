using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class CountryPort
    {
        public int CountryPortId { get; set; }
        public int CountryId { get; set; }
        public string CountryPort1 { get; set; }
        public string AirportPortName { get; set; }
        public bool IsActive { get; set; }
    }
}
