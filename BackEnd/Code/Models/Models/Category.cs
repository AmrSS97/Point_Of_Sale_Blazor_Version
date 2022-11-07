using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Models
{
    public class Category : BaseModel
    {
        public Guid CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool? IsDeleted { get; set; }
        public List<Product> Products { get; set; }
        public Category()
        {
            CategoryID = Guid.NewGuid();
            Products = new List<Product>();
        }
    }
}
