using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class DesignQuote
    {
        public int DesignQuoteId { get; set; }
        public int UserId { get; set; }
        public int? CountryId { get; set; }
        public int? OrderDesignId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? JersyCount { get; set; }
        public string Email { get; set; }
        public string TelephoneNumber { get; set; }
        public bool? IsContact { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOnUtc { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }
    }
}
