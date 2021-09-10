using InterviewTool.Application.Models;
using MediatR;

namespace InterviewTool.Application.Commands
{
    public class UpdateTopicCommand : IRequest<ExecutionResult>
    {
        public int TopicId { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
    }
}
