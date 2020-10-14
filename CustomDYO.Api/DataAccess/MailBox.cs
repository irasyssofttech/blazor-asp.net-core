using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class MailBox
    {
        public int MailBoxId { get; set; }
        public string Username { get; set; }
        public string Recipients { get; set; }
        public string CopyRecipients { get; set; }
        public string BlindCopyRecipients { get; set; }
        public string MailSubject { get; set; }
        public string MailBody { get; set; }
        public string FileAttachments { get; set; }
        public string SmtpUser { get; set; }
        public string SmtpPassword { get; set; }
        public string SmtpHost { get; set; }
        public string SmtpPort { get; set; }
        public bool EnableSsl { get; set; }
        public bool? Flag { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public string ErrorLog { get; set; }
        public string Regards { get; set; }
    }
}
