using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ConsumerProductCollarTypeDetail
    {
        public int ConsumerProductCollarTypeDetailId { get; set; }
        public int? ConsumerProductCollarTypeId { get; set; }
        public string CollarSectionName { get; set; }
        public string CollarSectionCode { get; set; }
        public string CollarSection { get; set; }
        public string Description { get; set; }
        public bool? SelectedCollarDetail { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
