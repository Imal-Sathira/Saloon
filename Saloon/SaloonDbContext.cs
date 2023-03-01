using Microsoft.EntityFrameworkCore;

namespace Saloon
{
    public class SaloonDbContext:DbContext
    {
        public SaloonDbContext()
        {
        }

        public SaloonDbContext(DbContextOptions<SaloonDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbConnection = "Server=localhost;Database=Saloon;Uid='root'; Pwd=0006624413Lm@;";
            MySqlServerVersion mySqlServerVersion = new MySqlServerVersion(new Version(8, 0, 30));
            optionsBuilder.UseMySql(dbConnection, mySqlServerVersion);
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Booking> Bookings { get; set; }

    }
}
