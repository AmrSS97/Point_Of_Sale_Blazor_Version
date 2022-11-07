using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Models
{
    public class Supplier : BaseModel
    {
        public Guid SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierPhone { get; set; }
        public bool? IsDeleted { get; set; }
        public List<Product> SuppliedProducts { get; set; }

        public Supplier()
        {
            SupplierID = Guid.NewGuid();
            SuppliedProducts = new List<Product>(); 
        }
    }
}
