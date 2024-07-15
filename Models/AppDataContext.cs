using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FutureFridgesCW.Models
{
    public class AppDataContext : IdentityDbContext<AppUser>
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        { }

        public DbSet<Products> Products { get; set; }

        public DbSet<Supplier> Supplier { get; set; }

    }
}
