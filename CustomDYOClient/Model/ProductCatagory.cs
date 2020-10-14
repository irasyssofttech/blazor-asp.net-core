using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomDYOClient
{
  public class ProductCatagory
    {
        public int ProductCatagoryId { get; set; }
        [Required]
        public string CatagoryName { get; set; }
        [Required]
        public string CatagoryDisplay { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public string ProductCategoryCode { get; set; }

        public string IconFilePath { get; set; }
        public string Route { get; set; }
        [Required]
        public int ParentId { get; set; }
        public bool IsSelected { get; set; }
        public bool IsDefault { get; set; }
        public bool IsActive { get; set; }

        public string StaticDrop { get; set; }
    }
}
