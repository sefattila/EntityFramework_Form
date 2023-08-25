using System;
using System.Collections.Generic;

namespace _1_Ornek_Northwind.Models
{
    public partial class ProductOrderSummary
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public int? Toplam { get; set; }
    }
}
