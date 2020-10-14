using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ProductCollorTypeColorCategoryColor
    {
        public int ProductCollorTypeColorCategoryColorId { get; set; }
        public int? ProductCollorTypeColorCategoryId { get; set; }
        public int? ColorId { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
