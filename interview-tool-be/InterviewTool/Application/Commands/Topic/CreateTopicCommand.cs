using InterviewTool.Application.Models;
using MediatR;

namespace InterviewTool.Application.Commands
{
    public class CreateTopicCommand : IRequest<ExecutionResult>
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int ChapterId { get; set; }
        public int TechnologyId { get; set; }
    }
}
