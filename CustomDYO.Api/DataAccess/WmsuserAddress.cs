using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class WmsuserAddress
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public int CountryId { get; set; }
        public bool IsFavorites { get; set; }
        public bool IsDefault { get; set; }
        public bool? IsPrivate { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
