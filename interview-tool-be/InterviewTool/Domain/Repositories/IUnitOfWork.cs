using System.Threading.Tasks;

namespace InterviewTool.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task<int> SaveAsync();
        IChapterRepository ChapterRepository { get; }
        IChapterResultRepository ChapterResultRepository { get; }
        IInterviewRepository InterviewRepository { get; }
        ITechnologyRepository TechnologyRepository { get; }
        ITopicRepository TopicRepository { get; }
        ITopicResultRepository TopicResultRepository { get; }
    }
}
