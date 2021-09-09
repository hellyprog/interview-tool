using InterviewTool.Domain.Entities;
using InterviewTool.Domain.Repositories;

namespace InterviewTool.Infrastructure.Persistence.Repositories
{
    public class TopicRepository : BaseRepository<Topic>, ITopicRepository
    {
        public TopicRepository(ApplicationDbContext context) : base(context) { }
    }
}
