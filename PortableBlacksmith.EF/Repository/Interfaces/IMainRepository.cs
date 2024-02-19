namespace PortableBlacksmith.EF.Repository.Interfaces
{
    public interface IMainRepository<T>
    {
        Task<T> CreateAsync(T entity);
        void Delete(T entity);
        T Update(T entity);
    }
}