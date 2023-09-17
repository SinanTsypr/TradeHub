using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeHubBLL.Entities
{
    public class Expens
    {
        public int ExpensId { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public decimal Cost { get; set; }
    }
}
