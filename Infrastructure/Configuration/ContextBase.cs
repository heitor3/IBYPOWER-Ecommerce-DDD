using Entities.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Configuration
{
    public class ContextBase : IdentityDbContext<IdentityUser>
    {
        public ContextBase( DbContextOptions<ContextBase> options) : base(options)
        {                
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<UserBuys> UserBuys { get; set; }
        public DbSet<IdentityUser> IdentityUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConnectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityUser>().ToTable("AspNetUsers").HasKey(x => x.Id);

            base.OnModelCreating(builder); 
        }

        private string GetStringConnectionConfig()
        {
            string strCon = "Data Source = HEITOR\\SQLEXPRESS; Initial Catalog = EcoIBYPOWER; Integrated Security = True";
            return strCon;
        }
    }
}
