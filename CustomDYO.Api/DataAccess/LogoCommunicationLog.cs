using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class LogoCommunicationLog
    {
        public int LogoCommunicationLogId { get; set; }
        public int? UserId { get; set; }
        public string Reason { get; set; }
        public DateTime? Date { get; set; }
        public bool IsPublic { get; set; }
        public string Type { get; set; }
        public int LogoId { get; set; }
    }
}
