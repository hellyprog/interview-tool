using InterviewTool.Domain.Entities;
using InterviewTool.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTool.Infrastructure.Persistence.Repositories
{
    public class InterviewRepository : BaseRepository<Interview>, IInterviewRepository
    {
        public InterviewRepository(ApplicationDbContext context) : base(context) { }
    }
}
