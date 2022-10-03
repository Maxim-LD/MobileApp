using Microsoft.EntityFrameworkCore;
using MobileApp.Model.Entity;

namespace MobileApp.Migrations
{
    public class MobileAppDbContext: DbContext
    {
        public MobileAppDbContext(DbContextOptions<MobileAppDbContext> options) : base(options)
        {
        }

        public DbSet<ApplicationData> ApplicationDatas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationData>().ToTable("ApplicationData");
        }

       
    }
}
