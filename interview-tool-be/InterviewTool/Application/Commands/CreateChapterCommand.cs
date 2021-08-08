using InterviewTool.Application.Models;
using MediatR;

namespace InterviewTool.Application.Commands
{
    public class CreateChapterCommand : IRequest<ExecutionResult>
    {
        public string Name { get; set; }
        public double Weight { get; set; }
    }
}
