using FullHCMS.Models;
using System;
using System.Data.Entity.ModelConfiguration;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullHCMS.Configurations
{
    public class SellerConfiguration: EntityTypeConfiguration<Seller>
    {
        public SellerConfiguration() {
            Property(a => a.FullName).IsRequired().HasMaxLength(50);
            Property(a => a.Email).IsRequired();
            Property(a => a.Phone).IsRequired();
        }
    }
}