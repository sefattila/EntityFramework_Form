using System;
using System.Collections.Generic;

namespace _3_NorthwindCompany.Models
{
    public partial class ProductOrderSummary
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public int? Toplam { get; set; }
    }
}
