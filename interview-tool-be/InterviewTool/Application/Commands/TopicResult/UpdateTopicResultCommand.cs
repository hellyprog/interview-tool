using InterviewTool.Application.Models;
using MediatR;

namespace InterviewTool.Application.Commands
{
    public class UpdateTopicResultCommand : IRequest<ExecutionResult>
    {
        public int TopicResultId { get; set; }
        public int? Point { get; set; }
    }
}
