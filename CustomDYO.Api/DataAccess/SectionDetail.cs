using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class SectionDetail
    {
        public int Id { get; set; }
        public int ShelfRowId { get; set; }
        public int SectionId { get; set; }
        public string Barcode { get; set; }

        public virtual ShelfRowDetail ShelfRow { get; set; }
    }
}
