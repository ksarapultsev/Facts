using Calabonga.EntityFrameworkCore.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calabonga.Facts.Web.Data
{
    public class Tag : Identity 
    {
        public string Name { get; set; }

        public ICollection<Fact> Facts  { get; set; }

        public int Number { get; set; }
    }
}
