using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class OrderStrikeOffLogos
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? OrderEmblishmentId { get; set; }
        public string Logo { get; set; }
        public byte? Status { get; set; }
        public int? RevisionNo { get; set; }
        public int? LogoId { get; set; }
        public string PrintingThumbImage { get; set; }
    }
}
