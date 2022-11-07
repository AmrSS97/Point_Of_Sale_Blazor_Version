using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class PurchaseOrder
    {
        public Guid PurchaseOrderID { get; set; }
        public string ProductName { get; set; }
        public string SupplierName { get; set; }
        public string SupplierPhone { get; set; }
        public int PurchasedQuantity { get; set; }
        public double UnitPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
