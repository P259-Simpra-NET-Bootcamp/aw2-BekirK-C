using Entities.Concrete;
using Entities.Configurations;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class SimpraDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-MP6HDBU; Database=Simpra; Trusted_Connection=true");
        }
        public DbSet<Staff> Staffs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StaffConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
