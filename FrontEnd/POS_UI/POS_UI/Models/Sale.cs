using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Sale
    {
        public Guid SaleID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int SoldQuantity { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
