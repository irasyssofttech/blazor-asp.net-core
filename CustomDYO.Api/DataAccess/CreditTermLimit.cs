using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class CreditTermLimit
    {
        public int CreditTermLimitId { get; set; }
        public int? CustomerId { get; set; }
        public int ConsumerId { get; set; }
        public string PaymentCurrency { get; set; }
        public string PaymentTerm { get; set; }
        public decimal? CreditLimit { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
