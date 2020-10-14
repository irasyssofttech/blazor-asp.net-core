using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ShelfRowDetail
    {
        public ShelfRowDetail()
        {
            SectionDetail = new HashSet<SectionDetail>();
        }

        public int Id { get; set; }
        public int WarehouseId { get; set; }
        public int LineId { get; set; }
        public int ShelfId { get; set; }
        public int RowId { get; set; }

        public virtual ICollection<SectionDetail> SectionDetail { get; set; }
    }
}
