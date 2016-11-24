using FullHCMS.Models;
using System;
using System.Data.Entity.ModelConfiguration;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullHCMS.Configurations
{
    public class CompanyConfiguration: EntityTypeConfiguration<Company>
    {
        public CompanyConfiguration()
        {
            Property(a => a.Name).IsRequired().HasMaxLength(20);
            Property(a => a.Phone).HasMaxLength(12);
        }
    }
}