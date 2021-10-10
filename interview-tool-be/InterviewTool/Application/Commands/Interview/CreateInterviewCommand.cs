using InterviewTool.Application.Models;
using MediatR;

namespace InterviewTool.Application.Commands
{
    public class CreateInterviewCommand : IRequest<ExecutionResult>
    {
        public string CandidateName { get; set; }
        public bool IsFinished { get; set; }
    }
}
