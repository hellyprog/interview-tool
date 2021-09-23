using InterviewTool.Domain.Entities;
using InterviewTool.Domain.Repositories;

namespace InterviewTool.Infrastructure.Persistence.Repositories
{
    public class ChapterResultRepository : BaseRepository<ChapterResult>, IChapterResultRepository
    {
        public ChapterResultRepository(ApplicationDbContext context) : base(context) { }
    }
}
