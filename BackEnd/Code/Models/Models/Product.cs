using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Models
{
    public class Product : BaseModel
    {
        public Guid ProductID { get; set; }
        public Guid CategoryID { get; set; }
        public Guid SupplierID { get; set; }
        public string ProductName { get; set; }
        public string? ProductDetails { get; set; }
        public double Price { get; set; }
        public int DiscountPercentage { get; set; }
        public int Stock { get; set; }
        public bool? IsDeleted { get; set; }
        public Category Category { get; set; }
        public Supplier Supplier { get; set; }
        public List<PurchaseOrder> PurchaseOrders { get; set; }
        public List<Sale> ProductSales { get; set; }
        public List<Item> ItemList { get; set; }

        public Product()
        {
            ProductID = Guid.NewGuid();
            PurchaseOrders = new List<PurchaseOrder>();
            ProductSales = new List<Sale>();
        }
    }
}
