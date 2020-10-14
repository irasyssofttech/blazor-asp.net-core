using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class LogoStrikeOff
    {
        public int LogoStrikeOffId { get; set; }
        public string LogoImage { get; set; }
        public int? Status { get; set; }
        public int? RevisionNo { get; set; }
        public int? LogoId { get; set; }
    }
}
