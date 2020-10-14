using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class CommunicationLog
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? OrderEmblishmentId { get; set; }
        public int? SampleLogoId { get; set; }
        public int? UserId { get; set; }
        public string Reason { get; set; }
        public DateTime? Date { get; set; }
        public bool IsPublic { get; set; }
        public string Type { get; set; }
        public int OrderDesignId { get; set; }
    }
}
