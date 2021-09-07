using System.Threading.Tasks;

namespace InterviewTool.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task<int> SaveAsync();
        IChapterRepository ChapterRepository { get; }
        ITopicRepository TopicRepository { get; }
    }
}
