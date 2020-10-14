using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class UserConfiguration
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string MailHostName { get; set; }
        public string Smtpport { get; set; }
        public string SmtpuserName { get; set; }
        public string Smtppassword { get; set; }
        public string SmtpdisplayName { get; set; }
        public string FromMail { get; set; }
        public string EnableSsl { get; set; }
        public string Regards { get; set; }
        public string SupportLink { get; set; }
    }
}
