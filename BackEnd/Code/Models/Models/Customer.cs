using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Models
{
    public class Customer : BaseModel
    {
        public Guid CustomerID {get; set;}
        public string FullName { get; set;}
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public bool? IsDeleted { get; set; }
        public List<Bill> BillList { get; set; }
        public Customer()
        {
            CustomerID = Guid.NewGuid();
            BillList = new List<Bill>();
        }
    }
}
