using Microsoft.EntityFrameworkCore;
using NetCore_GraphQL.Data.Entities;

namespace NetCore_GraphQL.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}