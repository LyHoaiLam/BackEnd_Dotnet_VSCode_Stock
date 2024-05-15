using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;

namespace api.Models
{
    public class AppUser : IdentityUser {
        // public List<Portfolio> Portfolios { get; set; } = new List<Portfolio>();
        // public int Risk { get; set; }
        public List<Portfolio> Portfolios { get; set; } = new List<Portfolio>();
    }
}