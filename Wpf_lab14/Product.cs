﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_lab14
{
    public enum ProductTypes
    {
        Food,
        Technics
    }
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public ProductTypes Type { get; set; }
    }
}