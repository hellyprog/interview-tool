using InterviewTool.Domain.Entities;
using InterviewTool.Domain.Repositories;

namespace InterviewTool.Infrastructure.Persistence.Repositories
{
    public class InterviewRepository : BaseRepository<Interview>, IInterviewRepository
    {
        public InterviewRepository(ApplicationDbContext context) : base(context) { }
    }
}
