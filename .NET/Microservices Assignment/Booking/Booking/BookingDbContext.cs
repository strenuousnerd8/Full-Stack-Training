using Microsoft.EntityFrameworkCore;

namespace Booking
{
    public class BookingDbContext : DbContext
    {
        public BookingDbContext()
        {

        }
        public BookingDbContext(DbContextOptions<BookingDbContext> options) : base(options)
        {
        }

        public DbSet<TBooking> TBooking { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("AppDb");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}