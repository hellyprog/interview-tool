using InterviewTool.Application.Models;
using MediatR;

namespace InterviewTool.Application.Commands
{
    public class UpdateChapterCommand : IRequest<ExecutionResult>
    {
        public int ChapterId { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
    }
}
