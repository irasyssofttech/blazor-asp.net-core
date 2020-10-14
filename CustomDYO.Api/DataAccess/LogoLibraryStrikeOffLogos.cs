using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class LogoLibraryStrikeOffLogos
    {
        public int LogoLibraryId { get; set; }
        public string Logo { get; set; }
        public byte? Status { get; set; }
        public int? RevisionNo { get; set; }
        public int? LogoId { get; set; }
    }
}
