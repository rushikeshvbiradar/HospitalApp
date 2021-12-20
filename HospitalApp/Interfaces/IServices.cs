namespace HospitalApp.Interfaces
{
    public interface IServices<T>
    {
        void Add(T obj);
        void Edit(T obj);
        void Delete(Guid id);
        T? Get(Guid id);
        List<T> GetAll();
    }
}
