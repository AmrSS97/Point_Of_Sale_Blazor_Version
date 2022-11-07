using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DTO
{
    public class ItemDTO
    {
        public Guid ItemID { get; set; }
        public string ProductName { get; set; }
        public int ItemQuantity { get; set; }
    }
}
