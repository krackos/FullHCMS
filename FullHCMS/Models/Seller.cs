using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullHCMS.Models
{
    public class Seller
    {
        public int SellerId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Home> Homes { get; set; }

        public Seller() {
            Homes = new HashSet<Home>();
        }
    }
}