using FullHCMS.Models;
using System;
using System.Data.Entity.ModelConfiguration;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullHCMS.Configurations
{
    public class HomeConfiguration: EntityTypeConfiguration<Home>
    {
        public HomeConfiguration()
        {
            Property(a => a.Title).IsRequired().HasMaxLength(50);
            Property(a => a.LongDescription).IsRequired().HasMaxLength(200);
            Property(a => a.Price).IsRequired();
            Property(a => a.Size).IsRequired();
            Property(a => a.PostalCode).IsRequired();
        }
    }
}