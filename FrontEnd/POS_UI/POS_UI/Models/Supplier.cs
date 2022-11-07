using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Supplier
    {
        public Guid SupplierID { get; set; }
        [Required(ErrorMessage ="Please Enter Supplier Name")]
        public string SupplierName { get; set; }
        [Required(ErrorMessage ="Please Enter Supplier Email")]
        public string SupplierEmail { get; set; }
        [Required(ErrorMessage ="Please Enter Supplier Phone")]
        public string SupplierPhone { get; set; }
    }
}
