using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Product_List.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Manufacturer { get; set; }
        public string Supplier { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
