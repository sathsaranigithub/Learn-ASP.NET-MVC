using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace ServiceStation.Web.Models
{
    public class ServiceDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleService> VehicleServices { get; set; }
        // The constructor receives configuration options (like connection string)
        // and passes them to the base DbContext class.
        // This allows EF Core to know how to connect to your database.
        public ServiceDbContext(DbContextOptions<ServiceDbContext> options) : base(options) 
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=(localdb)\MSSQLLocaldb;Database=ServiceStation;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
