using System;
using System.Collections.Generic;

namespace _1_Ornek_Northwind.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; } = null!;
        public decimal? UnitPrice { get; set; }
    }
}
