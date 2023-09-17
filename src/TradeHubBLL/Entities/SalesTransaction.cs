using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeHubBLL.Entities
{
    public class SalesTransaction
    {
        public int SalesTransactionId { get; set; }



        public DateTime Date { get; set; } = DateTime.Now;

        public int Amount { get; set; }

        public decimal Price { get; set; }

        public decimal TotalPrice { get; set; }


        public List<Product> Products { get; set; } = new();
        public List<Current> Currents { get; set; } = new();
        //public List<IdentityUser> MyProperty { get; set; }
    }
}
