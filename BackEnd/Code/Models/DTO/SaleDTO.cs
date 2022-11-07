using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DTO
{
    public class SaleDTO
    {
        public Guid SaleID { get; set; }
        public string ProductName { get; set; }
        public int SoldQuantity { get; set; }
        public double ProductPrice { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
