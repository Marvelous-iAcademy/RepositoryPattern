using RepositoryPattern_Repository.Data;
using RepositoryPattern_Repository.Repository.Abstractions;
using ReposittoryPattern_Models.Models;

namespace RepositoryPattern_Repository.Repository.Implementations
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        private readonly AppDbContext _appDbContext;

        public CustomerRepository(AppDbContext appDbContext):base(appDbContext) 
        {
            _appDbContext = appDbContext;
        }
        public Task CreateAsync(Customer entity)
        {
            throw new NotImplementedException();
        }
        public void DeleteAsync(Customer entity)
        {
            throw new NotImplementedException();
        }
        public void DeleteRange(IEnumerable<Customer> entities)
        {
            throw new NotImplementedException();
        }
    }
}