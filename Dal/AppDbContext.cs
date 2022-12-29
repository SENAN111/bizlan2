using Microsoft.EntityFrameworkCore;
using newbIZland.Models;

namespace newbIZland.Dal
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-V540I6U\\SQLEXPRESS;Database=Bizland;Trusted_Connection=true;Encrypt=false");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
}
