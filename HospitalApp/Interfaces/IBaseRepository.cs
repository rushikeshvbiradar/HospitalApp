namespace HospitalApp.Interfaces
{
    public interface IBaseRepository<T> {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(Guid id);
        IQueryable<T> GetAll();
        void Save();
    }
}