using InterviewTool.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTool.Infrastructure.Persistence.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task DeleteById<K>(K id)
        {
            var entityToDelete = await _context.Set<T>().FindAsync(id);
            _context.Remove(entityToDelete);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsQueryable();
        }

        public Task<T> GetById<K>(K id)
        {
            return _context.Set<T>().FindAsync(id).AsTask();
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Insert(ICollection<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
