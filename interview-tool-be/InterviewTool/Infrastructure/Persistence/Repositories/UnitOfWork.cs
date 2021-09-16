using InterviewTool.Domain.Repositories;
using System;
using System.Threading.Tasks;

namespace InterviewTool.Infrastructure.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;
        private IChapterRepository _chapterRepository;
        private readonly ITopicRepository _topicRepository;
        private readonly IChapterResultRepository _chapterResultRepository;
        private readonly ITopicResultRepository _topicResultRepository;
        private readonly IInterviewRepository _interviewRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IChapterRepository ChapterRepository
        {
            get
            {
                if (_chapterRepository == null)
                {
                    _chapterRepository = new ChapterRepository(_context);
                }

                return _chapterRepository;
            }
        }

        public ITopicRepository TopicRepository => _topicRepository ?? new TopicRepository(_context);

        public IChapterResultRepository ChapterResultRepository => _chapterResultRepository ?? new ChapterResultRepository(_context);

        public ITopicResultRepository TopicResultRepository => _topicResultRepository ?? new TopicResultRepository(_context);

        public IInterviewRepository InterviewRepository => _interviewRepository ?? new InterviewRepository(_context);

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
