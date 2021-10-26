using InterviewTool.Application.Models;
using MediatR;

namespace InterviewTool.Application.Commands
{
    public class CreateTopicResultCommand : IRequest<ExecutionResult>
    {
        public int Point { get; set; }
        public int TopicId { get; set; }
        public int ChapterResultId { get; set; }
    }
}
