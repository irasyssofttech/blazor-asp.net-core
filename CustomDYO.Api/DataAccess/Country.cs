using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string CountryPhoneCode { get; set; }
        public int? TimeZoneId { get; set; }
        public string CountryCode2 { get; set; }
        public int Rank { get; set; }
    }
}
