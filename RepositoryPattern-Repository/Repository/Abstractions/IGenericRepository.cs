namespace RepositoryPattern_Repository.Repository.Abstractions
{
    public interface IGenericRepository<T> 
    {
        void DeleteRange(IEnumerable<T> entities);
        void Update(T entity);
        Task CreateAsync(T entity);
    }
}