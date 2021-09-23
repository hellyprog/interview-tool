using InterviewTool.Domain.Entities;
using InterviewTool.Domain.Repositories;

namespace InterviewTool.Infrastructure.Persistence.Repositories
{
    public class TopicResultRepository : BaseRepository<TopicResult>, ITopicResultRepository
    {
        public TopicResultRepository(ApplicationDbContext context) : base(context) { }
    }
}
