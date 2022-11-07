using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DTO
{
    public class PurchaseOrderDTO
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
