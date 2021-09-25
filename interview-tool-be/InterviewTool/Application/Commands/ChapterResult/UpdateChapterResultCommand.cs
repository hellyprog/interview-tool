using InterviewTool.Application.Models;
using MediatR;

namespace InterviewTool.Application.Commands
{
    public class UpdateChapterResultCommand : IRequest<ExecutionResult>
    {
        public int ChapterResultId { get; set; }
        public double Point { get; set; }
    }
}
