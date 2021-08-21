using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTool.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task<int> SaveAsync();
        IChapterRepository ChapterRepository { get; }
    }
}
