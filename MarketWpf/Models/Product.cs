﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketWpf.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double UnitPrice { get; set; }
        public int StockAmount { get; set; }
        public string ImagePath { get; set; }
    }
}
