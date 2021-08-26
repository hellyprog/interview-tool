using InterviewTool.Application.Models;
using MediatR;

namespace InterviewTool.Application.Commands
{
    public class DeleteChapterCommand : IRequest<ExecutionResult>
    {
        public int ChapterId { get; set; }
    }
}
