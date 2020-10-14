using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class TechnicalDocument
    {
        public int TechnicalDocumentId { get; set; }
        public int LogoId { get; set; }
        public string LogoTechnicalDocumentPath { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
