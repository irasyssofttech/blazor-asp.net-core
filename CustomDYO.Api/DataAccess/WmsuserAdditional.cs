using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class WmsuserAdditional
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string AccountNumber { get; set; }
        public int? ManageUserId { get; set; }
        public string PaymentCurrency { get; set; }
        public string PaymentTerm { get; set; }
        public string LogoCodePrefix { get; set; }
        public decimal? CreditLimit { get; set; }
        public int? SalesUserId { get; set; }
        public int? SalesCoOrdinatorId { get; set; }
        public int? MerchandiseUserId { get; set; }
        public int? WarehouseUserId { get; set; }
        public int? ModifyDays { get; set; }
        public int? CustomerId { get; set; }
        public string UserCode { get; set; }
        public int? ShippingDays { get; set; }
        public bool? IsDyoCustomer { get; set; }
    }
}
