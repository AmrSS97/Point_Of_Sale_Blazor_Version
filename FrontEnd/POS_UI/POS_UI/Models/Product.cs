using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Product
    {
        public Guid ProductID { get; set; }
        [Required(ErrorMessage ="Please Select A Category")]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Please Select A Supplier")]
        public string SupplierName { get; set; }
        public string SupplierPhone { get; set; }
        [Required(ErrorMessage="Please Enter Product Name")]
        public string ProductName { get; set; }
        public string ProductDetails { get; set; }
        [Required(ErrorMessage ="Please Enter Price")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Please Enter Quantity In Stock")]
        public int Stock { get; set; }
        public int DiscountPercentage { get; set; }
    }
}
