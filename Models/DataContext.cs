using Microsoft.EntityFrameworkCore;

namespace CarRental.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        // Define here below what of your model classes should have a table on the DB
        public DbSet<Car> Cars { get; set; }
    }
}