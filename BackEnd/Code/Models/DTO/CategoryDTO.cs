using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DTO
{
    public class CategoryDTO
    {
        public Guid CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int ProductsCount { get; set; }
    }
}
