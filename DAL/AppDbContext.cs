using Microsoft.EntityFrameworkCore;
using proniya.Models;
namespace proniya.DAL
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-V540I6U\\SQLEXPRESS;Database=Pronia-2;integrated security=true;trusted_connection=true;Encrypt=false");
        }
        public DbSet<Catagory> catagories { get; set; }
        public DbSet<Client> clients { get; set; }
    }
}
