using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class PrintingMethod
    {
        public int PrintingMethodId { get; set; }
        public string PrintingMethodName { get; set; }
        public string Remark { get; set; }
        public bool? IsActive { get; set; }
    }
}
