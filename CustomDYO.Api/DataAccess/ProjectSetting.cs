using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ProjectSetting
    {
        public int ProjectSettingId { get; set; }
        public int? CustomerId { get; set; }
        public string AppTitle { get; set; }
        public string AppLogoPath { get; set; }
        public string CompanyName { get; set; }
        public string RegisteredYear { get; set; }
        public string FaviconIconPath { get; set; }
        public string CertifiedText { get; set; }
        public string GovermentUrl { get; set; }
        public string DesignQuotationEmail { get; set; }
    }
}
