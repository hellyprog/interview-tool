using InterviewTool.Application.Models;
using MediatR;

namespace InterviewTool.Application.Commands
{
    public class UpdateInterviewCommand : IRequest<ExecutionResult>
    {
        public int InterviewId { get; set; }
        public string CandidateName { get; set; }
    }
}
