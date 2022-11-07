using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Models
{
    public class Bill : BaseModel
    {
        public Guid BillID { get; set; }
        public Guid UserID { get; set; }
        public Guid CustomerID { get; set; }
        public DateTime BillDate { get; set; }
        public string PaymentType { get; set; }
        public double TotalValue { get; set; }
        public bool? IsDeleted { get; set; }
        public User User { get; set; }
        public Customer Customer { get; set; }
        public List<Sale> Sales { get; set; }
        public List<Item> ItemList { get; set; }
        public Bill()
        {
            BillID = Guid.NewGuid();
            Sales = new List<Sale>();
        }
     }
}
