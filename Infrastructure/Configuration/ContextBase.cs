using Entities.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Configuration
{
    public class ContextBase : IdentityDbContext<ApplicationUser>
    {
        public ContextBase( DbContextOptions<ContextBase> options) : base(options)
        {                
        }

        public DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConnectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }

        private string GetStringConnectionConfig()
        {
            string strCon = "Data Source = HEITOR\\SQLEXPRESS; Initial Catalog = EcoIBYPOWER; Integrated Security = True";
            return strCon;
        }
    }
}
