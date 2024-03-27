using Microsoft.EntityFrameworkCore;

namespace DessignPattern.ChainOfResponsibility.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-NNPGC4M;initial catalog=DesignPattern1;integrated security=true;");
        }

        public DbSet<CustomerProcess> CustomerProcess { get; set; }
    }
}
