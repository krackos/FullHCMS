using FullHCMS.Models;
using FullHCMS.Configurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FullHCMS.DAL
{
    public class FullHouseContext : DbContext
    {
    
        public FullHouseContext() : base("name=FullHouse") {}

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        public System.Data.Entity.DbSet<FullHCMS.Models.Home> Homes { get; set; }

        public System.Data.Entity.DbSet<FullHCMS.Models.Seller> Sellers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new HomeConfiguration());
            modelBuilder.Configurations.Add(new SellerConfiguration());
        }
    }
}
