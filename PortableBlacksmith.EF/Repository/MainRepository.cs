using PortableBlacksmith.EF.Repository.Interfaces;

namespace PortableBlacksmith.EF.Repository
{
    public class MainRepository<T> : IMainRepository<T>
    {
        private readonly PBDBContext _context;
        public MainRepository(PBDBContext context)
        {
            _context = context;
        }
        public async Task<T> CreateAsync(T entity)
        {
            var addedEntity = await _context.AddAsync(entity);

            return (T)addedEntity.Entity;
        }

        public T Update(T entity)
        {
            var updatedEntity = _context.Update(entity);

            return (T)updatedEntity.Entity;
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
        }
    }
}
