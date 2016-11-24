using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullHCMS.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Home> Homes { get; set; }

        public Company()
        {
            Homes = new HashSet<Home>();
        }
    }
}