using Microsoft.EntityFrameworkCore;
using RepositoryPattern_Repository.Data;
using RepositoryPattern_Repository.Repository.Abstractions;
using ReposittoryPattern_Models.Models;

namespace RepositoryPattern_Repository.Repository.Implementations
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly DbSet<Product> _dbSet;
        public ProductRepository(AppDbContext context): base(context) 
        {
            _appDbContext = context;
            _dbSet = _appDbContext.Set<Product>();
        }
        public async Task<IEnumerable<Product>> GetAllProductByCustomerId(int id)
        {
            IEnumerable<Product> products = await _dbSet.Where(x => x.CustomerId == id).ToListAsync(); 
            return products;
        }
        public async Task<Product> GetProductById(int id)
        {
            Product product = await _dbSet.FindAsync(id);
            return product;
        }
    }
}
