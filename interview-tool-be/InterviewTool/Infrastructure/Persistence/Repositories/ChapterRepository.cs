using InterviewTool.Domain.Entities;
using InterviewTool.Domain.Repositories;

namespace InterviewTool.Infrastructure.Persistence.Repositories
{
    public class ChapterRepository : BaseRepository<Chapter>, IChapterRepository
    {
        public ChapterRepository(ApplicationDbContext context) : base(context) { }
    }
}
