using InterviewTool.Application.Models;
using MediatR;

namespace InterviewTool.Application.Commands
{
    public class UpdateTechnologyCommand : IRequest<ExecutionResult>
    {
        public int TechnologyId { get; set; }
        public string TechnologyName { get; set; }
    }
}
