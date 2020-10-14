using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class Warehouse
    {
        public int WarehouseId { get; set; }
        public string Name { get; set; }
        public int WarehouseUserId { get; set; }
        public int CreatedBy { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int CountryId { get; set; }
        public string LocationName { get; set; }
        public string LocationLatitude { get; set; }
        public string LocationLongitude { get; set; }
        public string Email { get; set; }
        public string TelephoneNo { get; set; }
        public bool IsActive { get; set; }
    }
}
