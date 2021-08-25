using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTool.Domain.Repositories
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        Task<T> GetById<K>(K id);
        void Insert(T entity);
        void Insert(ICollection<T> entities);
        void Update(T entity);
        Task DeleteById<K>(K id);
    }
}
