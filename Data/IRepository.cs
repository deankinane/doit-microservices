using doit.backend.Models;

namespace doit.backend.Data
{
    public interface IRepository<T> where T : IEntity
    {
        public IEnumerable<T> GetAll();
        public Task<T?> Get(int id);
        public Task<T> Create(T entity);
        public T Update(T entity);
        public void Delete(T entity);
        public Task SaveChanges();
    }
}
