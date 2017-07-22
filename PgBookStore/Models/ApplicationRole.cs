using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PgBookStore.Models
{
    // Add profile data for application role by adding properties to the ApplicationRole class
    public class ApplicationRole : IdentityRole
    {
        public string Description { get; set; }
    }
}
