using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DTO
{
    public class ProductDTO
    {
        public Guid ProductID { get; set; }
        public string CategoryName { get; set; }
        public string SupplierName { get; set; }
        public string SupplierPhone { get; set; }
        public string ProductName { get; set; }
        public string ProductDetails { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public int DiscountPercentage { get; set; }
    }
}
