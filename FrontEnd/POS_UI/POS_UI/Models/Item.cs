﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Item
    {
        public Guid ItemID { get; set; }
        public string ProductName { get; set; }
        public int ItemQuantity { get; set; }
    }
}
