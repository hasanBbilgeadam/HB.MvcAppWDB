using HB.MvcAppWDB.Entities;
using Microsoft.EntityFrameworkCore;

namespace HB.MvcAppWDB.Context
{
    public class AppDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> option):base(option)
        {
                
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(x => x.Id);
        }



    }
}
