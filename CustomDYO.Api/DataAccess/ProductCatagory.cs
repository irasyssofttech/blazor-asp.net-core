using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ProductCatagory
    {
        public int ProductCatagoryId { get; set; }
        public string CatagoryName { get; set; }
        public string CatagoryDisplay { get; set; }
        public int? CustomerId { get; set; }
        public string ProductCategoryCode { get; set; }
        public string IconFilePath { get; set; }
        public string Route { get; set; }
        public int? ParentId { get; set; }
        public bool? IsSelected { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsActive { get; set; }
    }
}
