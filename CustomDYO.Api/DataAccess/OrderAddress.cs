using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class OrderAddress
    {
        public int Id { get; set; }
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
    }
}
