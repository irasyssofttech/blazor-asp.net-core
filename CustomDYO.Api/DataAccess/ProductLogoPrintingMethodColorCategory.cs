﻿using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class ProductLogoPrintingMethodColorCategory
    {
        public int ProductLogoPrintingMethodColorCategoryId { get; set; }
        public int? ProductLogoPrintingMethodId { get; set; }
        public int ColorCategoryId { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
