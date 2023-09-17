using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeHubBLL.Entities
{
    public class Current
    {
        public int CurrentId { get; set; }

        public string CurrentName { get; set; } = null!;

        public string CurrentSurname { get; set; } = null!;

        public string CurrentTitle { get; set; } = null!;

        public string CurrentCity { get; set; } = null!;

        public string CurrentMail { get; set; } = null!;
    }
}
