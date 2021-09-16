using InterviewTool.Domain.Entities;
using InterviewTool.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTool.Infrastructure.Persistence.Repositories
{
    public class ChapterResultRepository : BaseRepository<ChapterResult>, IChapterResultRepository
    {
        public ChapterResultRepository(ApplicationDbContext context) : base(context) { }
    }
}
