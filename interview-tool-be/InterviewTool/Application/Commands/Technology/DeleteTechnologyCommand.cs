using InterviewTool.Application.Models;
using MediatR;

namespace InterviewTool.Application.Commands
{
    public class DeleteTechnologyCommand : IRequest<ExecutionResult>
    {
        public int TechnologyId { get; set; }
    }
}
