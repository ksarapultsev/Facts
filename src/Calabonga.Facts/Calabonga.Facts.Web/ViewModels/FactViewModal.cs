using System;
using System.Collections.Generic;
using Calabonga.Facts.Web.Data;


namespace Calabonga.Facts.Web.ViewModels
{
    public class FactViewModal
    {
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public string Content { get; set; }

        public IEnumerable<TagViewModal> Tags { get; set; }
    }

    public class TagViewModal
    {
        public string Name { get; set; }

        public ICollection<Fact> Facts { get; set; }
    }
}
