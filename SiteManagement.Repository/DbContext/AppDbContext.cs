using Microsoft.EntityFrameworkCore;
using SiteManagament.Core;
using SiteManagament.Core.Entity;
using SiteManagement.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Repository
{
   public class AppDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Tenant> Tenants { get; set; }

        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<Role> Roles { get; set; }
     
    }
}
