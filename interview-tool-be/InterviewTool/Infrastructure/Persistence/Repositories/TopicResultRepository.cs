using InterviewTool.Domain.Entities;
using InterviewTool.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTool.Infrastructure.Persistence.Repositories
{
    public class TopicResultRepository : BaseRepository<TopicResult>, ITopicResultRepository
    {
        public TopicResultRepository(ApplicationDbContext context) : base(context) { }
    }
}
