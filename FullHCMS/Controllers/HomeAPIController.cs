using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.Entity;
using FullHCMS.Models;
using FullHCMS.DAL;

namespace FullHCMS.Controllers
{
    public class HomeAPIController : ApiController
    {
        private FullHouseContext db = new FullHouseContext();
        public IEnumerable<Home> GetAllHomes()
        {
            var homes = db.Homes.Include(h => h.Seller);
            return homes.ToList();
        }
    }
}
