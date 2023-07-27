using Microsoft.EntityFrameworkCore;
using RepositoryPattern_Repository.Data;
using RepositoryPattern_Repository.Repository.Abstractions;
using ReposittoryPattern_Models.Models;

namespace RepositoryPattern_Repository.Repository.Implementations
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly DbSet<Customer> customers;

        public CustomerRepository(AppDbContext appDbContextmers) : base(appDbContextmers)
        {
            _appDbContext = _appDbContext;
            customers = _appDbContext.Set<Customer>();
        }
       
        public Customer GetCustomer(int id)
        {
            Customer customer = customers.Find(id);
            return customer;
        }
        public async Task<Customer> GetCustomerAsync(int id)
        {
            Customer customer = await customers.FindAsync(id);
            return customer;
        }
        public IQueryable<Customer> GetAllCustomer()
        {
            IEnumerable<Customer> getAllCustomer = customers.Include(x => x.Products);
            return customers;
        } 
        // Reminder: Querying an entity through another entity that shares a relationship.
    }
}