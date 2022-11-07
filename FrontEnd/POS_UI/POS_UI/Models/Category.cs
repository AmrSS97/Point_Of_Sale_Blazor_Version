using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Category
    {
        public Guid CategoryID { get; set; }
        [Required(ErrorMessage ="Please Enter A Category Name")]
        public string CategoryName { get; set; }
        public int ProductsCount { get; set; }
    }
}
