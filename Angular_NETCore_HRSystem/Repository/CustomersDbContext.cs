using Angular_ASPNETCore_CustomersService.Models;
using Microsoft.EntityFrameworkCore;

namespace Angular_ASPNETCore_CustomersService.Repository
{
  public class CustomersDbContext : DbContext
  {
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<State> States { get; set; }

    public CustomersDbContext(DbContextOptions<CustomersDbContext> options) : base(options) { }
  }

}
