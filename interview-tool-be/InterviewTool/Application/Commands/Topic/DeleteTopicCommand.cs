using InterviewTool.Application.Models;
using MediatR;

namespace InterviewTool.Application.Commands
{
    public class DeleteTopicCommand : IRequest<ExecutionResult>
    {
        public int TopicId { get; set; }
    }
}
