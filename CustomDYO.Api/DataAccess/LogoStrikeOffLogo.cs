using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class LogoStrikeOffLogo
    {
        public int LogoStrikeOffLogoId { get; set; }
        public string LogoImage { get; set; }
        public int? Status { get; set; }
        public int? RevisionNo { get; set; }
        public int? LogoId { get; set; }
    }
}
