using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DTO
{
    public class CustomerDTO
    {
        public Guid CustomerID { get; set; }
        public string FullName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
    }
}
