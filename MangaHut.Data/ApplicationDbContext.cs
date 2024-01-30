using MangaHut.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MangaHut.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){}

        public DbSet<Store> Stores { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Manga> Mangas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Store>().HasData(
                new Store
                {
                    Id=1
                }
            );
            modelBuilder.Entity<Location>().HasData(
                new Location
                {
                    Id = 1,
                    Address="123 home court",
                    City="Noblesville",
                    State = "Indiana",
                    ZipCode="46060",
                    StoreId = 1
                }
            );

            modelBuilder.Entity<Manga>().HasData(
                new Manga
                {
                    Id = 1,
                    Title= "Death Note",
                    Author ="Tsugumi Ohba"
                }
            );

            modelBuilder.Entity<StoreManga>().HasData(
                new StoreManga
                {
                    Id = 1,
                    StoreId = 1,
                    MangaId = 1
                }
            );

        }
    }
}