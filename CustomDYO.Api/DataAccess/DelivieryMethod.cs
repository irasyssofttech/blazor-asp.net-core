using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class DelivieryMethod
    {
        public byte Id { get; set; }
        public string DelivieryName { get; set; }
        public string DelivieryNameDisplay { get; set; }
        public string DeliveryCode { get; set; }
        public bool? IsActive { get; set; }
    }
}
