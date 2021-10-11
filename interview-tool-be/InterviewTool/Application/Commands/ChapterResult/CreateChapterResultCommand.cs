using InterviewTool.Application.Models;
using MediatR;

namespace InterviewTool.Application.Commands
{
    public class CreateChapterResultCommand : IRequest<ExecutionResult>
    {
        public double Point { get; set; }
        public int ChapterId { get; set; }
        public int InterviewId { get; set; }
    }
}
