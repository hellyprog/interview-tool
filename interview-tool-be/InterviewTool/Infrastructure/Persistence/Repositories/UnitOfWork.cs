using InterviewTool.Domain.Repositories;
using System;
using System.Threading.Tasks;

namespace InterviewTool.Infrastructure.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;
        private readonly IChapterRepository _chapterRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IChapterRepository ChapterRepository => _chapterRepository ?? new ChapterRepository(_context);

        public Task<int> SaveAsync()
        {
            return _context.SaveChangesAsync();
        }

        #region Dispose
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
