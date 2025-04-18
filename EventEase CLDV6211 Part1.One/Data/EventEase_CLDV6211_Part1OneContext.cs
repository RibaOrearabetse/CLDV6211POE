﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EventEase_CLDV6211_Part1.One.Data
{
    public class EventEase_CLDV6211_Part1OneContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public EventEase_CLDV6211_Part1OneContext() : base("name=EventEase_CLDV6211_Part1OneContext")
        {
        }

        public System.Data.Entity.DbSet<EventEase_CLDV6211_Part1.One.Models.Event> Events { get; set; }

        public System.Data.Entity.DbSet<EventEase_CLDV6211_Part1.One.Models.Venue> Venues { get; set; }
    }
}
