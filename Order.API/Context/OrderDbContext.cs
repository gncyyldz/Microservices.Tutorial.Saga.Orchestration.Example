using Microsoft.EntityFrameworkCore;
using Order.API.Models;

namespace Order.API.Context
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Models.Order> Orders { get; set; }
        public DbSet<OrderItem> OrderITems { get; set; }
    }
}
