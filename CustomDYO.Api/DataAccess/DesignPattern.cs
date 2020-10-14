using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class DesignPattern
    {
        public int DesignPatternId { get; set; }
        public int OrderDesignId { get; set; }
        public int ConsumerProductPatternId { get; set; }
        public bool IsVerticalText { get; set; }
        public bool IsName { get; set; }
        public bool IsNumber { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
