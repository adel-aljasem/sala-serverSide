using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string StoreName { get; set; }
        public string StoreLink { get; set; }
        public string StoreType { get; set; }
    }
}
