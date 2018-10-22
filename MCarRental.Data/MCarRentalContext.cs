using MCarRental.Domain;
using Microsoft.EntityFrameworkCore;

namespace MCarRental.Data
{
    public class MCarRentalContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        //public static readonly LoggerFactory JamCarRentalLoggerFactory
        //    = new LoggerFactory(new[]
        //    {
        //        new ConsoleLoggerProvider((category, level)
        //            => category == DbLoggerCategory.Database.Command.Name
        //               && level == LogLevel.Information, true)
        //    });

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                  .UseSqlServer(@"Server=tcp:morgans.database.windows.net,1433;Initial Catalog=MorgansDb;Persist Security Info=False;User ID=morgan;Password=B3rglund;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            //    .EnableSensitiveDataLogging()
            //    .UseLoggerFactory(JamCarRentalLoggerFactory)
        }
    }
}