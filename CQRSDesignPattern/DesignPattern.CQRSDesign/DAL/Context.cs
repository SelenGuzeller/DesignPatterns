using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRSDesign.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-NNPGC4M;initial catalog=DesignPattern2;integrated security=true;");
        }

        public DbSet<Product> Products { get; set; }
    }
}
