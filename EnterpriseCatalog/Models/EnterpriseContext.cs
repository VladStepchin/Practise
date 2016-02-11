using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EnterpriseCatalog.Models
{
    public class EnterpriseContext : DbContext
    {
        public DbSet<Enterprises> Enterprises{ get; set; }

        public DbSet<Workforces> Workforces { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }
    }
}