using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Bill
    {
        public Guid BillID { get; set; }
        public string UserName { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public DateTime BillDate { get; set; }
        public string PaymentType { get; set; }
        public double TotalValue { get; set; }
        public List<Item> ItemDtoList { get; set; }
    }
}
