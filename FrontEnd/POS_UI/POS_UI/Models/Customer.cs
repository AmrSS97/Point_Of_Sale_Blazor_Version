using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Customer
    {
        public Guid CustomerID { get; set; }
        [Required(ErrorMessage = "Please Enter Customer Name")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Please Enter Customer Email")]
        public string CustomerEmail { get; set; }
        [Required(ErrorMessage = "Please Enter Customer Phone")]
        public string CustomerPhone { get; set; }
        [Required(ErrorMessage = "Please Enter Customer Address")]
        public string CustomerAddress { get; set; }
    }
}
