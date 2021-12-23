using HospitalApp.Entities;
using HospitalApp.Interfaces;
using HospitalApp.Models;

namespace HospitalApp.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel {
    
        protected RepositoryContext repositoryContext { get; set; }

        public BaseRepository(RepositoryContext _repositoryContext) {
            repositoryContext = _repositoryContext;
        }

        public void Add(T entity)
        {
            repositoryContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            repositoryContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            repositoryContext.Set<T>().Remove(entity);
        }

        public T Get(Guid id)
        {
            return repositoryContext.Set<T>().Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return repositoryContext.Set<T>().AsQueryable();
        }

        public void Save()
        {
            repositoryContext.SaveChanges();
        }
    }
}
