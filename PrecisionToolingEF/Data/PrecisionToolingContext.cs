using Microsoft.EntityFrameworkCore;

using PrecisionToolingEF.Models;

namespace PrecisionToolingEF.Data
{
    public class PrecisionToolingContext : DbContext
    {
        public PrecisionToolingContext(DbContextOptions<PrecisionToolingContext> options) : base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<Labor> LaborItems { get; set; }

        public DbSet<Material> MaterialItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            

        }


    }
}
