﻿using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class DesignCollarTypeDetailFabric
    {
        public int DesignCollarTypeDetailFabricId { get; set; }
        public int DesignCollarTypeDetailId { get; set; }
        public int ConsumerProductCollarTypeDetailId { get; set; }
        public int ConsumerFabricId { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
