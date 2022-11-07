using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DTO
{
    public class SupplierDTO
    {
        public Guid SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierPhone { get; set; }
    }
}
