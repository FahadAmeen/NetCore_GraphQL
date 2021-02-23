using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCore_GraphQL.Data;
using NetCore_GraphQL.Data.Entities;

namespace NetCore_GraphQL.Repositories
{
    public class ProductRepository
    {
        private readonly MyDbContext _dbContext;

        public ProductRepository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Product>> GetAll()
        {
            return _dbContext.Products.ToListAsync();
        }
    }
}