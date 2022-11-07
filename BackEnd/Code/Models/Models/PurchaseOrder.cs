using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Models
{
    public class PurchaseOrder : BaseModel
    {
        public Guid PurchaseOrderID { get; set; }
        public Guid ProductID { get; set; }
        public Guid SupplierID { get; set; }
        public int PurchasedQuantity { get; set; }
        public double UnitPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public bool? IsDeleted { get; set; }
        public Product Product { get; set; }
        public Supplier Supplier { get; set; }
        public PurchaseOrder()
        {
            PurchaseOrderID = Guid.NewGuid();
        }
    }
}
