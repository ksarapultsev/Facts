using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calabonga.EntityFrameworkCore.Entities.Base;

namespace Calabonga.Fact.Web.Data
{
    public class Fact : Auditable
    {
        public string Content { get; set; }

        public ICollection<Tag> Tags { get; set; }

    }
}
