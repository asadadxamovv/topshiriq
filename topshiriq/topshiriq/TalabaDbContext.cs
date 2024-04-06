using Microsoft.EntityFrameworkCore;

namespace topshiriq
{
    public class TalabaDbContext : DbContext
    {
        public DbSet<Talaba> Talabalar { get; set; }

        public TalabaDbContext()
        {
            // Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb);Database=TalabaDb; Integrated Security=true;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TalabaConfiguration());
        }
    }
}
