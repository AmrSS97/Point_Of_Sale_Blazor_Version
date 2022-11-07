using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Sale : BaseModel
    {
        public Guid SaleID { get; set; }
        public Guid ProductID { get; set; }
        public Guid BillID { get; set; }
        public int SoldQuantity { get; set; }
        public DateTime SaleDate { get; set; }
        public bool? IsDeleted { get; set; }
        public Product Product { get; set; }
        public Bill Bill { get; set; }
        public Sale()
        {
            SaleID = Guid.NewGuid();
        }
    }
}
