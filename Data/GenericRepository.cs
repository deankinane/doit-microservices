using doit.backend.Models;

namespace doit.backend.Data
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        public GenericRepository(AppDbContext appDbContext)
        {
            AppDbContext = appDbContext;
        }
        public AppDbContext AppDbContext { get; }

        public async Task<TEntity> Create(TEntity entity)
        {
            var track = await AppDbContext.AddAsync<TEntity>(entity);
            return track.Entity;
        }

        public void Delete(TEntity entity)
        {
            AppDbContext.Remove<TEntity>(entity);
        }

        public async Task<TEntity?> Get(int id)
        {
            var entity = await AppDbContext.FindAsync<TEntity>(id);
            return entity;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return AppDbContext.Set<TEntity>().AsEnumerable();
        }

        public TEntity Update(TEntity entity)
        {
            var updated = AppDbContext.Update<TEntity>(entity);
            return updated.Entity;
        }

        public Task SaveChanges()
        {
            return AppDbContext.SaveChangesAsync();
        }

    }
}
