using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeHubDAL.Identity
{
    public class ApplicationUser
    {
        public string PersonalName { get; set; } = null!;

        public string PersonalSurname { get; set; } = null!;

        public string PersonalImage { get; set; } = null!;
    }
}
