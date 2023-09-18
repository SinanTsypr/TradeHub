using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeHubBLL.Entities
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; } = null!;

        public string Brand { get; set; } = null!;

        public short Stock { get; set; }

        public decimal BuyPrice { get; set; }

        public decimal SellPrice { get; set; }

        public bool Status { get; set; }

        public string ProductImage { get; set; } = null!;


        public Category Category { get; set; } = null!;
        public SalesTransaction SalesTransaction { get; set; } = null!;
    }
}
