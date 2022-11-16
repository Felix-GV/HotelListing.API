using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext 
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Hotel> Hotels { get; set; }
        
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                new Country
                {
                    Id = 2,
                    Name = "Australia",
                    ShortName = "AUS"
                },
                new Country
                {
                    Id = 3,
                    Name = "United States of America",
                    ShortName = "USA"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    HotelId = 1,
                    Name = "Sandals Resort & Spa",
                    Address = "Negril, Jamaica",
                    Rating = 4.5,
                    CountryId = 1
                },
                new Hotel
                {
                    HotelId = 2,
                    Name = "Hyatt",
                    Address = "Canberra, Australia",
                    Rating = 4.8,
                    CountryId = 1
                },
                new Hotel
                {
                    HotelId = 3,
                    Name = "Marriot",
                    Address = "Miami, USA",
                    Rating = 4.3,
                    CountryId = 1
                }
            );
        }
    }
}
