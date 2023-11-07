using HB.MvcAppWDB.Entities;
using Microsoft.EntityFrameworkCore;

namespace HB.MvcAppWDB.Context
{
    public class AppDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Kategori> Kategorler { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> option):base(option)
        {
                
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(x => x.Id);

            modelBuilder.Entity<Kitap>().Property(x => x.KategoriID).IsRequired(false);    

            modelBuilder.Entity<Kitap>().HasOne(x => x.Kategori).WithMany(x => x.Kitaplar).HasForeignKey(x => x.KategoriID).OnDelete(DeleteBehavior.SetNull);



        }



    }
}
