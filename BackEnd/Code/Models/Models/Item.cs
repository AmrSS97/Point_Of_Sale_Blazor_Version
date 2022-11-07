using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Item : BaseModel
    {
        public Guid ItemID { get; set; }
        public Guid ProductID { get; set; }
        public Guid BillID { get; set; }
        public int ItemQuantity { get; set; }
        public bool? IsDeleted { get; set; }
        public Product Product { get; set; }
        public Bill Bill { get; set; }
        public Item()
        {
            ItemID = Guid.NewGuid();
        }

    }
}
