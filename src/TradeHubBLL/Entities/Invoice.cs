using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeHubBLL.Entities
{
    public class Invoice
    {
        public int InvoiceId { get; set; }

        public string InvoiceSerialNo { get; set; } = null!;

        public string InvoiceOrderNo { get; set; } = null!;

        public string TaxDepartment { get; set; } = null!;

        public DateTime InvoiceDate { get; set; } = DateTime.Now;

        public string DeliveredTo { get; set; } = null!;

        public string DeliveredBy { get; set; } = null!;


        public List<InvoiceItem> InvoiceItems { get; set; } = new();
    }
}
