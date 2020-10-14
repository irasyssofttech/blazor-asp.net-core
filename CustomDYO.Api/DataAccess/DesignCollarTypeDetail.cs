using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class DesignCollarTypeDetail
    {
        public int DesignCollarTypeDetailId { get; set; }
        public int DesignCollarTypeId { get; set; }
        public int ConsumerProductCollarTypeDetailId { get; set; }
        public string CollarType { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
