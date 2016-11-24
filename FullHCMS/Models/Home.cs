using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullHCMS.Models
{
    public enum Status {
        USED, NEW
    }
    public class Home
    {
        public int HomeId { get; set; } 
        public string Title {get; set; }
        public string LongDescription { get; set; }
        public Int64 Price { get; set; }
        public int Size { get; set; }
        //public int CompanyId { get; set; }
        //public virtual Company Company { get; set; }
        public int SellerId { get; set; }
        public virtual Seller Seller { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int PostalCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
    }
}