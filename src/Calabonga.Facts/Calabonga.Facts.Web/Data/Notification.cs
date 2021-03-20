using Calabonga.EntityFrameworkCore.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calabonga.Facts.Web.Data
{
    public class Notification : Auditable
    {
        public string Subject { get; set; }

        public string Content { get; set; }
        public bool IsCompleted { get; set; }

        public string AddressFrom { get; set; }
        public string AddressTo { get; set; }


    }
}
