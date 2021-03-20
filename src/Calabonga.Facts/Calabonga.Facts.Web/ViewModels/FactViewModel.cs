﻿using System;
using System.Collections.Generic;
using Calabonga.Facts.Web.Data;


namespace Calabonga.Facts.Web.ViewModels
{
    public class FactViewModel
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }                
        public string Content { get; set; }
        public IEnumerable<TagViewModel> Tags { get; set; }
    }

    
}
