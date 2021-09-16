using System.Threading.Tasks;

namespace InterviewTool.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task<int> SaveAsync();
        IChapterRepository ChapterRepository { get; }
        ITopicRepository TopicRepository { get; }
        IChapterResultRepository ChapterResultRepository { get; }
        ITopicResultRepository TopicResultRepository { get; }
        IInterviewRepository InterviewRepository { get; }
    }
}
