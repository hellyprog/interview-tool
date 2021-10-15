using InterviewTool.Domain.Entities;
using InterviewTool.Domain.Repositories;

namespace InterviewTool.Infrastructure.Persistence.Repositories
{
    public class TechnologyRepository : BaseRepository<Technology>, ITechnologyRepository
    {
        public TechnologyRepository(ApplicationDbContext context) : base(context) { }
    }
}
