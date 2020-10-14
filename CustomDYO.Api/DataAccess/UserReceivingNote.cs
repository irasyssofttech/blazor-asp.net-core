using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class UserReceivingNote
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Barcode { get; set; }
        public string ReceivingNote { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public int CreatedBy { get; set; }
        public bool IsClosed { get; set; }
    }
}
