using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class UserReceivingNoteDetail
    {
        public int Id { get; set; }
        public int UserReceivingNoteId { get; set; }
        public int ProductSkuid { get; set; }
        public int ExpectedQuantity { get; set; }
        public int ActualQuantity { get; set; }
    }
}
