using Microsoft.EntityFrameworkCore;
using Inventory_Management_System_Demo.Models;
namespace Inventory_Management_System_Demo.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Item> Items { get; set; }
}
